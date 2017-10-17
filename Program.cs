using System;

namespace aula1710
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario = 2;

            while (salario < 10)
            {
                salario *= 2;
                Console.WriteLine("Seu salário é: " + salario);
            }

            string parar = "";

            while (parar != "s")
            {
                Console.WriteLine("Desena sair do programa? s/n");
                parar = Console.ReadLine();
            }

            //int i;
            int tabuada = 3;
            for (int i = 0; i <= 10; i++)
            {
                int resultado;
                resultado = tabuada * i;
                Console.WriteLine(tabuada + " x " + i + " = " + resultado);
            }

            string[] alunos = {"alexandre", "jose", "anderson"};
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Nome: " + alunos[i]);
            }

            String teste = "alexandre";
                for (int i = 0; i < teste.Length; i++)
                {
                    Console.WriteLine(teste[i]);
                }

            
        }
    }
}
