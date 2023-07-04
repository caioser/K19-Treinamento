//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace K19_Treinamento.orientacao_a_objetos
{
    class TestaCliente
    {
        public static void Main()
        {
            Cliente c1 = new Cliente();
            c1.nome = "Caio Sergio";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Thaiana Cristina";
            c2.codigo = 2;

            Console.WriteLine($"{c1.nome}\n{c1.codigo}");
            Console.WriteLine($"{c2.nome}\n{c2.codigo}");
        }
    }
}