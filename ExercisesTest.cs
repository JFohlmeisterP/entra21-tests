using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace entra21_tests
{
    public class ExercisesTest
    {
        // Primeira Lista **************************************************************************************************

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
        public void should_return_an_array_from_1_to_10_but_only_even_numbers()
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
        [InlineData(10, 5, "A é maior")]
        public void deve_retornar_uma_string_informando_se_A_e_B_sao_iguais_ou_qual_o_maior_numero(int A, int B, string expected)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise10(A, B);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(50, 2, "25")]
        public void deve_retornar_uma_string_informando_o_quociente_da_divisao_de_a_por_b_ou_informando_divisao_por_zero(int a, int b, string expected)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise11(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[4]{1,4,3,10}, 14)]
        public void deve_retornar_a_soma_dos_numeros_pares_de_um_array(double[] numbers, double expected)
        {
            var exercises = new Exercises();

            var soma = exercises.Exercise12(numbers.ToList());

            Assert.Equal(expected, soma);
        }

        [Theory]
        [InlineData(new int[10]{2,3,4,1,5,6,8,7,9,10}, 10)]
        public void deve_retornar_o_maior_numero_da_lista(int[] numbers, int outputEsperado)
        {
            var exercises = new Exercises();

            var maior = exercises.Exercise13(numbers.ToList());

            Assert.Equal(outputEsperado, maior);
        }

        [Theory]
        [InlineData(7, 9, 2, "2, 7, 9")]
        public void deve_retornar_uma_string_com_os_numeros_em_ordem_crescente(double a, double b, double c, string outputEsperado)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise14(a, b, c);

            Assert.Equal(outputEsperado, result);
        }

        [Theory]
        [InlineData(new int[10]{2,3,4,1,5,6,8,7,9,10}, new int[2]{3,2})]
        public void deve_retornar_um_array_com_a_quantidade_de_multiplos_de_3_e_5(int[] numbers, int[] outputEsperado)
        {
            var exercises = new Exercises();

            var multiplos = exercises.Exercise15(numbers.ToList());

            Assert.Equal(outputEsperado, multiplos);
        }

        [Theory]
        [InlineData(1300.00, 975.00)]
        public void deve_retornar_o_valor_do_salario_liquido_ao_receber_o_salario_bruto(double salario, double outputEsperado)
        {
            var exercises = new Exercises();

            var salarioliquido = exercises.Exercise16(salario);

            Assert.Equal(outputEsperado, salarioliquido);
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
        [InlineData(11, 12.30 )]
        public void deve_retornar_o_preco_das_macas_de_acordo_com_o_input(int apple, double valorEsperado)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var total = exercises.Exercise18(apple);

            // Deve / Asserções
            Assert.Equal(total, valorEsperado);
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

        // *****************************************************************************************************************

        // Lista 1 Arrays **************************************************************************************************

        [Theory]
        [InlineData(new int[15]{5,10,15,20,25,30,35,40,45,50,55,60,65,70,75}, new int[15]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, new int[15]{4,8,12,16,20,24,28,32,36,40,44,48,52,56,60})]
        public void deve_retornar_um_array_da_diferença_dos_elementos_de_a_e_b(int[] a, int[] b, int[] resultadoEsperado)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var c = exercises.ExerciseArray1(a, b);

            // Deve / Asserções
            Assert.Equal(c, resultadoEsperado);

        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, new int[10]{10,9,8,7,6,5,4,3,2,1})]
        public void deve_retornar_um_array_com_a_ordem_dos_elementos_inversa_ao_input(int[] numbers, int[] resultadoEsperado)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var retorno = exercises.ExerciseArray2(numbers);

            // Deve / Asserções
            Assert.Equal(retorno, resultadoEsperado);
            
        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, 5, "O número existe no array.")]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, 11, "Número inexistente.")]
        public void deve_retornar_uma_string_informando_se_o_input_num_existe_dentro_do_array_input(int[] a, int num, string esperado)
        {
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var message = exercises.ExerciseArray3(a, num);

            // Deve / Asserções
            Assert.Equal(message, esperado);
            
        }

        // [Theory]
        // [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, new int[10]{1,2,3,4,5,6,7,8,9,10}, "Os arrays são iguais.")]
        // [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, new int[10]{1,2,3,7,5,6,12,8,9,10}, "Os arrays são diferentes.")]
        // public void deve_retornar_uma_string_informando_se_os_arrays_são_iguais_ou_diferentes(int[] a, int[] b, string menssagemEsperada)
        // {
        //     // Dado / Setup
        //     var exercises = new Exercises();
            
        //     // Quando / Ação
        //     var message = exercises.ExerciseArray4(a, b);

        //     // Deve / Asserções
        //     Assert.Equal(message, menssagemEsperada);
            
        // }
    
    }
}
