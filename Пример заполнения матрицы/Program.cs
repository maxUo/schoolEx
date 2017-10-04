using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int n = int.Parse(inp);
            Random rand = new Random();
            //Заполнение первой матрицы
            List<List<int>> firstMatrix = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                //создание временного массива, чтобы добавить его в матрицу
                List<int> tmp = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    tmp.Add(rand.Next(1, 5)); //заполнение рандомными элементами от 1 до 5
                }
                //добавление в матрицу
                firstMatrix.Add(tmp);
            }
            //Заполнение второй матрицы
            List<List<int>> secondMatrix = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                //создание временного массива, чтобы добавить его в матрицу
                List<int> tmp= new List<int>();
                for (int j = 0; j < n; n++)
                {
                    tmp.Add(rand.Next(1, 5)); //аналогично первому циклу
                }
                //добавление в матрицу
                secondMatrix.Add(tmp);
            }
            Console.WriteLine("Первая матрица:");
            PrintValue(firstMatrix);
            Console.WriteLine("Вторая матрица");
            PrintValue(secondMatrix);
        }
        //Метод вывода List<List<T>>
        private static void PrintValue(List<List<int>> matrix)
        {
            //очень сложная для понимания вещь,
            //в кратце, это просто два цикла, которые внутри проходят по всем
            //элементам внешнего массива и внутреннего,
            //элементы внутреннего 
            matrix.Aggregate("",(str,list)=>str+list.Aggregate("", (e, q) => e + " " + q)+"\n");
        }
    }
}