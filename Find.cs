using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Find : Article
    {

        public Find(int num, String nom, int prix, int stock)
            : base(num,nom,prix,stock)
        {



        }
        UnkownNameException unkownname = new UnkownNameException("readonly");

        UnkownNumException unkown = new UnkownNumException("readonly");

        ManageArticle manageView = new ManageArticle(6, "fef", 20, 1);


       public  int findArticleString(String nom , List<Article> article)
        {
            try
            {
                unkownname.nameException(article, nom);


            }

            catch (UnkownNameException)
            {
                

            }
            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].getNom() == nom)
                {
                    Console.WriteLine();

                    Console.WriteLine("Voici L'article que vous rechercher \n " + article[i].ToString());

                    Console.WriteLine();

                    return i;

                }

            }
            return 0;

           

        }

      public   int findArticle(int numero , List<Article> article)
        {

            unkown.numException(article, numero);
            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].getNum() == numero)
                {
                    Console.WriteLine();

                    Console.WriteLine("Voici L'article que vous rechercher \n " + article[i].ToString());

                    Console.WriteLine();

                    return i;

                }

            }

            return 0;
            
        }


        public void findArticleWithPrice(List<Article> article)
        {
            int min;
            int max;


                  Console.WriteLine("Entrez le prix minimum");
            min = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Entrez le prix maximum");
            max = Convert.ToInt32(Console.ReadLine());



            for(int i = 0; i < article.Count; i++)
            {

                if(article[i].getPrix() >= min && article[i].getPrix() <= max)
                {
                    manageView.showArticle(article, i);

                }

            }


        }
    }
}
