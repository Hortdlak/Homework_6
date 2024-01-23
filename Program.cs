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
            #region Строка из матрицы символов
            //Задайте двумерный массив символов(тип char[,]). Создать строку из символов этого массива.

            //string result = CreatingStringForCharMatrix();

            //Console.Write(result);

            #endregion

            #region Изменение регистра с помощью "ToLower"

            //Задайте строку, содержащую латинские буквы в обоих регистрах.
            //Сформируйте строку, в которой все заглавные буквы заменены на строчные.

            //string text = "Надо изменить регистр. В этом задании.";
            //string result = text.ToLower();
            //Console.WriteLine(result);

            #endregion

            #region

            //Задайте произвольную строку.Выясните, является ли она палиндромом.

            string testWord = "А роза упала на лапу Азора";

            string answer = isPalindrome(testWord) ? "Да" : "Нет";

            Console.WriteLine(answer);

            #endregion



            Console.ReadKey();
        }

        private static bool isPalindrome(string testWord)
        {

            string normalized = new string(testWord.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            return normalized.SequenceEqual(normalized.Reverse());

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
