using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_MVC.Model;

namespace Test_MVC.db.dbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmploayeeModel model)
        {
            using (var contex = new Test_DBEntities())
            {
                try
                {
                    tb_Employee emp = new tb_Employee()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        Code = model.Code
                    };

                    contex.tb_Employee.Add(emp);
                    contex.SaveChanges();

                    return emp.employeeID;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
