using System;

namespace DadosRolagem
{
    class Program
    {
        static void Main()
        {
            Dados dados =  new Dados();

            dados.QuantidadeDeLados = PerguntaERecebeNumeroDeLados();

            if (dados.QuantidadeDeLados > 100 || dados.QuantidadeDeLados < 4)
            {
                ExibeMensagemDeNumeroNaoPermitido(dados.QuantidadeDeLados);
                Main();
            }           
            else
            {
                Console.WriteLine("Quantos dados deseja rolar?");
                dados.QuantidadeDeDados = Convert.ToInt32(Console.ReadLine());

                RolaTodosDados(dados);
                ImprimeSomaDosResultados(dados);

                Restart();
            }

        }

        private static void ImprimeSomaDosResultados(Dados dados)
        {
            string resumoRolagem = "";
            for (int i = 0; i < dados.QuantidadeDeDados; i++)
            {
                if (i == 0)
                    resumoRolagem = dados.Dado[i].NumeroRolado.ToString();
                if (i != 0)
                    resumoRolagem = resumoRolagem + ", " + dados.Dado[i].NumeroRolado.ToString();
            }

            Console.WriteLine($"Resumo das rolagens: {resumoRolagem}");
            Console.WriteLine($"A soma dos resultados de todos os dados rolados é {dados.TotalRolado}.");
        }

        private static void Restart()
        {
            PulaLinha(2);
            Console.WriteLine("******  Jogue novamente!  ******");
            PulaLinha(1);
            Main();
        }

        private static void RolaTodosDados(Dados dados)
        {
            dados.Dado = new Dado[dados.QuantidadeDeDados];
            PulaLinha(1);
            for (int i = 0; i < dados.QuantidadeDeDados; i++)
            {
                Console.WriteLine($"Rolando dado {(i + 1)}.");

                Dado dado = new Dado();
                dado.QuantidadeDeLados = dados.QuantidadeDeLados;
                dado.RolarDado();

                if (dado.NumeroRolado % 2 == 0)
                {
                    ImprimeNumeroPar(dado.NumeroRolado);
                }
                else
                {
                    ImprimeNumeroImpar(dado.NumeroRolado);
                }
                dados.Dado[i] = dado;
                dados.TotalRolado +=  dado.NumeroRolado;
            }
        }

        private static void ExibeMensagemDeNumeroNaoPermitido(int numeroDeLados)
        {
            if (numeroDeLados > 100)
                Console.WriteLine("O número de lados não pode ser maior que 100");

            if (numeroDeLados < 4)
                Console.WriteLine("O número de lados não pode ser menor que 4");

            PulaLinha(2);
        }

        private static int PerguntaERecebeNumeroDeLados()
        {
            Console.WriteLine("Digite o número de lados do seu dado. Deve ser entre 4 e 100.");
            int numeroDeLados = Convert.ToInt32(Console.ReadLine());
            return numeroDeLados;
        }

        private static void ImprimeNumeroImpar(int numeroRolado)
        {
            Console.WriteLine($"O número rolado é Impar: {numeroRolado}");
            PulaLinha(1);          
        }

        private static void ImprimeNumeroPar(int numeroRolado)
        {
            Console.WriteLine($"O número rolado é Par: {numeroRolado}");
            PulaLinha(1);            
        }

        static void PulaLinha(int numeroDeLinhas)
        {
           for (int i = 0; i < numeroDeLinhas; i++)
           {
                Console.WriteLine(" ");
           }
            
        }
    }
}
