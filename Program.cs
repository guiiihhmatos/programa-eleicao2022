using System;

namespace eleicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolsonaro = 0;
            int lula = 0;
            int doria = 0;
            int temer = 0;

            int votos, pessoas, opcao, votoNulo, votoBranco, naoVotos;
            votos = 0;
            votoNulo = 0;
            votoBranco = 0;
            naoVotos = 0;

            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Bem Vindo a votação da eleição de 2022");

            Console.WriteLine("Digite o número exato de pessoas que vão votar : ");
            pessoas = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            while (votos < pessoas)
            {
                 Console.WriteLine("Escolha o seu voto para presidente da república. Digite 1- Lula; 2- Bolsonaro; 3- Dória; 4- Temer; 5- Voto NULO; 6- Voto em BRANCO");
                 opcao = Convert.ToInt32(Console.ReadLine());

                 switch(opcao){
                     case 1: 
                     lula++;
                     votos++;
                     break;

                     case 2:
                     bolsonaro++;
                     votos++;
                     break;

                     case 3:
                     doria++;
                     votos++;
                     break;

                     case 4:
                     temer++;
                     votos++;
                     break;

                     case 5:
                     votoNulo++;
                     votos++;
                     break;

                     case 6:
                     votoBranco++;
                     votos++;
                     break;

                     default:

                     Console.WriteLine("Opção inválida, revise sua escolha. ");
                     naoVotos++;
                     break;
                 
                 }
                 Console.Clear();
            }
            if(lula > bolsonaro && lula > temer && lula > doria){

                Console.WriteLine("No Total foram {0} pessoas que votaram", pessoas);
                Console.WriteLine("O presidente escolhido foi o Lula, com {0}% de todos os votos", ((lula * 100)/(votos)));

            } else if(bolsonaro > lula && bolsonaro > temer && bolsonaro > doria){

                Console.WriteLine("No Total foram {0} pessoas que votaram", pessoas);
                Console.WriteLine("O presidente escolhido foi o Bolsonaro, com {0}% de todos os votos", ((bolsonaro * 100)/(votos)));

            } else if(temer > bolsonaro && temer > lula && temer > doria){

                Console.WriteLine("No Total foram {0} pessoas que votaram", pessoas);
                Console.WriteLine("O presidente escolhido foi o Temer, com {0}% de todos os votos", ((temer * 100)/(votos)));

            } else if(doria > bolsonaro && doria > temer && doria > lula){

                Console.WriteLine("No Total foram {0} pessoas que votaram", pessoas);
                Console.WriteLine("O presidente escolhido foi o Dória, com {0}% de todos os votos", ((doria * 100)/(votos)));
            } else {

                Console.WriteLine("Houve um empate, faremos a eleição novamente nos próximos 14 dias");

            }
            Console.WriteLine("No total de {0} votos, tivemos {1} votos em Branco e {2} votos nulo. Juntando os dois temos cerca de {3}% dos votos. {4} pessoas escolheram uma opção inválida", votos, votoBranco, votoNulo, (((votoNulo + votoBranco) * 100)/(votos)), naoVotos );
            Console.ReadKey();
        }
    }
}
