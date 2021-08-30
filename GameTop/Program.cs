
using System;
using GameTop.Lib;

namespace GameTop.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
         var jogo = new JogoFoda(
             new jogador1(),
             new jogador2()
           
             );
         jogo.IniciarJogo();
        }
    }
    


}
