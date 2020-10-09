using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Exercises
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

        public string Exercise10(int A, int B)
        {
            
            if (A == B)
            {
                return $"A = B";
            }
            else if (A > B)
            {
                return $"A é maior";
            }
            else
            {
                return $"B é maior";
            }
            
        }

        public string Exercise11(int a, int b)
        {
            int quociente = 0;

            if (b != 0)
            {
                quociente = a / b;
                return $"{quociente}";
            }
            else
            {
                return $"Divisão por zero.";
            }
        }
        public double Exercise12(List<double> numbers)
        {
            var soma = 0.0;
            
            foreach(var item in numbers)
            {
                if(item % 2 == 0)
                {
                    soma += item;
                }
            }

            return soma;
        }
        
        public int Exercise13(List<int> numbers)
        {
            var maior = 0;

            foreach(var item in numbers)
            {
                if (item > maior)
                {
                    maior = item;
                }
            }

            return maior;

        }

        public string Exercise14(double a, double b, double c)
        {

            if (a > b)
            {
                if (b > c)
                {
                    return $"{c}, {b}, {a}";
                }
                else
                {
                    if (a > c)
                    {
                        return $"{b}, {c}, {a}";
                    }
                    else
                    {
                        return $"{b}, {a}, {c}";
                    }
                }
            }
            else if (b > c)
            {
            
                if (a > c)
                {
                    return $"{c}, {a}, {b}";
                }
                else
                {
                    return $"{a}, {c}, {b}";
                }
                
            }
            else 
            {
                return $"{a}, {b}, {c}";
            }
        }

        public int[] Exercise15(List<int> numbers)
        {
            var multiplos = new int[2];
            var multiplos3 = 0;
            var multiplos5 = 0;

            foreach(var item in numbers)
            {
                if (item % 3 == 0)
                {
                    multiplos3++;
                }
                else if (item % 5 == 0)
                {
                    multiplos5++;
                }
            }

            multiplos[0] = multiplos3;
            multiplos[1] = multiplos5;

            return multiplos;

        }

        public double Exercise16(double salario)
        {
            var salarioliquido = 0.0;
            
            if (salario > 600 && salario <= 1200)
            {
                salarioliquido = salario - (salario * 0.2);
            }
            else if (salario > 1200 && salario <= 2000)
            {
                salarioliquido = salario - (salario * 0.25);
            }
            else
            {
                salarioliquido = salario - (salario * 0.3);
            }

            return salarioliquido;

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

        public double Exercise18(int apple)
        {
            var price = 0.0;
            
            if (apple < 12)
            {
                price = 1.30;
            }
            else if (apple >= 12)
            {
                price = 1.00;
            }

            double total = apple + price;
            
            return total;
        }

        public IEnumerable<int> ExerciseTesteSelect(int[] numbers)
        {
            // Quando o usuário informar 10 inteiros, multiplicar por 5
            // Retornar a lista dos inteiros multiplicados por 5
            return numbers.Select(item => item * 5);

        }
    }
}