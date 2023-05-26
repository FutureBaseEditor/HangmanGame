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
               
                char[] harfler = {'A','B','C','D','E','F','G','Ğ','H','I','İ','J','K','L','M',
                'N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z'};

                for (int harf = 0; harf < harfler.Length; harf++)
                {
                    Console.Write("{0}  ", harfler[harf]);
                    if (harf == harfler.Length / 2)
                        Console.WriteLine();
                }
                Console.WriteLine();

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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nlütfen 1 ile 5 arasında bir kategori seçiniz: ");
                Console.ForegroundColor = ConsoleColor.Red;
                int category=int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ResetColor();
                Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Blue;
                string secim = 
                 (category == 1) ? "Seçiminiz "+kategoriler[0]+" kategorisidir" :
                 (category == 2) ? "Seçiminiz "+kategoriler[1]+"  kategorisidir" :
                 (category == 3) ? "Seçiminiz "+kategoriler[2]+"  kategorisidir" :
                 (category == 4) ? "Seçiminiz "+kategoriler[3]+" kategorisidir" :
                 (category == 5) ? "Seçiminiz "+kategoriler[4]+" kategorisidir" : " seçiminiz 1 ile 5 arasında olmalıdır";
                Console.WriteLine(secim);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Harf Giriniz: ");
                string harfGirdisi = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine();
                Console.Clear();
                Console.WriteLine(knownWords);
                Console.WriteLine("Oyun Bitti");
                Console.WriteLine("Anasayfaya dönmek için enter'a basın");
                Console.ReadLine();


            }

        }
        
    }
}