using Enums;
using Entities;

namespace PedraPapelTesoura
{
    public class Tela : Jogo
    {
        public static char Opcao = 's';



        public static void ImprimeJogo()
        {
            Console.WriteLine(@"                        PEDRA, PAPEL, TESOURA!
            
");

            



            Console.WriteLine($@"
Regras:
O jogador deve escolher entre:
1 - Pedra
2 - Papel
3 - Tesoura
Para decidir quem ganhou, o sistema compara os elementos da seguinte forma: 
Pedra ganha da tesoura (amassando-a ou quebrando-a),
Tesoura ganha do papel (cortando-o),
Papel ganha da pedra (embrulhando-a);


");



          


            while (Opcao != 'n')
            {
                Placar();
                RealizaJogada();

                Console.WriteLine();

                Continua();

                Console.Clear();



            }
        }



        public static void Continua()
        {


            try
            {
                Console.WriteLine("Deseja continuar? s/n");
                Opcao = Convert.ToChar(Console.ReadLine().Trim());

            }
            catch (Exception ex)
            {
                Console.Write("Opcao inválida. Iniciando nova jogada");

                Thread.Sleep(400);
                Console.Write('.');
                Thread.Sleep(400);
                Console.Write('.');
                Thread.Sleep(400);
                Console.Write('.');
                Thread.Sleep(400);


                Opcao = 's';
            }

        }

    }
}
