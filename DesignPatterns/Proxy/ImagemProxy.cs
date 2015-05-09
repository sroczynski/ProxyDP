using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    public class ImagemProxy : _Imagem
    {
        private String nomeDoArquivo;
        private _Imagem imagem;

        public ImagemProxy(String nomeDoArquivo)
        {
            this.nomeDoArquivo = nomeDoArquivo;
        }
        public void MostrarImagem()
        {
            if (imagem == null)
                imagem = new ImagemReal(nomeDoArquivo);

            imagem.MostrarImagem();
        }

    }
}
