using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataHelper
    {
        public ArrayList people = new ArrayList();

        public ArrayList GetPeople()
        {
            return people;
        }

        public void AddUser(string name, int phoneNumber)
        {
            Person newPerson = new Person(name, phoneNumber);
            people.Add(newPerson);
        }

        public void EditUser(string name, int phoneNumber, string newName, int newPhoneNumber)
        {
            foreach (Person person in people)
            {
                string personName = person.Name;
                int personPhoneNumber = person.PhoneNumber;

                if (personName == name &&
                    personPhoneNumber == phoneNumber)
                {
                    person.Name = newName;
                    person.PhoneNumber = newPhoneNumber;
                }
            }
        }

        public Person GetUser(string name, int phoneNumber)
        {
            foreach (Person person in people)
            {
                string personName = person.Name;
                int personPhoneNumber = person.PhoneNumber;

                if (personName == name &&
                    personPhoneNumber == phoneNumber)
                {
                    return person;
                }
            }

            return null;
        }

        public ArrayList GetUsers(string name, int phoneNumber)
        {
            ArrayList newPeople = new ArrayList();

            foreach (Person person in people)
            {
                string personName = person.Name;
                int personPhoneNumber = person.PhoneNumber;

                if (personName == name &&
                    personPhoneNumber == phoneNumber)
                {
                    newPeople.Add(person);
                }
            }

            return newPeople;
        }

        public ArrayList DeleteUser(string name, int phoneNumber)
        {
            int index = 0;
            foreach (Person person in people)
            {
                string personName = person.Name;
                int personPhoneNumber = person.PhoneNumber;
                
                if (personName == name &&
                    personPhoneNumber == phoneNumber)
                {
                    people.RemoveAt(index);
                    return people;
                }

                index++;
            }

            return people;
        }
    }
}
