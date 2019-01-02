using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstname;
            int year = 0, age = 0;

            Console.WriteLine("entrer le nom");
            name = Console.ReadLine();
            Console.WriteLine("Entrer votre prenom");
            firstname = Console.ReadLine();
            Console.WriteLine("Entrer l'age de naissance");
            int.TryParse(Console.ReadLine(), out year);
            age = DateTime.Now.Year - year;
            Console.WriteLine("nom: " + name + "\n prenom: " + firstname + "\n age: " + age);
        }
    }
}
