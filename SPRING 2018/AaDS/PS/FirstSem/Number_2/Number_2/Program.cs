using System;
using System.Runtime.Remoting.Messaging;

namespace Number_2
{
    class Program
    {
        public static void Main()
        {
            var array1 = new[] { "дрофа", "официант", "блин", "морковь", "картошка" };
            var array2 = new[] { "апельсин", "банан", "яблоко" };
            var palindromeArray = new[] { "топот", "радар", "довод", "заказ", "весна" };
            var englishWordsArray = new[] { "apple", "sun", "people", "stick", "rainbow" };

            var palindromeSet = new WordSet(palindromeArray);
            var wordSet1 = new WordSet(array1);
            var wordSet2 = new WordSet(array2);

            // Создание списка по массиву
            var englishWordSet = new WordSet(englishWordsArray);
            Console.WriteLine("\"Создание списка по массиву\" \n");
            englishWordSet.ShowWordSet();

            // Создание списка по двум другим спискам
            var wordSet = new WordSet(wordSet1, wordSet2);
            Console.WriteLine("\"Создание списка по двум другим спискам\" \n");
            wordSet.ShowWordSet();

            // Вывод списка в текстовый файл
            wordSet.Out("wordSet.txt");

            // Добавление слова в список
            Console.WriteLine("\"Добавление слова в список\" \n");
            wordSet.Insert("день");
            wordSet.ShowWordSet();

            //Удаление слова из списка
            Console.WriteLine("\"Удаление слова из списка\" \n");
            wordSet.Delete("морковь");
            wordSet.ShowWordSet();

            // Формирования нового списка слов, имеющих фиксированную длину l
            var newWordSet = wordSet.NewWordSetByWordLength(8);
            Console.WriteLine("\"Формирования нового списка слов, имеющих фиксированную длину l\" \n");
            newWordSet.ShowWordSet();

            // Разбиение списка слов на два, соответственно содержащих слова, начинающиеся с гласных и согласных букв.
            Console.WriteLine("\"Разбиение списка слов на два, соответственно содержащих слова, начинающиеся с гласных и согласных букв.\" \n");
            var vowelAndConsonantWordSet = wordSet.VowelDivide();
            foreach (var set in vowelAndConsonantWordSet)
            {
                set.ShowWordSet();
            }

            // Удаление из списка палиндромов
            palindromeSet.RemovePalindrom();
            Console.WriteLine("\"Удаление из списка палиндромов\" \n");
            palindromeSet.ShowWordSet();
        }
    }
}