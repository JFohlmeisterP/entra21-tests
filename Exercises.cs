using System;

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

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 8,
        // então a aplicação deverá retornar true ou false, dependendo do input do usuário para x e y.
        public bool Exercise8(int x, int y)
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

        static void Exercise3()
        {
            // Quando o usuário chamar o exercício 3, a aplicação deverá retornar todos os números ímpares menores que 200.
            var numbers = new int[100];

            for(var i = 0; i < 200; i++)
            {
                if(numbers[i] % ]
            }

            Console.WriteLine("Ímpares menores que 200:");

            while (counter < 200)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }


    }
}