using System;
using System.IO;
using static Number_2.ExtraMethods;

namespace Number_2
{
    public class WordSetItem 
    {
        public string Word { get; set; }
        public WordSetItem Next { get; set; }
    }

    public class WordSet
    {
        public WordSetItem Head;

        public WordSet()
        {

        }
        
        public WordSet(string[] str)
        {
            foreach (var item in str)
                Insert(item);
        }
        
        public WordSet(WordSet w1, WordSet w2)
        {
            var item1 = w1.Head;
            var item2 = w2.Head;
            var tail = Head;
            bool fl = true;

            if (String.Compare(item1.Word, item2.Word) < 0)
            {
                Head = tail = item1;
                item1 = item1.Next;
            }
            else
            {
                Head = tail = item2;
                item2 = item2.Next;
            }

            while (fl)
            {
                switch (String.Compare(item1.Word, item2.Word))
                {
                    case -1:
                        tail = AddWord(tail, ref item1);
                        break;
                    case 0:
                        break;
                    case 1:
                        tail = AddWord(tail, ref item2);
                        break;
                }

                if (item1 == null)
                {
                    while (item2 != null)
                        tail = AddWord(tail, ref item2);
                    fl = false;
                }
                else if (item2 == null)
                {
                    while (item1 != null)
                        tail = AddWord(tail, ref item1);
                    fl = false;
                }
            }

            //var item = w1.Head;
            //CreateWordSet(this, item);
            //item = w2.Head;
            //CreateWordSet(this, item);
        }
        
        public void Out(string filename)
        {
            var item = Head;

            while (item != null)
            {
                File.AppendAllText(filename, item.Word + " ");
                item = item.Next;
            }

            //var item = Head;
            //var list = new List<string>();

            //while (item != null)
            //{
            //    list.Add(item.Word);
            //    item = item.Next;
            //}
            //File.WriteAllLines(filename, list);
        }

        public void Insert(string word)
        {
            if (Head == null)
                Head = new WordSetItem { Word = word, Next = null };
            else
            {
                var item = new WordSetItem { Word = word, Next = null };
                WordSetItem previousCompareItem = null;
                var compareItem = Head;
                var fl = true;

                while (fl)
                {
                    switch (String.Compare(item.Word, compareItem.Word))
                    {
                        case -1 when !compareItem.Word.Equals(Head.Word):
                            Swap(item, compareItem, previousCompareItem);
                            fl = false;
                            break;
                        case -1:
                            Head = Swap(item, compareItem);
                            fl = false;
                            break;
                        case 0:
                            fl = false;
                            break;
                        case 1:
                            previousCompareItem = compareItem;
                            compareItem = compareItem.Next;
                            if (compareItem == null)
                            {
                                previousCompareItem.Next = item;
                                fl = false;
                            }
                            break;
                    }
                }
            }
        }
        
        public void Delete(string word)
        {
            if (Head != null)
            {
                WordSetItem previousItem = null;
                var item = Head;
                bool fl = true;

                while (fl)
                {
                    switch (item.Word == word)
                    {
                        case true when item == Head:
                            Head = Head.Next;
                            fl = false;
                            break;
                        case true:
                            previousItem.Next = item.Next;
                            fl = false;
                            break;
                        case false:
                            previousItem = item;
                            item = item.Next;
                            if (item == null)
                                fl = false;
                            break;
                    }
                }
            }
        }
        
        public WordSet NewWordSetByWordLength(int l)
        {
            var wordSet = new WordSet();
            var item = Head;

            while (item != null)
            {
                if (item.Word.Length == l)
                    wordSet.Insert(item.Word);
                item = item.Next;
            }
            return wordSet;
        }
        
        public WordSet[] VowelDivide()
        {
            var vowelList = new WordSet();
            var consonantList = new WordSet();
            var item = Head;

            while (item != null)
            {
                if ("аеёиоуыэюяaeiouy".Contains(item.Word[0].ToString().ToLower()))
                    vowelList.Insert(item.Word);
                else consonantList.Insert(item.Word);
                item = item.Next;
            }
            return new[] { consonantList, vowelList };
        }
        
        public void RemovePalindrom()
        {
            var item = Head;

            while (item != null)
            {
                if (CheckPalindrom(item.Word)) 
                    Delete(item.Word);
                item = item.Next;
            }
        }

        public void ShowWordSet()
        {
            ExtraMethods.ShowWordSet(this);
        }
    }
}