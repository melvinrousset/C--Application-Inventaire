using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ManageArticle : Article
    {

        public ManageArticle(int num, String nom, int prix, int stock)
        : base(num, nom, prix, stock)
        {



        }

        UnkownNumException unkownnum = new UnkownNumException("readonly");
        public void deleteArticle(int numero , List<Article> article)
        {
            unkownnum.numException(article, numero);

            for (int i = 0; i < article.Count; i++)
            {

                if (article[i].getNum() == numero)
                {

                    Console.WriteLine();
                    Console.WriteLine("L'article {0} a bien étais supprimé\n", numero);

                    article.RemoveAt(i);
                    break;

                }


            }

        }


      public   void addArticle(List<Article> article ,int num , String nom, int prix , int stock )
        {

            article.Add(new Article(num, nom, prix, stock));

        }

      

        public void showArticle(List<Article> article , int num)
        {

            unkownnum.numException(article, num);

            Console.WriteLine(article[num].ToString());          

        }

        public void showAllArticle(List<Article> article, int num)
        {
            for (int i = 0; i < article.Count; i++)
            {

                showArticle(article, num);

            }


        }

        public void modifArticle(int numero , List<Article> article , int availableNum)
        {
            int temponnum;

            String temponnom;

            int temponprix;

            int temponstock;

            int choix;




            Console.WriteLine("Que souhaitez vous faire \n");

            Console.WriteLine("1- modifier le num \n");

            Console.WriteLine("2- modifier le nom \n");

            Console.WriteLine("3- modifier le prix \n");

            Console.WriteLine("4- modifier le stock \n");

            choix = Convert.ToInt32(Console.ReadLine());

            unkownnum.numException(article, choix);

            switch (choix)

            {

                case 1:

                    Console.WriteLine("Saisissez le nouveaux num : \n");

                    temponnum = Convert.ToInt32(Console.ReadLine());


                    article[numero].changeNum(temponnum);

                    break;

                case 2:

                    Console.WriteLine("Saisissez le nouveaux nom : \n");

                    temponnom = Console.ReadLine();


                    article[numero].changeNom(temponnom);

                    break;

                case 3:

                    Console.WriteLine("Saisissez le nouveaux prix : \n");

                    temponprix = Convert.ToInt32(Console.ReadLine());


                    article[numero].changePrix(temponprix);

                    break;

                case 4:



                    Console.WriteLine("Saisissez le nouveaux stock : \n");

                    temponstock = Convert.ToInt32(Console.ReadLine());




                    for (int i = article[numero].getStock(); i < temponstock; i++)
                    {

                        addArticle(article , availableNum, article[numero].getNom(), article[numero].getPrix(), temponstock);

                    }

                    for(int i = 0; i < article.Count; i++)
                    {
                        if (article[i].getNom() == article[numero].getNom())
                            
                            {

                            article[i].changeStock(temponstock);

                        }

                    }



                    break;



            }


        }

      


    }
}
