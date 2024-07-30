using MetierSharedMemory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierSharedMemory
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        private DbSharedMemoryContext db;
                
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        /// <summary>
        /// ajouter encadreur
        /// </summary>
        /// <param name="encadreur"></param>
        /// <returns></returns>
        public bool addEncadreur(Encadreur encadreur) {
            try
            {
                db.encadreurs.Add(encadreur);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Liste de tous encadreur
        /// </summary>
        /// <returns></returns>
        public List<Encadreur> GetAllEncadreur()
        {
            return db.encadreurs.ToList();
        }

        /// <summary>
        /// demande d'un encadreur
        /// </summary>
        /// <param name="IdEncadreur"></param>
        /// <returns></returns>
        public Encadreur GetEncadreur(int? IdEncadreur)
        {
            return db.encadreurs.Find(IdEncadreur);
        }

        /// <summary>
        /// supprimer encadreur
        /// </summary>
        /// <param name="IdEncadreur"></param>
        /// <returns></returns>
        public bool deleteEncadreur(int? IdEncadreur)
        {
            try
            {
                var leEncadreur = db.encadreurs.Find(IdEncadreur);
                if (leEncadreur != null)
                {
                    db.encadreurs.Remove(leEncadreur);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// modifier encadreur
        /// </summary>
        /// <param name="encadreur"></param>
        /// <returns></returns>
        public bool updateEncadreur(Encadreur encadreur)
        {
            try
            {
                var leEncadreur = db.encadreurs.Find(encadreur.IdPersonne);
                if (leEncadreur != null)
                {
                    leEncadreur.Prenom = encadreur.Prenom;
                    leEncadreur.Nom = encadreur.Nom;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e) {
                return false;
            }
        }

        /// <summary>
        /// Liste des encadreurs avec filtrage de nom, prenom ou specialite
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="specialiteEncadreur"></param>
        /// <returns></returns>
        public List<Encadreur> GetEncadreurs(string nom, string prenom, string specialiteEncadreur)
        {
            var liste = db.encadreurs.ToList();
            
            if (!string.IsNullOrEmpty(nom))
            {
                liste = liste.Where(a => a.Nom.ToUpper().Contains(nom.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(prenom))
            {
                liste = liste.Where(a => a.Prenom.ToUpper().Contains(prenom.ToUpper())).ToList();
            }

            if (!string.IsNullOrEmpty(specialiteEncadreur))
            {
                liste = liste.Where(a => a.SpecialiteEncadreur.ToUpper().Contains(specialiteEncadreur.ToUpper())).ToList();
            }


            return liste;
        }
    }
}
