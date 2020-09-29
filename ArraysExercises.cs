using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    class ArraysExercises
    {
        public IEnumerable<int> ExerciseArray1(int[] a, int [] b)
        {

            // Subtrair os elementos de a e b, retornando um array c com o resultado.

            var c = new int[15];

            for (var i = 0; i < c.Length; i++)
            {
                c[i] = a[i] - b[i];
            }

            return c.Select(item => item);

        }

        public IEnumerable<int> ExerciseArray2(int[] numbers)
        {
            // Receber um array de 10 elementos e retornar um array na ordem inversa ao input.

            var retorno = new int[10];

            retorno[0] = numbers[9];
            retorno[1] = numbers[8];
            retorno[2] = numbers[7];
            retorno[3] = numbers[6];
            retorno[4] = numbers[5];
            retorno[5] = numbers[4];
            retorno[6] = numbers[3];
            retorno[7] = numbers[2];
            retorno[8] = numbers[1];
            retorno[9] = numbers[0];

            return retorno.Select(item => item);
        }

        public string ExerciseArray3(int[] a, int num)
        {
            // 3-Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um
            // número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a
            // mensagem: “O número existe no array” , caso contrário “Número inexistente”.

            bool existe = false;

            foreach(var item in a)
            {
                if(item == num)
                {
                    existe = true;
                    break;
                }
            }
            
            var message = existe ? "O número existe no array." : "Número inexistente.";

            return message;
        }

        // public string ExerciseArray4(int[] a, int[] b)
        // {
        //     bool equal = true;

        //     var estaContido = false;

        //     for (var i = 0; i < 10; i++)
        //     {
        //         for (var j = 0; j < b.Length; j++)
        //         {
        //             if (a[i] == b[j])
        //             {
        //                 estaContido = true;
        //                 //b[j] = null;
        //                 break;
        //             }
        //         }
        //     }

        //     if(!estaContido)
        //     {
        //         equal = false;
        //     }               
            
        //     var message = equal ? "Os arrays são iguais." : "Os arrays são diferentes.";
            
        //     return message;

        // }

        public void ExerciseArray5()
        {

        }

        public void ExerciseArray6()
        {

        }

        public void ExerciseArray7()
        {

        }

        public void ExerciseArray8()
        {

        }
    }
}