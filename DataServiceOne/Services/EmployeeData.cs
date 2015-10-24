using System.Collections.Generic;
using System.Linq;
using DataServiceOne.Models;

namespace DataServiceOne.Services
{
  public class EmployeeData
  {
    private List<Employee> _employees = new List<Employee>
    {
      new Employee {Pkid = 1, FirstName = "Peter", Surname = "Shaw", Salary = 40000, Department = "I.T"},
      new Employee {Pkid = 2, FirstName = "Fred", Surname = "Flintstone", Salary = 30000, Department = "Utilities"},
      new Employee {Pkid = 3, FirstName = "Issac", Surname = "Asimov", Salary = 50000, Department = "Literature"},
      new Employee {Pkid = 4, FirstName = "Betty", Surname = "Boo", Salary = 20000, Department = "Entertainment"}
    };

    public List<Employee> GetAll()
    {
      return _employees;
    }

    public Employee GetSingle(int recordId)
    {
      return _employees.FirstOrDefault(r => r.Pkid.Equals(recordId));
    }

  }
}
