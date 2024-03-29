﻿using System;

using System.Linq;

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

            #region Проверка на палиндромом

            //Задайте произвольную строку.Выясните, является ли она палиндромом.

            //string testWord = "А роза упала на лапу Азора";

            //string answer = isPalindrome(testWord) ? "Да" : "Нет";

            //Console.WriteLine(answer);

            #endregion

            #region Реверс строки с сохранением пробелов

            //Задайте строку, состоящую из слов, разделенных пробелами.
            //Сформировать строку, в которой слова расположены в обратном порядке.
            //В полученной строке слова должны быть также разделены пробелами.

            string testText = "Эта строка будет перевернута";

            string result = StringRevers(testText);

            Console.Write(result);

            #endregion

            Console.ReadKey();
        }

        private static string StringRevers(string testText)
        {
            testText = testText.ToLower();

            string[] words = testText.Split(' ');

            Array.Reverse(words);

            words[0] = words[0].Substring(0, 1).ToUpper() + words[0].Substring(1, words[0].Length - 1);

            return string.Join(" ", words);
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
