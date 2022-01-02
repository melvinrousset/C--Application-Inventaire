using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UnkownNumException : Exception
    {
        public UnkownNumException(String error)
            :base("Le numéro n'est pas dans la base de donnée")
        {


        }

        public void numException(List<Article> article, int num)
        {



            
            if (article[num].getNum() < 0)
            {

                throw new UnkownNumException("erreur show Article");
            }
        }
    

}
}
