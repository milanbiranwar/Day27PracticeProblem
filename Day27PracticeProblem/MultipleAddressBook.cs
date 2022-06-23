using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27FileIO
{
    public class MultipleAddressBook
    {

        Dictionary<string, List<Contact>> MultiDict = new Dictionary<string, List<Contact>>();
        public void DictionaryContacts()
        {
            AddressBook ObjAdd = new AddressBook();
            Console.WriteLine("How many ADDRESSBOOK, You want to create ");
            int BookNum = Convert.ToInt32(Console.ReadLine());
            
            
                for (int i = 1; i <= BookNum; i++)
                {
                    Console.WriteLine("What name you want to give to address book");
                    string Bookname = Console.ReadLine();

                    MultiDict.Add(Bookname, ObjAdd.ContactBook);
                }
                
            
            
            Console.WriteLine("AddressBook added successfully");
        }
        AddressBook ObjAdd = new AddressBook();
        public void AddMultipleContact1()
        {
            Console.WriteLine("Enter the Number of Persons to add");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                ObjAdd.AddNewContact();
            }
        }


        public static List<Contact> People = new List<Contact>();
        public void AddNewContact()
        {
            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            People.Add(person);
        }
        public static void PrintAddressBook()
        {
            foreach (Contact contact in People)
            {


                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                Console.WriteLine("Address 1: " + contact.Address);
                Console.WriteLine("Address 2: " + contact.ZipCode);
                Console.WriteLine("-------------------------------");
            }

        }
        public void EditContact(string firstName)
        {
            foreach (Contact person in People)
            {
                if (person.FirstName == firstName)
                {
                    Console.Write("Enter First Name: ");
                    person.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    person.LastName = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    person.Address = Console.ReadLine();

                    Console.Write("Enter City: ");
                    person.City = Console.ReadLine();

                    Console.Write("Enter ZipCode: ");
                    person.ZipCode = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    person.PhoneNumber = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    person.Email = Console.ReadLine();


                }
            }
        }
        public void DeleteContact(string firstName1)
        {

            foreach (Contact person in People)
            {
                if (person.FirstName == firstName1)
                {
                    People.Remove(person);
                    break;

                }

            }
            Console.WriteLine("Your contact is Deleted");
        }
    }
}
    

