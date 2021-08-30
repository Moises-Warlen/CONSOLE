namespace GameTop.Lib
   {
      public class jogador1 : ijogador
    {
        public readonly string _Nome;
        public jogador1(string nome ="Moises")
        {
           _Nome = nome; 
        }
        public string Chuta()
        {
            return $"{_Nome} esta chutando \n ";
        }
         public string Corre()
        {
            return $"{_Nome} esta correndo \n ";
        }
         public string Passe()
        {
            return $"{_Nome} deu passe \n";
        }
        
    }
       
       
   }
