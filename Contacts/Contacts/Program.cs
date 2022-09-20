using System;
using System.Collections.Generic;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<string>();


            contacts.Add("Aa: Aaron:А@A.A");

            Console.WriteLine(OptimizeContacts(contacts));
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var contact in contacts)
            {
                var name = contact.Substring(0, 2).Replace(" ", "");
                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = new List<string>();
                    dictionary[name].Add(contact);
                }
                else dictionary[name].Add(contact);
            }
            return dictionary;
        }
    }
}
