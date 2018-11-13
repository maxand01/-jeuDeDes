using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jeu2Des
{
    [Serializable]
    [DataContract]
    public class Entree: IComparable<Entree>
    {
        #region "Propriétés et accesseurs"
        [DataMember]
        public string Nom { get; set; }
        [DataMember]
        public int Score { get; set; }
        #endregion
        #region "Constructeurs"
        //Constructeur requis par la sérialisation XML
        public Entree()
        {

        }
        public Entree(string nom, int score)
        {
            this.Nom = nom;
            this.Score = score;
        }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        public override string ToString()
        {
            return $"Le joueur: {Nom} a un score de : {Score} ";
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"
        public int CompareTo(Entree other)
        {
            if (other == null)
            {
                return -1;
            }
            else
            {
                if(this.Score.CompareTo(other.Score) == 0)
                {
                    return this.Nom.CompareTo(other.Nom);

                }
                else
                {
                    return this.Score.CompareTo(other.Score) * -1;

                }
            }
        }
        #endregion

    }
}
