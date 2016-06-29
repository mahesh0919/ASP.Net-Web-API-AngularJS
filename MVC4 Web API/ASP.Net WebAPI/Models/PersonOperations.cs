using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4_WebAPI.Models
{
    public class PersonOperations
    {
        public List<Person> _persons = new List<Person>();
        public PersonOperations()
        {
            // Adding some static data
            _persons.Add(new Person() { PersonID = 1, Address = "Hyderabad", Gender = "M", FirstName = "Mahesh", LastName = "Pendker" });
            _persons.Add(new Person() { PersonID = 2, Address = "Warangal", Gender = "M", FirstName = "Rakesh", LastName = "Pendker" });
            _persons.Add(new Person() { PersonID = 3, Address = "Mahabubabad", Gender = "M", FirstName = "Vikram", LastName = "Voma" });
            _persons.Add(new Person() { PersonID = 4, Address = "Hyderabad", Gender = "M", FirstName = "Bhavish", LastName = "Mahankali" });
            _persons.Add(new Person() { PersonID = 5, Address = "Hyderabad", Gender = "M", FirstName = "Sai", LastName = "Pullakandam" });
            _persons.Add(new Person() { PersonID = 6, Address = "Hyderabad", Gender = "M", FirstName = "Dhana", LastName = "Vemula" });
        }

        /// <summary>
        /// Get All Person Details
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAllPerson()
        {
            return _persons;
        }

        /// <summary>
        /// Get Person details by ID
        /// </summary>
        /// <param name="PersonID"></param>
        /// <returns></returns>
        public Person GetPersonbyID(int PersonID)
        {
             Person person = (from p in _persons
                                        where p.PersonID == PersonID
                                        select p).Single<Person>();
             return person;
        }

        /// <summary>
        /// Update Person Details
        /// </summary>
        /// <param name="PersonID"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public void UpdatePerson(int PersonID, Person person)
        {
            Person p1 = (from p in _persons
                             where p.PersonID == PersonID
                             select p).Single<Person>();

            p1.Address = person.Address;
            p1.FirstName = person.FirstName;
            p1.Gender = person.Gender;
            p1.LastName = person.LastName;

        }

        /// <summary>
        /// Add Person details
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }

        /// <summary>
        /// Delete a person
        /// </summary>
        /// <param name="PersonID"></param>
        public void DeletePerson(int PersonID)
        {
             Person person = (from p in _persons
                                        where p.PersonID == PersonID
                                        select p).Single<Person>();
             
            _persons.Remove(person);
        }


    }
}