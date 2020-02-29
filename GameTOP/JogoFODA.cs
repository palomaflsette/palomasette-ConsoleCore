using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA 
    {
        private readonly iJogador _jogador1; 

        private readonly iJogador _jogador2;

        public JogoFODA (iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        public void IniciarJogo() 
        {
            Console.WriteLine(_jogador1.Chuta());
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Passe());
            
            System.Console.Write("\nPRÓXIMO JOGADOR: \n\n");

            Console.WriteLine(_jogador2.Chuta());
            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Passe());
        }
    }


}