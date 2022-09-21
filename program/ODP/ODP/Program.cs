using System;
using System.Collections.Generic;
using System.Linq;

namespace ODP
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringInput1, StringInput2;
            int age, count;
            var candidates = new List<Candidate>();
            var parties = new List<Party>();
            Console.WriteLine("zadejte počet kandidátů v obvodu: ");
            while (!int.TryParse(Console.ReadLine(), out count) || (count < 6 || count > 20))
                Console.WriteLine("Zadaný počet není platný, opakujte");
            for (int i = 0; true; i++)
            {
                Console.WriteLine("Název strany: ");
                StringInput1 = Console.ReadLine();
                Console.WriteLine("Jméno předsedy strany: ");
                StringInput2 = Console.ReadLine();
                parties.Add(new Party(StringInput1, StringInput2));

                for (int j = 0; j < count; j++)
                {
                    Console.WriteLine("jmeno kandidata:");
                    StringInput1 = Console.ReadLine();
                    Console.WriteLine("vek kandidata:");
                    while (!int.TryParse(Console.ReadLine(), out age) || (age < 18 || age > 120))
                        Console.WriteLine("Zdaný věk není platný, opakujte");
                    candidates.Add(new Candidate(StringInput1, age, parties[i]));
                }
                Console.WriteLine("název strany: " + parties[i].name);
                Console.WriteLine("Pokud chceete název strany upravit stiskněte y");
                if (Console.ReadLine().ToLower() == "y")
                    parties[i].name = Console.ReadLine();
                Console.WriteLine("Pokud nechcete zadat další kandidátku stiněte n");
                if (Console.ReadLine().ToLower() == "n")
                    break;
            }
            Console.WriteLine("Výčet kanditátu podle navrhujícíh stran");
            foreach (var item in candidates.OrderBy(x => x.party.name))
                Console.WriteLine(item);
        }
    }
    class Party
    {
        public string name;
        public string president;
        public Party(string name, string president)
        {
            this.name = name;
            this.president = president;
        }
    }
    class Candidate
    {
        private string name;
        private int age;
        public Party party;
        public Candidate(string name, int age, Party party)
        {
            this.name = name;
            this.age = age;
            this.party = party;
        }
        public override string ToString()
        {
            return "Kandidát: " + name + " věk: " + age + " navrhující strana: " + party.name + "(předseda: " + party.president + ")";
        }
    }
}

