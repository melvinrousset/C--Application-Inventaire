using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        private int choix;

        readonly Find find = new Find(6, "test", 20, 1);
        readonly Verify verify = new Verify(6, "test", 20, 1);

        readonly ManageArticle manage = new ManageArticle(6, "test", 20, 1);

        private String nom;

        private int num;

        private int prix;

        private int stock;


        public void menu(List<Article> article)
        {

            while (true)
            {



                Console.WriteLine("1- Rechercher un article par référence\n");

                Console.WriteLine("2- Ajouter un article au stock en vérifiant l’unicité de la référence\n");

                Console.WriteLine("3- Supprimer un article par référence\n");

                Console.WriteLine("4- Modifier un article par référence\n");

                Console.WriteLine("5- Rechercher un article par nom\n");

                Console.WriteLine("6- Rechercher un article par intervalle de prix de vente\n");

                Console.WriteLine("7- Afficher tous les articles\n");

                Console.WriteLine("8- Quitter\n");

                choix = Convert.ToInt32(Console.ReadLine());


                switch (choix)


                {

                    case 1:


                        Console.WriteLine("Entre son numéro de référence\n");



                        find.findArticle(Convert.ToInt32(Console.ReadLine()), article);

                        break;


                    case 2:

                        Console.WriteLine();

                        Console.WriteLine("Entrez le numero\n");



                        num = Convert.ToInt32(Console.ReadLine());

                        verify.checkUni(num, article);



                        Console.WriteLine("Entrez son nom\n");



                        nom = Console.ReadLine();



                        Console.WriteLine("Entrez le prix de vente\n");



                        prix = Convert.ToInt32(Console.ReadLine());



                        stock = verify.nbStock(nom, article);


                        manage.addArticle(article, num, nom, prix, stock);
                        manage.showArticle(article, find.findArticle(num, article));




                        Console.WriteLine(article[article.Count - 1].ToString());

                        break;


                    case 3:

                        Console.WriteLine();

                        Console.WriteLine("Entrez le numeros de l'article a supprimé.\n");



                        manage.deleteArticle(Convert.ToInt32(Console.ReadLine()), article);

                        break;

                    case 4:

                        int numModif;
                        Console.WriteLine();

                        Console.WriteLine("Entrez le numeros de l'article a modifié.\n");



                        numModif = find.findArticle(Convert.ToInt32(Console.ReadLine()), article);


                        manage.modifArticle(numModif, article, verify.availableNum(article));

                        break;


                    case 5:

                        Console.WriteLine("Entre son nom\n");



                        find.findArticleString(Console.ReadLine(), article);
                        break;


                    case 6:
                        find.findArticleWithPrice(article);

                        break;


                    case 7:

                        for (int i = 0; i < article.Count; i++)
                        {

                            Console.WriteLine(article[i].ToString());



                        }
                        break;


                    case 8:


                        Environment.Exit(0);

                        break;






                }

            }





        }
    }
}
