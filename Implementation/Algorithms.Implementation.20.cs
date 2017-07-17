using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        string[] h_temp = "1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 7".Split(' ');//Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp, Int32.Parse);
        string word = "zaba";//Console.ReadLine();
        Dictionary<char, int> mappedChar = Mapping(h);
        char[] character = word.ToCharArray();
        int width = character.Length;
        int height = mappedChar.Where(x => character.Contains(x.Key)).Select(x => x.Value).Max();
        Console.WriteLine(width * height);
        Console.Read();
    }

    static Dictionary<char, int> Mapping(int[] a)
    {
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        char[] characters = alphabets.ToCharArray();
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int i = 0; i < characters.Length; i++)
        {
            map.Add(characters[i], a[i]);
        }
        return map;
    }
}
