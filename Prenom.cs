using System;
namespace ConsoleApp1
{
    class Prenom
    {
        
        public bool r = true;

        public Prenom()
        {


        }

        DateTime depart =  DateTime.Now;
        DateTime arriver =  DateTime.Now;

        public void votreAge()
        {



            do {

                try

                {
                    Console.WriteLine("entrez un entier");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Voici votre age " + age);

                }



                catch (System.FormatException)
                {
                    Console.Error.WriteLine("veuillez rentrer un entier =(");
                    r = false;

                }
            } while (r == false);

            Convert.ToInt32(Console.ReadLine());


        }

        public void date()
        {

            try
            {
                Console.WriteLine("entrez la date de départ ex : 15");
                int date = Convert.ToInt32(Console.ReadLine());
                this.depart.AddDays(18);


                Console.WriteLine("entrez la date d'arrivé ex : 15");

                 date = Convert.ToInt32(Console.ReadLine());

                this.arriver.AddDays(15);
                verifDate(depart, arriver);


                Console.WriteLine("vous partirez le {0} et arriverez le {1}", depart, arriver);



            }


            catch (Exception)
            {

                Console.WriteLine("pas dde chance");

            }





        }

        public static void verifDate(DateTime depart , DateTime arriver)
        {


            if (depart.CompareTo(depart) > 0)
            {



                throw new Exception("la valeur est pas bonne");

            }
            



        }











    }



    
        

}
        


  
