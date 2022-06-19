using Service.IRepo;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Repositories
{
    public class EmployeeRepositories : IEmpolyee
    {
        private EmployeeDbEntities context;
        public EmployeeRepositories(EmployeeDbEntities context)
        {
            this.context = context;
            
        }
        public void Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            employee.Table_status = true;
            this.Update(employee);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Employee GetByID(int id)
        {
            Employee tmpData = context.Employees.Find(id);
            if (tmpData == null)
            {
                return null;
            }
            if (tmpData.Table_status == true)
            {
                return null;
            }
            return tmpData;
        }

        public IEnumerable<Employee> GetList()
        {
            
            return context.Employees.Where(x => x.Table_status != true).OrderBy(x => x.Id).ToList();
        }

        public Employee GetRecord()
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee Employee)
        {
            Employee.Table_status = false;

            context.Employees.Add(Employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee Employee)
        {
            throw new NotImplementedException();
        }
    }
}