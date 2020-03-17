using System;
using System.Collections.Generic;

namespace VirusSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            // add items to the list one at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");
            names.Insert(0, "Shebola");

            // remove items from the list one at a time
            names.Remove("Stupidity");
            names.RemoveAt(3);

            // add multiple items
            var people = new List<string> { "Nathan", "Martin", "Randy's Kid" };
            names.AddRange(people);
            // or: names.AddRange(new List<string> { "Nathan", "Martin", "Randy's Kid" };

            // remove multiple items
            names.RemoveRange(names.Count - 3, 3); // (indexToStartAt, howManyToRemove)

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //-------------------------------------------------------------------------------
            // Dictionaries
            //-------------------------------------------------------------------------------

            var symptoms = new Dictionary<string, string>();

            symptoms.Add("COVID-19", "Dry cough, fever, respiratory problems, cancels everything");
            symptoms.Add("Ebola", "Fever, headache, muscle pain and chills");
            symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");

            // get a single thing
            var covidSymptoms = symptoms["COVID-19"];

            // remove single item
            symptoms.Remove("Ebola");

            // collection initializer
            var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };

            foreach (var (virus, symptom) in symptoms)
            {
                Console.WriteLine($"The {virus} virus has the following symptoms: {symptom}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                {
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                }
                else
                {
                    Console.WriteLine($"The {name} virus is unknown...");
                }
            }


            //-------------------------------------------------------------------------------
            // Queues
            //-------------------------------------------------------------------------------

            var diseasesToCure = new Queue<string>();

            diseasesToCure.Enqueue("SARS");
            diseasesToCure.Enqueue("COVID-19");

            var thingToCure = diseasesToCure.Dequeue();
            var nextThingToCure = diseasesToCure.Dequeue();


            //-------------------------------------------------------------------------------
            // Hashset
            //-------------------------------------------------------------------------------

            var vectors = new HashSet<string>();

            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");
            vectors.Add("Bloodborne");

            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry cough");
            covid19.Symptoms.Add("Cancels everything except work");
            covid19.NumberOfDeathsWorldwide = 7158;

            var spanishflu = new Virus("Spanish flu", 11);
            spanishflu.Symptoms.Add("Fever");
            spanishflu.Symptoms.Add("Dry cough");
            spanishflu.NumberOfDeathsWorldwide = 50000000;

            var rabies = new Virus("Rabies", 11);
            rabies.Symptoms.Add("Fever");
            rabies.Symptoms.Add("Excess salivation");
            rabies.NumberOfDeathsWorldwide = 200000;

            var viruses = new List<Virus> { covid19, spanishflu, rabies };

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} virus has an incubation period of {virus.IncubationsDays} and has killed {virus.NumberOfDeathsWorldwide} wombats.");
                Console.WriteLine($"It has the following symptoms: {string.Join(". ", virus.Symptoms)}");
            }
        }
    }
}
