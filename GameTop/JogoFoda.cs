namespace GameTop
{
    public class JogoFoda
    {
        private readonly ijogador _Jogador1;
        private readonly ijogador _Jogador2;
        

        public JogoFoda(ijogador jogador1, ijogador jogador2)
        {
             _Jogador1 = jogador1;
             _Jogador2 = jogador2;
        
        }

        public void IniciarJogo()
        {
            System.Console.Write(_Jogador1.Corre());
            System.Console.Write(_Jogador1.Chuta());
            System.Console.Write(_Jogador1.Passe());

            System.Console.Write("\n PROXIMO JOGADOR \n");

            System.Console.Write(_Jogador2.Corre());
            System.Console.Write(_Jogador2.Chuta());
            System.Console.Write(_Jogador2.Passe());

          
        }




    }
}