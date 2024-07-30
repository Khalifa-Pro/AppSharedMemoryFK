using AppSharedMemory.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AppSharedMemory.Service
{
    public class CategorieService
    {
        /// <summary>
        /// LISTE DES CATEGORIE
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        public  List<Categorie> servGetListCategorie() 
        {
            HttpClient client;
            client = new HttpClient();
            var services = new List<Categorie>();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServer"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("groupe2/Categories/GetCategorie").Result;
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                services = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Categorie>>(responseData);
            }
            return services;

        }

        /// <summary>
        /// AJOUTER CATEGORIE
        /// </summary>
        /// <param name="categorie"></param>
        /// <returns></returns>
        [Obsolete]
        public bool AddCategorie(Categorie categorie)
        {
            bool result = false;
            string id = categorie.idCategorie > 0 ? categorie.idCategorie.ToString() : "0";
            var values = new Dictionary<string, string>
            {
                { "idCategorie", id },
                { "codeCategorie", categorie.codeCategorie },
                { "libelleCategorie", categorie.libelleCategorie }
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServer"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PostAsync("groupe2/Categories/PostCategorie", content).Result;

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


        /// <summary>
        /// SUPPRIMER CATEGORIE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Obsolete]
        public bool DeleteCategorie(int id)
        {
            HttpClient client;
            client = new HttpClient();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServer"]);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.DeleteAsync("groupe2/Categories/DeleteCategorie/"+id).Result;
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            { 
                return false;
            }

        }

        /// <summary>
        /// GET CATEGORIE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Obsolete]
        public Categorie GetCategorie(int id)
        {
            HttpClient client;
            client = new HttpClient();
            var categorie = new Categorie();
            client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServer"]);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync("groupe2/Categories/GetCategorie/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseData = response.Content.ReadAsStringAsync().Result;
                categorie = Newtonsoft.Json.JsonConvert.DeserializeObject<Categorie>(responseData);
            }
            return categorie;

        }

        [Obsolete]
        public bool UpdateCategorie(Categorie categorie, int id) 
        {
            bool result = false;
            string idCat = categorie.idCategorie > 0 ? categorie.idCategorie.ToString() : "0";
            var values = new Dictionary<string, string>
            {
                { "idCategorie", idCat },
                { "codeCategorie", categorie.codeCategorie },
                { "libelleCategorie", categorie.libelleCategorie }
            };

            var content = new FormUrlEncodedContent(values);
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(System.Configuration.ConfigurationSettings.AppSettings["linkServer"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsync("groupe2/Categories/PutCategorie/"+id,content).Result;

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
