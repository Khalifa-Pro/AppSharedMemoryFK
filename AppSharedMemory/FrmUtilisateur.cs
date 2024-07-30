using AppSharedMemory.Models;
using AppSharedMemory.Service;
using AppSharedMemory.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AppSharedMemory
{
    public partial class FrmUtilisateur : Form
    {
        /// <summary>
        /// INITIALISATION DU FORMULAIRE
        /// </summary>
        public FrmUtilisateur()
        {
            InitializeComponent();
        }

        UtilisateurService utilisateurService = new UtilisateurService();


        /// <summary>
        /// CHARGEMENT DE LA LISTE LORS DU DEMARRAGE DE L'APPLICATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {
            try
            {
                dtgUtilisateur.DataSource = utilisateurService.servGetLUtilisateurs();

            }
            catch (Exception ex)
            {
                MessageBox.Show("API de la liste des utiliteurs est indisponible");
                Application.Exit();
            }
        }

        /// <summary>
        /// ACTION D'AJOUT D'UN UTILISATEUR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }*/

            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le champs nom est obligatoire.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Le champs prenom est obligatoire.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Le champs age est obligatoire.");
                return;
            }
            else
            {
                Utilisateur utilisateur = new Utilisateur();
                utilisateur.nom = txtNom.Text;
                utilisateur.prenom = txtPrenom.Text;
                utilisateur.age = int.Parse(txtAge.Text);

                try
                {
                    utilisateurService.AddUtilisateur(utilisateur);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("API indisponible");

                }
                effacer();
            }
        }

        /// <summary>
        /// EFFACER LES VALEURS DES CHAMPS
        /// </summary>
        public void effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtAge.Clear();
            txtNom.Focus();
            dtgUtilisateur.DataSource = utilisateurService.servGetLUtilisateurs();
        }

        /// <summary>
        /// ACTION DE SUPPRESSION D'UN UTILISATEUR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dtgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            //var catg = categorieService.GetCategorie(id.Value);
            try
            {
                utilisateurService.DeleteUtilisateur(id.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("API indisponible");
            }
            effacer();
            btnAjouter.Enabled = true;
        }


        /// <summary>
        /// ACTION DE SELECTION D'UN UTILISATEUR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNom.Text = dtgUtilisateur.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dtgUtilisateur.CurrentRow.Cells[2].Value.ToString();
            txtAge.Text = dtgUtilisateur.CurrentRow.Cells[3].Value.ToString();
            btnAjouter.Enabled = false;
        }


        /// <summary>
        /// ACTION DE MODIFICATION D'UN UTILISATEUR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le champs nom est obligatoire.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Le champs prenom est obligatoire.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Le champs age est obligatoire.");
                return;
            }
            else
            {
                int? id = null;
                if (int.TryParse(dtgUtilisateur.CurrentRow.Cells[0].Value.ToString(), out int parsedId))
                {
                    id = parsedId;
                    var user = utilisateurService.GetUtilisateur(id.Value);
                    user.nom = txtNom.Text;
                    user.prenom = txtPrenom.Text;
                    user.age = int.Parse(txtAge.Text);
                    utilisateurService.UpdateUtilisateur(user);
                    effacer();
                    MessageBox.Show("Modification effectuée!");
                    btnAjouter.Enabled = true;
                }
                else
                {
                    // Handle the case where the conversion fails
                    MessageBox.Show("Api indisponible");
                    return;
                }
            }
        }
    }
}
