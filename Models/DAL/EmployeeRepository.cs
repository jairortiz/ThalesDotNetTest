using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThalesDotNetTest.Models.DAL
{
    public class EmployeeRepository : IRepository<Employee>
    {
        DataContext _dataContext = new DataContext();
        public async Task<Employee> Get(int id)
        {
            return await _dataContext.GetById(id);
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {            
            return await _dataContext.Get(); 
        }

        public async Task<IEnumerable<Employee>> GetByIdAsync(int Id)
        {
            return await _dataContext.GetByIdAsync(Id);
        }
    }
}
