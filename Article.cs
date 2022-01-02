using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Article
    {
        private  int num;

        private  String nom;

        private int prix;

        private int stock;
       

        public Article(int num , String nom, int prix , int stock)
        {

            this.num = num;

            this.nom = nom;

            this.prix = prix;

            this.stock = stock;


        }

        public Article(int num)
        {
            this.num = num;

        }


        public override string ToString()
        {
            return "\nle numéro de référence : \n" + this.num + "\n le nom : \n" + this.nom + "\n le prix :\n " + this.prix + "\n le stock : \n" + this.stock; 
        }


        public int getNum()
        {

            return this.num;

        }

        public String getNom()
        {
            return this.nom;

        }

        public int getPrix()
        {
            return this.prix;

        }

        public int getStock()
        {
            return this.stock;

        }

        public void changeNom(String nom)
        {
            this.nom = nom;

        }
        public void changeNum(int num)
        {
            this.num = num;

        }


        public void changePrix(int prix)
        {
            this.prix = prix;

        }


        public void changeStock(int stock)
        {
            this.stock = stock;

        }




    }
}
