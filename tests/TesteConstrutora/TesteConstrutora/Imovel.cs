using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutora
{
    public class Imovel
    {
        //Lista para armazenamento das partes da casa
        private List<string> partesDaCasa;
        public Imovel()
        {
            partesDaCasa = new List<string>();
        }
        //Adiciona no final da lista de partes da casa;
        public void Add(string novaParte)
        {
            partesDaCasa.Add(novaParte);
        }
        public void Show()
        {
            Console.WriteLine("\nA casa atual tem: ");
            foreach (string parteAtual in partesDaCasa)
                Console.WriteLine("\t" + parteAtual);
        }
    }
}
