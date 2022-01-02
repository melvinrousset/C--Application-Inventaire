using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Verify : Article
    {

        public Verify(int num, String nom, int prix, int stock)
         : base(num, nom, prix, stock)
        {



        }

        public int nbStock(String nom , List<Article> article)
        {
            int nbstock = 1;

            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].getNom() == nom)
                {
                    nbstock += 1;



                }

            }
            return nbstock;
        }
           

           public  void checkUni(int numero , List<Article> article)
            {

                for (int i = 0; i < article.Count; i++)
                {

                    if (article[i].getNum() == numero)
                    {
                        Console.Error.Write("Erreur au niveaux du numéro, Reesayer\n");



                    }

                }

            }



           public  int availableNum(List<Article> article)
            {
                int num = 0;


                for (int i = 0; num < article.Count; num++)
                {

                    if (article[i].getNum() != num)
                    {
                        return num;

                    }

                    else
                    {

                        num += 1;
                    }

                }

                return num + 1;
            }


        

    }
}
