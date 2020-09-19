using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ExercisesTest
    {
        [Fact]
        public void should_return_an_array_from_1_to_10()
        {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_10_to_1()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
  
        [Fact]
        public void should_return_5050()
        {
            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int result = exercises.Exercise2();

            // Deve / Asserções
            Assert.Equal(5050, result);
        }

        // [Fact]
        // public void should_return_8_when_receive_4_and_6_and_8()
        // {
        //     // Dado / Setup
        //     var exercises = new Exercises();

        //     // Quando / Ação
        //     double result = exercises.Exercise4(4, 6, 8);

        //     // Deve / Asserções
        //     Assert.Equal(8, result);
        // }

        [Theory]
        [InlineData(new int[3]{4, 6, 8}, 6)]
        public void shoud_return_an_average_of_ages(int[] ages, double expected)
        {
            var exercises = new Exercises();

            double result = exercises.Exercise4(ages.ToList());

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[5]{18, 20, 16, 23, 30}, 80)]
        public void shoud_return_the_average_of_ages_between_18_and_35(int[] ages, double expected)
        {
            var exercises = new Exercises();

            double result = exercises.Exercise5(ages.ToList());

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(15, 13, 20.50, 10, 145908.75)]
        public void deve_retornar_o_gasto_total_em_cigarros(int anos, int cigarrosDia, double valorCarteira, int cigarrosCarteira, double expected)
        {
            var exercises = new Exercises();

            double gasto = exercises.Exercise7(anos, cigarrosDia, valorCarteira, cigarrosCarteira);

            Assert.Equal(expected, gasto);
        }


        [Theory]
        [InlineData(10, 5)]
        public void should_return_true_or_false_when_receive_x_and_y_values(int x, int y)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise8(x, y);

            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(10, 2, 7)]
        public void deve_retornar_se_n1_é_maior_que_a_soma_de_n2_e_n3(double n1, double n2, double n3)
        {
            var exercises = new Exercises();

            var primeiroMaior = exercises.Exercise9(n1, n2, n3);

            Assert.Equal(true, primeiroMaior);
        }

        [Theory]
        [InlineData(6, new int[10]{6, 12, 18, 24, 30, 36, 42, 48, 54, 60})]
        [InlineData(5, new int[10]{5, 10, 15, 20, 25, 30, 35, 40, 45, 50})]
        public void should_return_the_input_multiplied_by_1_to_10(int number, int[] expectedResult)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise17(number);

            // Deve / Asserções
            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, new int[10]{5,10,15,20,25,30,35,40,45,50})]
        public void deve_retornar_uma_lista_do_resultado_do_input_multiplicado_por_5(int[] numbers, int[] resultadoEsperado)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.ExerciseTesteSelect(numbers);

            // Deve / Asserções
            Assert.Equal(result, resultadoEsperado);
        }
    
    }
}
