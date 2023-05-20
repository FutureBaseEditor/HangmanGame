namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };

            string title = "Adam Asmaca";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Harf Giriniz: ");
            string harfGirdisi = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine();
            Console.Clear();

            char[] harfler = {'A', ' ', 'B', ' ', 'C', ' ', 'D', ' ', 'E', ' ', 'F', ' ', 'G', ' ','Ğ',' ', 'H', ' ', 'I', ' ', 'İ', ' ', 'J', ' ', 'K', ' ', 'L', ' ', 'M', ' ',
                'N', ' ','O', ' ','Ö', ' ','P', ' ','R', ' ', 'S', ' ', 'Ş',' ','T', ' ', 'U', ' ', 'Ü', ' ', 'V', ' ', 'Y', ' ','Z',' '};

            for (int harf = 0; harf < harfler.Length; harf++)
            {
                Console.Write("{0}", harfler[harf]);
                if (harf == harfler.Length / 2)
                    Console.WriteLine();
            }



        }
    }
      
}
    

    
