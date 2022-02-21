using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nedra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Path\Input.txt";// переменная указывающая путь до файла
            string[] lines = File.ReadAllLines(path);// считываем весь файл в масситв строк
            int[][] num = new int[lines.Length][];//объявляем зубчатый массив
            for (int i = 0; i < lines.Length; i++)// цикл для переноса и преобразования значений из файла в массив
            {
                string[] temp = lines[i].Split(' ');// каждую строкуб преобразовываем в массив. Значения рпазделены пробелом
                num[i] = new int[temp.Length]; // для каждой новой строки выделяем выделяем память
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] != null)// проверка не конец ли строки
                        num[i][j] = Convert.ToInt32(temp[j]);// если нет: заносим в массив
                    else
                        break;//если да: переходим к следующей итерации
                }
            }
            method ans = new method(num); //создаем объект класса метод и передаем ему массив как параметр 
        }
    }    
}
