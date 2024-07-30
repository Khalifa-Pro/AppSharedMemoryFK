using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NotificationL3glGroupe2
{
    public partial class ServiceL3GL : ServiceBase
    {
        private static Timer aTimer;
        public ServiceL3GL()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            aTimer = new Timer(1000);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimeEvent);
            aTimer.Interval = 1000;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;

            writeLogSystem("Démarrage du systeme Notification L3 GL ", string.Format("à: {0}",DateTime.Now));
        }

        protected override void OnStop()
        {
            aTimer.Stop();
            aTimer.Dispose();
            writeLogSystem("Arret du service Notification L3 GL ", string.Format("Le service est arreté à: {0}", DateTime.Now));

        }

        private static void OnTimeEvent(object source, ElapsedEventArgs e) 
        {
            try
            {
                ProcessData().Wait();
            }
            catch (Exception ex) 
            {

            }
            aTimer.Start();
        }

        private static async Task ProcessData() 
        {
            try
            {
                writeLogSystem("Démarrage du systeme Notification L3 GL ", string.Format("Le service a démarré à: {0}", DateTime.Now));

            }
            catch (Exception ex) 
            {

            }
        }

        /// <summary>
        /// Permet de logger un systeme
        /// </summary>
        /// <param name="erreur">erreur</param>
        /// <param name="libelle">titre de l'erreur</param>

        public static void writeLogSystem(string erreur, string libelle) 
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Notification L3 GL - ";
                eventLog.WriteEntry(string.Format("Date : {0}, Libelle : {1}, Description: {2}",DateTime.Now,libelle,erreur));
            }
        }
    }
}
