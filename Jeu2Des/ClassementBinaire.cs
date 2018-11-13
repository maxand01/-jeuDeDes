using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Jeu2Des
{
    class ClassementBinaire : Classement
    {
        public override void Save()
        {
            Stream fichier = File.Create("sav.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fichier, Entrees);
            fichier.Close();
        }

        public override void Load()
        {
            if (File.Exists("sav.txt"))
            {
                Stream fichier = File.OpenRead("sav.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                Object obj = serializer.Deserialize(fichier);

                //L'objet récupéré doit être casté dans sa classe pour qu'on puisse accéder à ces méthodes
                Console.WriteLine(obj);
                Entrees = (List<Entree>)obj;
                //e.ToString();
                fichier.Close();
            }
        }        
    }
}
