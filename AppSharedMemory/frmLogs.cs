using ApiMetiers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSharedMemory
{
    public partial class frmLogs : Form
    {
        private readonly baseVenteEntities1 db;
        public frmLogs()
        {
            InitializeComponent();
            db = new baseVenteEntities1();
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                var logs = db.Td_erreur.OrderByDescending(er => er.dateErreur).ToList();

                if (logs.Count == 0)
                {
                    dtgLogs.DataSource = null;
                    dtgLogs.Rows.Clear();
                    dtgLogs.Columns.Clear();
                    dtgLogs.Columns.Add("Message", "Message");
                    dtgLogs.Rows.Add("Aucune erreur n'a été enregistrée.");
                }
                else
                {
                    dtgLogs.DataSource = logs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des logs: {ex.Message}");
            }
        }
    }
}
