using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Person
    {
        private string name;
        private int phoneNumber;

        public Person(string name, int phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public string Name {  get => name; set => name = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

    }
}
