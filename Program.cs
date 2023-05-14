namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman Game");

            char harf[] = {'a','b' };  //diyelim ki böyle bir dizi oluşturduk
            char selectedLetter = 'a' ;// seçilen harf için bu değişkene atadık
            for (int i = 0; i < harf[i].length; i++)
            {
                if (selectedLetter == harf[i])Console.Write(" "); 
            // seçilen harf x[i] harf dizisindeki harflerden i index numarasına sahip harfe eşit ise;
            }



        }
    }
}