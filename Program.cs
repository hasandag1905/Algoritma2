using System.Runtime.InteropServices;

namespace Algoritma2
{
    class Program
    {
        static void Main(){
            Console.WriteLine("Stringi giriniz:");
            string input= Console.ReadLine();
            string[]words=input.Split(' ');
            

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = SwapCharacters(words[i]);
            }

             string result = String.Join(" ", words);
             Console.WriteLine(result);
        }

        static string SwapCharacters(string word){
            if (word.Length<=1)
            return word;
            char[] chars= word.ToCharArray();
            for (int i = 1; i < chars.Length; i+=1)
            {
                char temp = chars[i];
                chars[i] = chars[i - 1];
                chars[i-1]= temp;
            }
            return new string (chars);
        }
    }
}

/*
using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bir string alın
        Console.WriteLine("Bir string girin:");
        string input = Console.ReadLine();

        // Stringi boşluk karakterine göre ayırarak kelimelere böl
        string[] words = input.Split(' ');

        // Her kelimeyi işleyerek karakterlerini değiştir
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = SwapAdjacentCharacters(words[i]);
        }

        // Sonuçları birleştir ve ekrana yazdır
        string result = string.Join(" ", words);
        Console.WriteLine("Sonuç: " + result);
    }

    static string SwapAdjacentCharacters(string word)
    {
        // Eğer kelime tek karakterse veya boşsa, değişiklik yapılmaz
        if (word.Length <= 1)
            return word;

        char[] chars = word.ToCharArray();

        // Karakterleri bir önceki karakter ile yer değiştir
        for (int i = 1; i < chars.Length; i ++)
        {
            
            
            char temp = chars[i];
            chars[i] = chars[i - 1];
            chars[i - 1] = temp;
        
        }

        return new string(chars);
    }
}
*/