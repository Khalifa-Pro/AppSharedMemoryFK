using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AppSharedMemory.Models;
using Newtonsoft.Json;

namespace AppSharedMemory.Services
{
    public class UtilisateurService
    {
        /// <summary>
        /// LISTE DES UTILISATEURS
        /// </summary>
        /// <returns>services : liste des utilisateurs</returns>
        public List<Utilisateur> servGetLUtilisateurs()
        {
            HttpClient client;
            client = new HttpClient();
            var services = new List<Utilisateur>();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServerPhp"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("backend/list.php").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                services = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Utilisateur>>(responseData);
            }
            return services;

        }

        /// <summary>
        /// AJOUTER UTILISATEUR
        /// </summary>
        /// <param name="categorie">Objet utilisateur</param>
        /// <returns>result = true si l'ajout passe false sinon</returns>
        public bool AddUtilisateur(Utilisateur utilisateur)
        {
            bool result = false;
            string id = utilisateur.id > 0 ? utilisateur.id.ToString() : "0";
            var values = new Dictionary<string, string>
            {
                { "id", id },
                { "nom", utilisateur.nom },
                { "prenom", utilisateur.prenom },
                { "age", utilisateur.age.ToString() }
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServerPhp"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsync("backend/create.php", content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = response.Content.ReadAsStringAsync().Result;
                        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseData);
                        result = jsonResponse.success == true;
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }


        ///// <summary>
        ///// SUPPRIMER UTILISATEUR
        ///// </summary>
        ///// <param name="id">id de l'utilisateur</param>
        ///// <returns>true si l'ajout passe false sinon</returns>
        public bool DeleteUtilisateur(int id)
        {
            HttpClient client;
            client = new HttpClient();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServerPhp"]);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.DeleteAsync("backend/delete.php?id="+id).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        ///// <summary>
        ///// GET Utilisateur
        ///// </summary>
        ///// <param name="id">id de l'utilisateur</param>
        ///// <returns>utilisateur</returns>
        public Utilisateur GetUtilisateur(int id)
        {
            HttpClient client;
            client = new HttpClient();
            var utilisateur = new Utilisateur();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServerPhp"]);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("backend/details.php?id="+id).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                utilisateur = Newtonsoft.Json.JsonConvert.DeserializeObject<Utilisateur>(responseData);
            }
            return utilisateur;

        }

        /// <summary>
        /// MODIFIER UTILISATEUR
        /// </summary>
        /// <param name="utilisateur">Objet utilisateur</param>
        /// <returns>result = true si l'ajout passe false sinon</returns>
        public bool UpdateUtilisateur(Utilisateur utilisateur)
        {
            bool result = false;
            string id = utilisateur.id > 0 ? utilisateur.id.ToString() : "0";
            var values = new Dictionary<string, string>
            {
                { "id", id },
                { "nom", utilisateur.nom },
                { "prenom", utilisateur.prenom },
                { "age", utilisateur.age.ToString() }
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServerPhp"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsync("backend/update.php",content).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var responseData = response.Content.ReadAsStringAsync().Result;
                        var jsonResponse = JsonConvert.DeserializeObject<dynamic>(responseData);
                        result = jsonResponse.success == true;
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
