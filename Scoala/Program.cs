using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class Program
    {
        public static void Main()
        {

            var oAdresa = new Address() { Town = "Bucale", StreetAddress1 = "MihaiEminescu nr. 21", StreetAddress2 = "Etaj 7, room 704" };
            var studentul = new Student("Costin", 27, oAdresa, Sex.Male, Curs.Intermediari, 1);
            var curs = new List<Curs>(2);

            Console.WriteLine("population: "/*Student= " + Student.Pupulation + " ; Teacher = " + Teacher.Pupulation + " ; Total = "*/ + Person.Pupulation);
            var studenta = new Student("Cristina Saitoc", 32, new Address() { Town = "Bucale", StreetAddress1 = "MihaiEminescu nr. 21", StreetAddress2 = "Etaj 7, room 704" }, Sex.Female, Curs.Intermediari, 2);
            var teacher = new Teacher("profesor : Andrei", 33, oAdresa, Sex.Male, 10, curs);
            studentul.Age++;
            studenta.Address.Town = "Bucuresti";
            var myNotebook = new List<Person>();
            myNotebook.Add(studenta);
            myNotebook.Add(studentul);
            myNotebook.Add(teacher);
            myNotebook.Add(new Beggar("Cersetorul", 13, new Address(), Sex.Male));
            List<Action> Pasi = new List<Action>();
            foreach (var notebookEntry in myNotebook)
            {
                Console.WriteLine(notebookEntry);
                Console.Write("let's try special actions - ");
                notebookEntry.SpecialAction();
                Pasi.Add(notebookEntry.SpecialAction);
                if (notebookEntry is Teacher)
                {
                    Console.Write("this one is a teacher do more ");
                    ((Teacher)notebookEntry).Teach();
                }
                Student acesta = notebookEntry as Student;
                if (acesta != null)
                {
                    Console.Write("this one is a student do more ");
                    acesta.Study();
                }
            }
            ExAction obiect = new ExAction(Pasi);
            obiect.RunExample();
            //TO DO: Create a teacher and add it to agenda - Marian


            Console.WriteLine(new Nationality("Romanian"));


            Console.ReadLine();
        }
    }
}
//TO DO: create a class Animal and add a field List<Animal> Pet in class Person - Adi - done, bravo
//Create Class dog that inherits Animal and add a dog in the field Pet of object studenta - studenta (dupa ce comite Adi)
//Create a new student and give him 2 pets - Bogdan
//TO DO: Do something - Costin done, bravo
//TO DO: read all code, understand and create a student