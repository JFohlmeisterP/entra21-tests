using System;
using Xunit;

namespace entra21_tests
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
    }
}
