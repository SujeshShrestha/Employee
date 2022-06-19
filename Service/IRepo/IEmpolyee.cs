using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IRepo
{
   public interface IEmpolyee:IDisposable
    {
        IEnumerable<Employee> GetList();
        Employee GetRecord();
        Employee GetByID(int id);
        void Insert(Employee Employee);
        void Delete(int id);
        void Update(Employee Employee);
        void Save();
    }
}
