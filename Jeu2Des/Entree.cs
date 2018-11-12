using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class Entree
    {
        #region "Propriétés et accesseurs"
        public string Nom { get; set; }
        public int Score { get; set; }
        #endregion
        #region "Constructeurs"
        public Entree(string nom, int score)
        {
            this.Nom = nom;
            this.Score = score;
        }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
