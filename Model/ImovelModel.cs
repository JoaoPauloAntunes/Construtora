using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ImovelModel
    {
        //Lista para armazenamento das partes da casa
        private List<string> partesDaCasa;
        
        public ImovelModel()
        {
            partesDaCasa = new List<string>();
        }
        
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
