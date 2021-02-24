using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAnnotation
{
   public class Employee
    {
        int id;
        string name;

        public Employee(int empid, string empname)
        {
            id = empid;
            name = empname;
        }
        [NewAttribute("Accessor","Gives value of employee Id")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of employee Name")]
        public string getName()
        {
            return name;
        }
    }
}
