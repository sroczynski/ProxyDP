using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ImagemReal : _Imagem
    {
        private String nomeDoArquivo;

        public ImagemReal(String nomeDoArquivo)
        {
            this.nomeDoArquivo = nomeDoArquivo;
            carregarImagemDoDisco();
        }

        private void carregarImagemDoDisco()
        {
            Console.WriteLine("Carregando " + nomeDoArquivo);
        }

        public void MostrarImagem()
        {
            Console.WriteLine("Mostrando " + nomeDoArquivo);
        }
    }
}
