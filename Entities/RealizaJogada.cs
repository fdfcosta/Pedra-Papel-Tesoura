using Enums;
using PedraPapelTesoura;

namespace Entities
{
    public class Jogo
    {
        private static Jogada JogadaUsuario { get; set; }
        private static Jogada JogadaComputador { get; set; }
        private static Random Random { get; set; } = new();
        public static int VitoriasComputador { get; private set; }
        public static int VitoriasJogador { get; private set; }
        public static int Empates { get; private set; }




        public static void RealizaJogada()
        {

            Console.WriteLine("Faça sua jogada: ");
            string Jogada = Console.ReadLine().Trim();

            while (ChecaNumero(Jogada) != true)
            {
                Console.WriteLine(@"Número inválido. Por favor, escolha entre 1- pedra, 2- papel, 3- tesoura.

                ");

                Console.Write("Faça sua jogada: ");
                Jogada = Console.ReadLine().Trim();

                ChecaNumero(Jogada);
            }


            JogadaUsuario = Enum.Parse<Jogada>(Jogada);
            JogadaComputador = Enum.Parse<Jogada>(Convert.ToString(Random.Next(3) + 1));

            Console.WriteLine($"Jogador escolheu: {JogadaUsuario}");
            Console.WriteLine(@$"Computador escolheu: {JogadaComputador}
            ");

            DefineVencedor(JogadaUsuario, JogadaComputador);


        }



        private static bool ChecaNumero(string jogada)
        {
            int convJogada;
            try
            {
                convJogada = Convert.ToInt32(jogada);
            }
            catch (Exception ex)
            {
                return false;
            }

            return convJogada > 0 && convJogada < 4;
        }



        private static void DefineVencedor(Jogada jogadaUsuario, Jogada jogadaComputador)
        {
            bool UsuarioVenceu = (jogadaUsuario == Jogada.Papel && jogadaComputador == Jogada.Pedra) || (jogadaUsuario == Jogada.Tesoura && jogadaComputador == Jogada.Papel) || (jogadaUsuario == Jogada.Pedra && jogadaComputador == Jogada.Tesoura);
            bool Empate = jogadaUsuario == jogadaComputador;

            if (UsuarioVenceu)
            {
                Console.WriteLine("Vencedor: Jogador!");
                VitoriasJogador++;
            }
            else if (Empate)
            {
                Console.WriteLine("Empate!");
                Empates++;
            }
            else
            {
                Console.WriteLine("Vencedor: Computador!");
                VitoriasComputador++;
            }
        }

        public static void Placar()
        {
            Console.WriteLine($@"                               PLACAR
           -----------------------------------------------
            Vitórias(s) Jogador: {VitoriasJogador}    
           -----------------------------------------------
            Vitória(s) Computador: {VitoriasComputador}
           -----------------------------------------------
            Empate(s): {Empates}
           -----------------------------------------------


            ");
        }
    }
}
