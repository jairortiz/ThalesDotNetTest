using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;

namespace ThalesDotNetTest.Models.DAL
{
    public class DataContext
    {
        IEnumerable<Employee> _employees;

        public DataContext()
        {
            LoadData();
        }
        public Task<IEnumerable<Employee>> Get()
        {
            return Task.FromResult(_employees);
        }

        public Task<Employee> GetById(int id)
        {
            var employee = _employees.Where(p => p.id == id).FirstOrDefault();
            return Task.FromResult(employee);
        }

        public Task<IEnumerable<Employee>> GetByIdAsync(int id)
        {
            var employee = _employees.Where(p => p.id == id);
            return Task.FromResult(employee);
        }

        private void LoadData()
        {
            try
            {
                var webRequest = WebRequest.Create(Resources.API_URL) as HttpWebRequest;

                webRequest.ContentType = "application/json";
                webRequest.UserAgent = "Nothing";                

                using (var s = webRequest.GetResponse().GetResponseStream())
                {
                    using (var sr = new StreamReader(s))
                    {
                        var employeeJson = sr.ReadToEnd();
                        _employees = JsonConvert.DeserializeObject<RootObject<Employee>>(employeeJson).Employees;
                    }
                }
            }
            catch (System.Exception ex)
            {
                //Test data, avoid the "Too many Requests" restriction
                _employees = JsonConvert.DeserializeObject<RootObject<Employee>>(Resources.EmployeeData).Employees;
                              
            }
            

        }
    }

    public class RootObject <T>
    {
        [JsonProperty("data")]
        public List<T> Employees { get; set; }
    }
}
