using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class InserirJogoPlaystation : _InserirJogo
    {
        public void Inserir()
        {
            Console.WriteLine("Pleysteixo:::: O (CD)");
        }
    }

    public class InserirJogoSuperNintendo : _InserirJogo
    {
        public void Inserir()
        {
            Console.WriteLine("Super Ultra Mother of Games Nintendo::::  | T T | (Cartucho)");
        }
    }
}
