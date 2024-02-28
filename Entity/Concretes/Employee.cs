using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes;

public class Employee : User
{
    public string Position { get; set; }

    public Employee()
    {

    }

    public Employee(int id, int employeeId, string position)
    {
        Id = id;
        Position = position;
    }
}
