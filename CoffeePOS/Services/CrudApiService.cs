using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Services
{
    /// <summary>
    /// This will handle most of basic crud operations for each entity.
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class CrudApiService<T> : IDataService<T> where T : class
    {
        private string baseUrl = "http://localhost/api/";

        public string BaseUrl
        {
            get { return baseUrl; }
            set { baseUrl = value; }
        }

        public CrudApiService(string urlExtension = "")
        {
            BaseUrl = BaseUrl + urlExtension;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Find(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                // Setting content type.  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(BaseUrl + id);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                T responseObject = JsonConvert.DeserializeObject<T>(jsonResponse);
                return responseObject;
            }

        }

        public async Task<List<T>> GetAll()
        {
            
            using (HttpClient client = new HttpClient())
            {
                // Setting accept type.  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(BaseUrl);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<List<T>>(jsonResponse);
                return responseObject;
            }
        }

        public async Task<T> Store(T entity)
        {
            using (HttpClient client = new HttpClient())
            {
                // Setting accept type.  
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string entityString = JsonConvert.SerializeObject(entity); ;
                var content = new StringContent(entityString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(BaseUrl, content);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<T>(jsonResponse);
                return responseObject;
            }
            
        }

        public Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
