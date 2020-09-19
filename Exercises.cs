using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numbers[counter - 1] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int counter = 10; counter > 0; counter--)
            {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }

        public int Exercise2()
		{
			int sum = 0;

            for (int counter = 1; counter < 101; counter++)
            {
				sum += counter;
            }

            return sum;
		}

        // public int[] Exercise3(int[] numbers)
        // {
        //     // Quando o usuário chamar o exercício 3, a aplicação deverá retornar todos os números ímpares menores que 200.
        //     numbers = new int[100];

        //     for(var i = 1; i < 200; i++)
        //     {
        //         if(i % 2 == 1)
        //         {
        //             for(var j = 0; j < numbers.Length; j++)
        //             {
        //                 numbers[j] = i;
        //             }
        //         }

        //     }

        //     return numbers;

        // }

        public double Exercise4(List<int> ages)
        {
            // Deve retornar a media de idade da turma assim que o usuario finalizar o cadastro de idades

            double sum = 0.0;

            var answers = ages.Count;

            foreach(var item in ages)
            {
                sum += item;
            }

            var average = (sum/answers);

            return average;

        }

        public double Exercise5(List<int> ages)
        {
            var counter = 0;

            foreach(var item in ages)
            {
                if(item >= 18 && item <= 35)
                {
                    counter++;
                }
            }

            var result = (counter * 100) / ages.Count;

            return result;

        }

        public void Exercise6()
        {
            
        }

        public double Exercise7(int anos, int cigarrosDia, double valorCarteira, int cigarrosCarteira)
        {
            double gasto = (((anos * 365) * cigarrosDia) * valorCarteira) / cigarrosCarteira;

            return gasto;
            
        }

        public bool Exercise8(int x, int y)
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 8,
        // então a aplicação deverá retornar true ou false, dependendo do input do usuário para x e y.
        {
            var answer = false;

            if(x % y == 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            return answer;
        }

        public bool Exercise9(double n1, double n2, double n3)
        {
            bool primeiroMaior = false;

            if (n2 + n3 < n1)
            {
                primeiroMaior = true;
            }
            else
            {
                primeiroMaior = false;
            }

            return primeiroMaior;

        }

        // public int Exercise10(double n1, double n2)
        // {
        //     if (n1 == n2)
        //     {
        //         System.Console.WriteLine("A = B");
        //         // retornar bool
        //     }
        //     else if (n1 > n2)
        //     {
        //         System.Console.WriteLine($"O maior número é: {a}");
        //         // retornar int
        //     }
        //     else
        //     {
                
        //     }
        // }

        public void Exercise11()
        {
            
        }
        public void Exercise12()
        {
            
        }

        public void Exercise13()
        {
            
        }

        public void Exercise14()
        {
            
        }

        public void Exercise15()
        {
            
        }

        public void Exercise16()
        {
            
        }

        public IEnumerable<int> Exercise17(int number)
		{
            // Imprimir a tabuada de qualquer número fornecido pelo usuário.
            // DADO que a aplicação esteja pronta, 
            // QUANDO o usuário informar um número
            // DEVE retornar a tabuada de 1 a 10

            var multiplicationTable = new List<int>(){
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            return multiplicationTable.Select(item => item * number);
		}

        public void Exercise18()
        {
            
        }

        public IEnumerable<int> ExerciseTesteSelect(int[] numbers)
        {
            // Quando o usuário informar 10 inteiros, multiplicar por 5
            // Retornar a lista dos inteiros multiplicados por 5
            return numbers.Select(item => item * 5);

        }
    }
}