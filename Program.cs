namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string [] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string [] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string [] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string [] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string [] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };
           
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

            Random rastgele = new Random();
            string harf;
            Console.WriteLine("1.hayvanlar\n2.ulkeler\n3.meslekler\n4.yemekler\n5.sporlar");
            Console.Write("Hangi kategoriden kelime seçmek istersiniz?");
            int kategori = int.Parse(Console.ReadLine());

            string[] secim;
            Console.Write("Bir harf tahmini yapın: ");
            harf = Console.ReadLine().ToUpper();

            int harfTahminSayisi = 0;
            switch (kategori)
            {
                case 1:
                    secim = hayvanlar;
                    break;
                case 2:
                    secim = ulkeler;
                    break;
                case 3:
                    secim = meslekler;
                    break;
                case 4:
                    secim = yemekler;
                    break;
                case 5:
                    secim = sporlar;
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    return;
            }

            string kelime = secim[rastgele.Next(secim.Length)].ToUpper();

            string[] tahminDizisi = new string[kelime.Length];
            for (int i = 0; i < tahminDizisi.Length; i++)
            {
                tahminDizisi[i] = "_";
            }
            //Console.WriteLine("Kelime: " + string.Join(" ", tahminDizisi));

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == harf[0])
                {
                    tahminDizisi[i] = harf;
                }

            }
            Console.WriteLine("Kelime: " + string.Join(" ", tahminDizisi));
            harfTahminSayisi++;

        }
        
    }
}