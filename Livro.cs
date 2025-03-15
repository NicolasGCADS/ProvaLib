using System;

    public abstract class Livro  
    {
        
        public abstract string Sinopse();
    }

    class Terror : Livro
    {
        
        public override string Sinopse()
        {
            return "O jovem advogado inglês Jonathan Harker aceita um trabalho em uma vila sombria nas brumas da Transilvânia, na Romênia. " +
                   "Ele é capturado e aprisionado pelo vampiro Drácula, que viaja para Londres inspirado por uma fotografia da noiva de Harker, Mina Murray. " +
                   "Na Grã-Bretanha, Drácula começa um reinado de sedução e horror, drenando a vida da amiga mais próxima de Mina, Lucy Westenra. " +
                   "Os amigos de Lucy unem forças com o professor Abraham Van Helsing para tentar afastar Drácula de uma vez por todas.";
        }
    }

    
    class LivroTeste
    {
        static void Main()
        {
         
            Livro livro = new Terror();

            
            Console.WriteLine(livro.Sinopse());
        }
    }

