using System;
using System.Windows.Forms;
using AppSharedMemory.Model;
using AppSharedMemory.Service;
using AppSharedMemory.utils;

namespace AppSharedMemory
{
    public partial class FrmCategorie : Form
    {
        private readonly CategorieService categorieService;
        private readonly Loggers logger;

        public FrmCategorie()
        {
            InitializeComponent();
            categorieService = new CategorieService();
            logger = new Loggers();
        }

        [Obsolete]
        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCategorie.DataSource = categorieService.servGetListCategorie();
            }
            catch (Exception ex)
            {
                LogError("Chargement des catégories", ex);
                MessageBox.Show("L'API de la liste des catégories n'est pas disponible!");
                Application.Exit();
            }
        }

        [Obsolete]
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) || string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            Categorie categorie = new Categorie
            {
                codeCategorie = txtCode.Text,
                libelleCategorie = txtLibelle.Text
            };

            try
            {
                categorieService.AddCategorie(categorie);
                effacer();
                MessageBox.Show("Succès!");
            }
            catch (Exception ex)
            {
                LogError("Enregistrement de la catégorie", ex);
                MessageBox.Show("L'API n'est pas disponible!");
            }
        }

        [Obsolete]
        public void effacer()
        {
            txtCode.Clear();
            txtLibelle.Clear();
            txtCode.Focus();
            try
            {
                dtgCategorie.DataSource = categorieService.servGetListCategorie();
            }
            catch (Exception ex)
            {
                LogError("Effacement des champs", ex);
                MessageBox.Show("Impossible de rafraîchir la liste des catégories.");
            }
        }

        [Obsolete]
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dtgCategorie.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            if (!int.TryParse(dtgCategorie.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("ID de catégorie invalide.");
                return;
            }

            var catg = categorieService.GetCategorie(id);
            catg.codeCategorie = txtCode.Text;
            catg.libelleCategorie = txtLibelle.Text;

            try
            {
                categorieService.UpdateCategorie(catg, id);
                effacer();
                MessageBox.Show("Modification effectuée!");
                btnEnregistrer.Enabled = true;
            }
            catch (Exception ex)
            {
                LogError("Modification de la catégorie", ex);
                MessageBox.Show("L'API n'est pas disponible!");
            }
        }

        [Obsolete]
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dtgCategorie.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            if (!int.TryParse(dtgCategorie.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("ID de catégorie invalide.");
                return;
            }

            try
            {
                categorieService.DeleteCategorie(id);
                effacer();
                MessageBox.Show("Suppression réussie.");
                btnEnregistrer.Enabled = true;
            }
            catch (Exception ex)
            {
                LogError("Suppression de la catégorie", ex);
                MessageBox.Show("L'API n'est pas disponible!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgCategorie.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.");
                return;
            }

            txtCode.Text = dtgCategorie.CurrentRow.Cells[1].Value.ToString();
            txtLibelle.Text = dtgCategorie.CurrentRow.Cells[2].Value.ToString();
            btnEnregistrer.Enabled = false;
        }

        private void LogError(string titreErreur, Exception ex)
        {
            logger.WriteDataError(titreErreur, ex.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogs frmLogs = new frmLogs();
            frmLogs.Show();
        }
    }
}
