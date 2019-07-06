using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string conversionWords = "Hello world today will be amazing";
            string[] sentence = conversionWords.Split(' ');

            
            string translation = "";
            string beginningLetter;
            string wordBody;
            string space = " ";
            

            foreach (string word in conversionWords.Split())
            {
                beginningLetter = word.Substring(0, 1);
                wordBody = word.Substring(1, word.Length - 1);
                translation = translation + wordBody + beginningLetter + "ay" + space;


            }

            Console.WriteLine(translation.ToString());
            
        }
    }
}
