using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace adatgen
{
    internal class Program
    {

        static string fileGen()
        {
            Console.WriteLine("Filename: ");
            string filename = Console.ReadLine();
            string path = Path.Combine(Environment.CurrentDirectory, filename + ".txt");
            return path;
        }

        static int dataType()
        {
            Console.WriteLine("Adat tipusa:\n\t1. nev;pont1;pont2;pont3;hely;nem\n\t2. nev1;pont1;nev2;pont2;nev3;pont3");
            int choice = Convert.ToInt32(Console.ReadLine());
            int datatype = 0;
            if (choice == 1)
            {
                datatype = 1;
            }
            else if (choice == 2)
            {
                datatype = 2;
            }
            else
            {
                Console.WriteLine("Error: Wrong Input");
            }
            return datatype;
        }


        static void writeFile(int lines, string path, int datatype)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                Random rnd = new Random();
                List<string> name = new List<string>() { "Anna", "Béla", "Cecília", "Dániel", "Emese", "Ferenc", "Gábor", "Hanna", "István", "Judit", "Katalin", "László", "Márta", "Nóra", "Orsolya", "Péter", "Róbert", "Sára", "Tamás", "Veronika", "Zoltán", "Ádám", "Éva", "Ödön", "Ünige" };
                List<string> city = new List<string> { "Budapest", "Debrecen", "Szeged", "Miskolc", "Pécs", "Győr", "Nyíregyháza", "Kecskemét", "Székesfehérvár", "Szombathely", "Dunaújváros", "Eger", "Tatabánya", "Veszprém", "Békéscsaba", "Zalaegerszeg", "Sopron", "Siófok", "Nagykanizsa", "Salgótarján", "Ózd", "Mosonmagyaróvár", "Baja", "Kaposvár", "Szolnok" };
                

                if (datatype == 1)
                {
                    for (int i = 0; i < lines; i++)
                    {
                        string gender = rnd.Next(2) == 0 ? "Férfi" : "Nő";
                        string randomName = name[rnd.Next(name.Count)];
                        string randomCity = city[rnd.Next(name.Count)];
                        sw.WriteLine(randomName + ";" + rnd.Next(10) + ";" + rnd.Next(10) + ";" + rnd.Next(10) + ";" + randomCity + ";" + gender);
                    
                    }
                    
                }
                else
                {
                    for (int i = 0; i < lines; i++)
                    {
                        string gender = rnd.Next(2) == 0 ? "Férfi" : "Nő";
                        string randomName = name[rnd.Next(name.Count)];
                        string randomCity = city[rnd.Next(city.Count)];
                        sw.WriteLine(randomName + ";" + rnd.Next(10) + ";" + randomName + ";" + rnd.Next(10) + ";" + randomName + ";" + rnd.Next(10));

                    }

                }
            }        
        }


        static void Main(string[] args)
        {
            string path = fileGen();
            int datatype = dataType();
            Console.WriteLine("Sorok: ");
            int lines = Convert.ToInt32(Console.ReadLine());
            writeFile(lines, path, datatype);
        }
    }
}
