using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedra
{
    internal class method
    {
        public method(int[][] ar)//создаём конструктор класса
        {
            Console.WriteLine(big_sum(ar));// выводим на консоль результат работы метода big_sum
        }
        /// <summary>
        /// Метод котрый выводит найти максимальную сумму, которую можно получить из различных маршрутов прохождения по массиву
        /// </summary>
        /// <param name="array"> обязательный паркметр, массив в котором будет идти поитск</param>
        /// <param name="row">необязательный параметр,начльное знаение =0; указывает на каком уровне сейчас метод</param>
        /// <param name="column">необязательный параметр,начльное знаение =0; указывает на каком ряду сейчас метод</param>
        /// <param name="total">необязательный параметр,начльное знаение =0; указывает максимальнрую сумму для конкретных row и column</param>
        /// <returns></returns>
        int big_sum(int[][] array, int row = 0, int column = 0, int total = 0)
        {
            if (row == array.GetLength(0) - 1)// проверка: а не на последним ли уровне
            {
                return total + array[row][column];//если да, то просто возвращаем значение total+ значение на нижнем уровне
            }
            // если же не на последнем уровне, тогда необходимо идти по пути наибольшей суммы
            // поэтому проверяем для значений row и column значения которые находятся на уровень ниже  и соседнее с ним
            // и возвроащем значение наибольшего + total(то есть, суммы всех значений до этого уровня)
            if (big_sum(array, row + 1, column, total + array[row][column]) >
                   big_sum(array, row + 1, column + 1, total + array[row][column]))
            {
                return big_sum(array, row + 1, column, total + array[row][column]);
            }
            else
            {
                return big_sum(array, row + 1, column + 1, total + array[row][column]);
            }
        }
    }
}
