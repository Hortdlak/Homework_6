using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Задайте двумерный массив символов(тип char[,]). Создать строку из символов этого массива.

            string result = CreatingStringForCharMatrix();

            Console.Write(result);

            #endregion



            Console.ReadKey();
        }

        private static string CreatingStringForCharMatrix()
        {
            char[,] charactersForString = new char[,]
            {
                { 'H','e','l','l','o' },
                { 'W','o','r','l','d' }
            };

            string result = string.Empty;

            int index = 0;

            while (index != charactersForString.GetLength(0))
            {
                for (int i = 0; i < charactersForString.GetLength(1); i++)
                {
                    result += charactersForString[index, i];
                }

                index++;

                if (index != charactersForString.GetLength(0))
                {
                    result += " ";
                }
                
            }

            return result;
        }
    }
}
