using ApiMetiers.Models;
using System;
using System.Diagnostics;

namespace AppSharedMemory.utils
{
    public class Loggers
    {
        private baseVenteEntities1 db = new baseVenteEntities1();

        /// <summary>
        /// Cette méthode enregistre des logs dans la base de données
        /// </summary>
        /// <param name="TitreErreur"></param>
        /// <param name="erreur"></param>
        public void WriteDataError(string TitreErreur, string erreur)
        {
            try
            {
                Td_erreur log = new Td_erreur
                {
                    dateErreur = DateTime.Now,
                    descriptionErreur = erreur.Length > 3000 ? erreur.Substring(0, 3000) : erreur,
                    titreErreur = TitreErreur
                };
                db.Td_erreur.Add(log);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteLogSystem(ex.ToString(), "WriteDataError");
            }
        }

        /// <summary>
        /// Cette méthode enregistre des logs au niveau du système d'exploitation
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="erreur"></param>
        public static void WriteLogSystem(string libelle, string erreur)
        {
            string source = "AppSharedMemory";
            string log = "Application";

            try
            {
                if (!EventLog.SourceExists(source))
                {
                    // Vous devez être administrateur pour exécuter cette section de code
                    EventLog.CreateEventSource(source, log);
                }

                using (EventLog eventLog = new EventLog(log))
                {
                    eventLog.Source = source;
                    eventLog.WriteEntry(string.Format("date: {0}, libelle: {1}, description: {2}",
                        DateTime.Now, libelle, erreur), EventLogEntryType.Information, 101, 1);
                }
            }
            catch (Exception ex)
            {
                // Vous pouvez gérer l'erreur ici ou la consigner d'une autre manière
                Console.WriteLine("Failed to write to event log: " + ex.ToString());
            }
        }
    }
}
