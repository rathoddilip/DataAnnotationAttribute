using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataAnnotation
{
    public class NewAttribute : Attribute
    {
        //private field
        private string title;
        private string description;
        /// <summary>
        /// Paramertised constructor
        /// </summary>
        /// <param name="titleField"></param>
        /// <param name="descriptionField"></param>
        public NewAttribute (string titleField, string descriptionField)
        {
            title = titleField;
            description = descriptionField;
        }
        /// <summary>
        /// method to show the fields of the NewAttribute
        ///  using reflection
        /// </summary>
        /// <param name="classType"></param>
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);
            //array to store all methods of a class to which the attribute may be applied
            MethodInfo[] methods = classType.GetMethods();
            //to read all methods
            for(int i=0; i<methods.GetLength(0);i++)
            {
                //creating object array to recieve method attributes 
                //returned by the GetCustomAttribute Method
                object[] attributesArray = methods[i].GetCustomAttributes(true);
                // read all attributes of the method
                foreach(var item in attributesArray)
                {
                    if (item is NewAttribute)
                    {
                        //Display the fields of the NewAttribute
                        NewAttribute newAttributeObject = (NewAttribute)item;
                        Console.WriteLine("{0} - {1} , {2} ", methods[i].Name, newAttributeObject.title, newAttributeObject.description);
                    }
                }
            }
         }
    }
}
