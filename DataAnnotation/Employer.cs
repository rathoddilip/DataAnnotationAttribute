using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAnnotation
{
   public class Employer
    {
        int id;
        string name;
        /// <summary>
        /// parameterised constructor
        /// </summary>
        /// <param name="employerid"></param>
        /// <param name="employername"></param>
        public Employer(int employerid, string employername)
        {
            id = employerid;
            name = employername;
        }
        [NewAttribute("Accessor", "Gives value of employer Name")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Gives value of employer Name")]
        public string getName()
        {
            return name;
        }
    }
}
