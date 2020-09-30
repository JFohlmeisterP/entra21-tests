using System;
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

        public double[] ExerciseArray5(double[] a)
        {
            // 5- Receber uma array com 15 elementos, retornar média aritmética e quantos elementos estão abaixo, 
            // acima e na média.

            double soma = 0.0;
            double mediaAritmetica = 0.0;
            int acimaDaMedia = 0;
            int naMedia = 0;
            int abaixoDaMedia = 0;

            for (var i = 0; i < a.Length; i++)
            {
                soma += a[i];
                mediaAritmetica = soma / a.Length;
            }

            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] > mediaAritmetica)
                {
                    acimaDaMedia++;
                }
                else if (a[i] == mediaAritmetica)
                {
                    naMedia++;
                }
                else
                {
                    abaixoDaMedia++;
                }
            }

            var result = new double[4];

            result[0] = mediaAritmetica;
            result[1] = acimaDaMedia;
            result[2] = naMedia;
            result[3] = abaixoDaMedia;

            return result;

        }

        public int[] ExerciseArray1List2(int[] a, int[] b)
        {
            // Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.
            
            Array.Clear(a, 0, a.Length);

            for(var i = 0; i < a.Length; i++)
            {
                a[i] = b[i];
            }

            var result = new int[10];

            for(var i = 0; i < result.Length; i++)
            {
                result[i] = a[i];
            }

            return result;

        }

        public string ExerciseArray2List2(int[] a)
        {
            // Informar se há elementos repetidos, ou não, dentro do array input.

            var quantidadeRepetidos = a.Length - a.Distinct().Count();

            var message = quantidadeRepetidos > 0 ? "Sim, existem números repetidos." : "Não existem números repetidos.";
            
            return message;
        }

        // public double[] ExerciseArray3List2(string[] sex, string[] answer)
        // {
        //     // Conforme inpu, retornar:
        //     // • O número de pessoas que responderam sim;
        //     // • O número de pessoas que responderam não;
        //     // • A porcentagem de pessoas do sexo feminino que responderam sim;
        //     // • A porcentagem de pessoas do sexo masculino que responderam não;
            
        //     var yes = 0;
        //     var no = 0;
        //     var femaleYes = 0.0;
        //     var maleNo = 0.0;

        //     for(var i = 0; i < 10; i++)
        //     {   
        //         if (answer[i] == "SIM")
        //         {
        //             yes++;
        //         }
        //         else
        //         {
        //             no++;
        //         }

        //         if(sex[i] == "F" && answer[i] == "SIM")
        //         {
        //             femaleYes++;
        //         }
        //         else if(sex[i] == "M" && answer[i] == "NAO")
        //         {
        //             maleNo++;
        //         }
        //     }

        //     var result = new double[];

        //     result[0] = yes;
        //     result[1] = no;
        //     result[2] = femaleYes;
        //     result[3] = maleNo;

        // }
    }
}