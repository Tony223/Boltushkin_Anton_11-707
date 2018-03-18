using System;

namespace Number_2
{
    public class ExtraMethods
    {
        public static WordSetItem AddWord(WordSetItem tail, ref WordSetItem item)
        {
            tail.Next = item;
            tail = tail.Next;
            item = item.Next;
            return tail;
        }

        public static WordSetItem Swap(WordSetItem item, WordSetItem compareItem)
        {
            var reference = compareItem;
            compareItem = item;
            compareItem.Next = reference;
            return compareItem;
        }

        public static void Swap(WordSetItem item, WordSetItem compareItem, WordSetItem previousCompareItem)
        {
            var reference = compareItem;
            previousCompareItem.Next = item;
            item.Next = reference;
        }

        public static bool CheckPalindrom(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public static WordSet CreateWordSet(WordSet wordSet, WordSetItem item)
        {
            while (item != null)
            {
                wordSet.Insert(item.Word);
                item = item.Next;
            }
            return wordSet;
        }

        public static void ShowWordSet(WordSet wordSet)
        {
            var item = wordSet.Head;
            while (item != null)
            {
                Console.WriteLine("\t" + item.Word + "\n");
                item = item.Next;
            }
            Console.WriteLine("=========================================================================");
        }
    }
}