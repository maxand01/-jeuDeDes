using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Jeu2Des
{

    public abstract class Classement
    {
        #region "Propriétés et accesseurs"
        public List<Entree> Entrees { get; protected set; }
        #endregion
        #region "Constructeurs"
        public Classement()
        {
            Entrees = new List<Entree>();
        }
        #endregion
        #region "Methodes"
        public void AjouterEntree(Entree entree)
        {
            Entrees.Add(entree);
        }



        public void TopN()
        {
            Entrees.Sort();

            foreach (var entree in Entrees)
            {
                Console.WriteLine(entree.ToString());
            }
        }

        abstract public void Save();

        abstract public void Load();
        #endregion
        #region "Methodes héritées et substituées"
        public override string ToString()
        {
            return $" toString de la classe classement {Entrees}";
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
