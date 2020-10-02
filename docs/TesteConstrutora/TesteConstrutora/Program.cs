using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando...");
            CrefeObra pedreiro = new CrefeObra();

            IBuilder casa1 = new Casa();
            IBuilder ap1 = new Apartamento();

            pedreiro.Construct(casa1);
            casa1.GetImovel().Show();


            pedreiro.Construct(ap1);
            ap1.GetImovel().Show();

            IBuilder casa2 = casa1.ShallowCopy();
            casa2.GetImovel().Show();
            

            //Casa casa2 = casa1.ShallowCopy();
            
            //pedreiro.Construct(casa2);
            //casa2.GetImovel().Show();
            



            Console.ReadKey();

        }
    }
}
