namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
               
                string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
                string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
                string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
                string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
                string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
                string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };

                int knownWords = 0;
                string title = "Adam Asmaca";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(title);
                Console.ResetColor();

                string category = "Kategori Seçiniz: ";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(category);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Harf Giriniz: ");
                string harfGirdisi = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine();
                Console.Clear();
                Console.WriteLine(knownWords);
                Console.WriteLine("Anasayfaya dönmek için enter'a basın");
                Console.ReadLine();


            }

        }
        
    }
}