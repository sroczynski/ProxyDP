using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class VideoGame
    {
        private _InserirJogo ij;

        public VideoGame(_InserirJogo tipoDeJogo)
        {
            ij = tipoDeJogo;
        }

        public void InserirJogo()
        {
            ij.Inserir();
        }
    }
}
