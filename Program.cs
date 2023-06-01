namespace Hangman
{
    internal class Program
    {
        static char[] harfler = {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M',
                'N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z'};
        static void Main(string[] args)
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
               

                for (int i = 0; i < kategoriler.Length; i++)
                {
                    //Console.WriteLine(kategoriler[i]);

                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i + 1 + "-" + kategoriler[i] + " ");
                    }
                    else
                        Console.Write(i + 1 + "-" + kategoriler[i] + " ");

                }
                Console.WriteLine();
                string category = "Kategori Seçiniz: ";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(category);
                Console.ResetColor();
                Console.ReadLine();

            char[] harfler = {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M',
                'N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z'};

                for (int harf = 0; harf < harfler.Length; harf++)
                {
                    Console.Write("{0}  ", harfler[harf]);
                    if (harf == harfler.Length / 2)
                        Console.WriteLine();
                }

            while (true)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Harf Giriniz: ");
                ConsoleKeyInfo harfGirdisi = Console.ReadKey();
                Console.ResetColor();

                char harfGir = char.ToUpper(harfGirdisi.KeyChar);
                Console.WriteLine();

                for (int harf = 0; harf < harfler.Length; harf++)
                {
                    if (harfGir == harfler[harf])
                        harfler[harf] = ' ';
                    Console.Write("{0}  ", harfler[harf]);

                    if (harf == harfler.Length / 2)
                        Console.WriteLine();
                }
                //Console.Clear();
                //Console.WriteLine(knownWords);
                //Console.WriteLine("Oyun Bitti");
                //Console.WriteLine("Anasayfaya dönmek için enter'a basın");
                //Console.ReadLine();


            }
        }
    }
}