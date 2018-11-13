using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{
    class ClassementXml : Classement
    {
        public override void Load()
        {
            if (File.Exists("sav.xml"))
            {
                Stream fichier = File.OpenRead("sav.xml");
                XmlSerializer serializer = new XmlSerializer(Entrees.GetType());
                Object obj = serializer.Deserialize(fichier);
                Console.WriteLine("Objet récupéré par désérialisation Xml " + obj);
                Entrees = (List<Entree>)obj;
                fichier.Close();
            }
        }

        public override void Save()
        {
            Stream fichier = File.Create("sav.xml");
            XmlSerializer serializer = new XmlSerializer(Entrees.GetType());
            serializer.Serialize(fichier, Entrees);
            fichier.Close();
        }
    }
}
