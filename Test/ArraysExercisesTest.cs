using System;
using System.Collections.Generic;
using Domain;
using Xunit;

namespace Test
{
    public class ArraysExercisesTest
    {
        [Theory]
        [InlineData(new int[15]{5,10,15,20,25,30,35,40,45,50,55,60,65,70,75}, new int[15]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, new int[15]{4,8,12,16,20,24,28,32,36,40,44,48,52,56,60})]
        public void deve_retornar_um_array_da_diferença_dos_elementos_de_a_e_b(int[] a, int[] b, int[] resultadoEsperado)
        {
            // Dado / Setup
            var arrays = new ArraysExercises();
            
            // Quando / Ação
            var c = arrays.ExerciseArray1(a, b);

            // Deve / Asserções
            Assert.Equal(c, resultadoEsperado);

        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, new int[10]{10,9,8,7,6,5,4,3,2,1})]
        public void deve_retornar_um_array_com_a_ordem_dos_elementos_inversa_ao_input(int[] numbers, int[] resultadoEsperado)
        {
            // Dado / Setup
            var arrays = new ArraysExercises();
            
            // Quando / Ação
            var retorno = arrays.ExerciseArray2(numbers);

            // Deve / Asserções
            Assert.Equal(retorno, resultadoEsperado);
            
        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, 5, "O número existe no array.")]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, 11, "Número inexistente.")]
        public void deve_retornar_uma_string_informando_se_o_input_num_existe_dentro_do_array_input(int[] a, int num, string esperado)
        {
            // Dado / Setup
            var arrays = new ArraysExercises();
            
            // Quando / Ação
            var message = arrays.ExerciseArray3(a, num);

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

        [Theory]
        [InlineData(new double[15]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}, new double[4]{8,7,1,7})]
        public void deve_retornar_a_média_final_e_quantos_estão_acima_abaixo_e_na_média_ao_receber_input(double[] a, double[] expectedResult)
        {
            var arrays = new ArraysExercises();

            var result = arrays.ExerciseArray5(a);

            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10}, new int[10]{10,9,8,7,6,5,4,3,2,1}, new int[10]{10,9,8,7,6,5,4,3,2,1})]
        public void deve_retornar_o_array_b_do_input(int[] a, int[] b , int[] expectedResult)
        {
            var arrays = new ArraysExercises();

            var result = arrays.ExerciseArray1List2(a, b);

            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData(new int[10]{1,1,2,3,4,5,6,7,8,9} , "Sim, existem números repetidos.")]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,10} , "Não existem números repetidos.")]
        [InlineData(new int[10]{1,2,3,4,5,6,7,8,9,5} , "Sim, existem números repetidos.")]
        public void deve_retornar_uma_string_informando_se_há_ou_não_elementos_repetidos_no_array_input(int[] a, string expectedMessage)
        {
            var arrays = new ArraysExercises();

            var result = arrays.ExerciseArray2List2(a);

            Assert.Equal(result, expectedMessage);
        }

        [Theory]
        [InlineData(new string[4]{"F", "M", "M", "F"}, new string[4]{"SIM", "SIM", "NAO", "NAO"}, new double[4]{2, 2, 1, 1})]
        [InlineData(new string[4]{"F", "F", "M", "F"}, new string[4]{"SIM", "SIM", "NAO", "NAO"}, new double[4]{2, 2, 2, 1})]
        [InlineData(new string[4]{"M", "M", "M", "F"}, new string[4]{"NAO", "SIM", "NAO", "NAO"}, new double[4]{1, 3, 0, 2})]
        public void deve_retornar_a_quantidade_de_respostas_positivas_e_negativas_em_geral_e_respostas_positivas_de_mulheres_e_negativas_de_homens(string[] sex, string[] answer, double[] expectedResult)
        {
            var arrays = new ArraysExercises();

            var result = arrays.ExerciseArray3List2(sex, answer);

            Assert.Equal(result, expectedResult);   
        }
    }
}
