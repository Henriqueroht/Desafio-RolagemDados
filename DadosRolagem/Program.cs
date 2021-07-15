using System;

namespace DadosRolagem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o número de lados do seu dado. Deve ser entre 4 e 100.");
            int numeroDeLados = Convert.ToInt32(Console.ReadLine());
            
            if (numeroDeLados > 100)
            {
                Console.WriteLine("O número de lados não pode ser maior que 100");
                PulaLinha(2);
                Main();

            }
            else if (numeroDeLados < 4)
            {
                Console.WriteLine("O número de lados não pode ser menor que 4");
                PulaLinha(2);
                Main();
            } 
            else
            {
                int numeroRolado = RolarDado(numeroDeLados);                

                if (numeroRolado % 2 == 0)
                {                    
                    ImprimeNumeroPar(numeroRolado);
                }
                else
                {
                    ImprimeNumeroImpar(numeroRolado);
                }
            }     

        }

        private static void ImprimeNumeroImpar(int numeroRolado)
        {
            PulaLinha(1);
            Console.WriteLine($"O número rolado é Impar: {numeroRolado}");
            PulaLinha(1);
            Console.WriteLine("Jogue novamente!");
            PulaLinha(2);
            Main();
        }

        private static void ImprimeNumeroPar(int numeroRolado)
        {
            PulaLinha(1);
            Console.WriteLine($"O número rolado é Par: {numeroRolado}");
            PulaLinha(1);
            Console.WriteLine("Jogue novamente!");
            PulaLinha(2);
            Main();
        }

        public static int RolarDado(int numeroDeLados)
        {
            Random rd = new Random();
            int numeroRolado = rd.Next(1, numeroDeLados + 1);
            return numeroRolado;
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
