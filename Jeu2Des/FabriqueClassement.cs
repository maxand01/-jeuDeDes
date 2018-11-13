using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu2Des
{
    public class FabriqueClassement
    {
        private static FabriqueClassement instance = new FabriqueClassement();
        private FabriqueClassement()
        {

        }
        public static FabriqueClassement GetFabriqueClassementInstance()
        {
            return instance;
        }

        public Classement GetClassement(string typeClassement)
        {
            if (typeClassement == "Binaire")
            {
                return new ClassementBinaire();
            }
            else if (typeClassement == "Xml")
            {
                return new ClassementXml();
            }
            else if (typeClassement == "Json")
            {
                return new ClassementJson();
            }
            else
                throw new Exception("Impossible de créer un " + typeClassement);
        }
    }
}
