using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Jeu2Des
{
    public class ClassementJson : Classement
    {
        public override void Load()
        {
            if (File.Exists("sav.json"))
            {
                Stream fichier = File.OpenRead("sav.json");
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Entree>));
                Entrees = (List<Entree>)serializer.ReadObject(fichier);
                foreach (var p in Entrees)
                {
                    Console.WriteLine(p);
                }
                fichier.Close();
            }
        }

        public override void Save()
        {
            Entrees.Add(new Entree("Nom1", 50));
            Entrees.Add(new Entree("Nom2", 25));

            Stream fichier = File.Create("sav.json");
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(Entrees.GetType());
            serializer.WriteObject(fichier, Entrees);
            fichier.Close();
        }
    }
}
