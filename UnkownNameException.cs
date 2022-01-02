using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UnkownNameException : Exception
    {
        public UnkownNameException(string error)
            : base("Le nom n'est pas dans la base de donnée")
        {


        }

        public int nameException(List<Article> article, String nom)
        {
            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].getNom() == nom)
                {
                    return 1;

                }

            }
            throw new UnkownNameException("erreur Find article String");

        }
    }
}
