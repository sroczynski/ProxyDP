using DesignPatterns.Proxy;
using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Strategy
            VideoGame snes = new VideoGame(new InserirJogoSuperNintendo());
            snes.InserirJogo();

            Console.WriteLine();

            VideoGame play = new VideoGame(new InserirJogoPlaystation());
            play.InserirJogo();


            Console.ReadKey();

            Console.Clear();

            //Proxy
            PadraoProxy();

            Console.ReadKey();


           
        }
        
        public static void PadraoProxy()
        {
            _Imagem imagem1 = new ImagemProxy("Feevale_Foto1");
            _Imagem imagem2 = new ImagemProxy("Feevale_Foto2");

            imagem1.MostrarImagem(); // é necessário o carregamento
            imagem1.MostrarImagem(); // não é necessário o carregamento

            imagem2.MostrarImagem(); // é necessário o carregamento
            imagem2.MostrarImagem(); // não é necessário o carregamento
            imagem2.MostrarImagem(); // não é necessário o carregamento

            imagem1.MostrarImagem(); // não é necessário o carregamento
        }
    }
}
