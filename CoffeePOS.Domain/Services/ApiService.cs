using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.Domain.Services
{
    public class ApiService<T> : IDataService<T> where T : class
    {
        private string baseUrl = "http://localhost/api/";

        public string BaseUrl
        {
            get { return baseUrl; }
            set { baseUrl = value; }
        }

        public ApiService(string urlExtension = "")
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
                HttpResponseMessage response = await client.GetAsync(BaseUrl + id);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                T objectToResponse = JsonConvert.DeserializeObject<T>(jsonResponse);
                return objectToResponse;
            }
            
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Store(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
