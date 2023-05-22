using static System.Formats.Asn1.AsnWriter;

namespace Hangman
{
    internal class Program
    {
        static int extraPoint = 100;
        static int knownWords = 0;
        static int wrongAnsver = 0;
        static int wordCompletion = 0;
        static int score = 0;
        static string questionWord;
        static char questionLetter;
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
                int wrongAnsver = 0;
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
                Console.WriteLine();

                char[] harfler = {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M',
                'N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z'};

                for (int harf = 0; harf < harfler.Length; harf++)
                {
                    Console.Write("{0}  ", harfler[harf]);
                    if (harf == harfler.Length / 2)
                        Console.WriteLine();
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Harf Giriniz: ");
                string harfGirdisi = Console.ReadLine();
                Console.ResetColor();

                Correctguess(harfGirdisi);



                Draw(wrongAnsver);

                Console.WriteLine();
                Console.Clear();
                Console.WriteLine(knownWords);
                Console.WriteLine("Oyun Bitti");
                Console.WriteLine("Anasayfaya dönmek için enter'a basın");
                Console.ReadLine();




            }

        }
        
        static string[] GetAppearance(int wrongAnsver)
        {
                    string[] Begingame =
            {
        "     X X X X X X 	",
        "     X         X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "              XXX "
    };
                    string[] Wrong1 =
            {
        "     X X X X X X 	",
        "     X         X	",
        "   X X X       X	",
        "  X     X      X	",
        "  X     X      X	",
        "  X     X      X	",
        "   X X X       X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "               X	",
        "              XXX "
    };
                    string[] Wrong2 =
            {
        "     X X X X X X 	",
        "     X         X	",
        "   X X X       X	",
        "  X     X      X	",
        "  X     X      X	",
        "  X     X      X	",
        "   X X X       X	",
        "     X         X	",
        "     X         X	",
        "     X         X	",
        "     X         X	",
        "     X         X	",
        "     X         X	",
        "               X	",
        "               X	",
        "              XXX "
    };
                    string[] Wrong3 =
            {
        "     X X X X X X 	",
        "     X         X	",
        "   X X X       X	",
        "  X     X      X	",
        "  X     X      X	",
        "  X     X      X	",
        "   X X X       X	",
        "     X         X	",
        "   X X         X	",
        " X   X         X	",
        "X    X         X	",
        "     X         X	",
        "     X         X	",
        "               X	",
        "               X	",
        "              XXX"
    };
                    string[] Wrong4 =
            {
        "     X X X X X X 	",
        "     X         X	",
        "   X X X       X	",
        "  X     X      X	",
        "  X     X      X	",
        "  X     X      X	",
        "   X X X       X	",
        "     X         X	",
        "   X X X       X	",
        " X   X   X     X	",
        "X    X     X   X	",
        "     X         X	",
        "     X         X	",
        "               X	",
        "               X	",
        "              XXX "
    };
                    string[] Wrong5 =
            {
        "     X X X X X X 	",
        "     X         X	",
        "   X X X       X	",
        "  X     X      X	",
        "  X     X      X	",
        "  X     X      X	",
        "   X X X       X	",
        "     X         X	",
        "   X X X       X	",
        " X   X   X     X	",
        "X    X     X   X	",
        "     X         X	",
        "   X X         X	",
        " X             X	",
        "X              X	",
        "              XXX "
    };
                    string[] Wrong6 =
            {
        "     X X X X X X 	",
        "     X         X	",
        "   X X X       X	",
        "  X     X      X	",
        "  X     X      X	",
        "  X     X      X	",
        "   X X X       X	",
        "     X         X	",
        "   X X X       X	",
        " X   X   X     X	",
        "X    X     X   X	",
        "     X         X	",
        "   X X X       X	",
        " X       X     X	",
        "X          X   X	",
        "              XXX "
    };

                         if (wrongAnsver == 1) { return Wrong1; Console.Beep(2000, 2000); } 
                    else if (wrongAnsver == 2) { return Wrong2; Console.Beep(2000, 2000); } 
                    else if (wrongAnsver == 3) { return Wrong3; Console.Beep(2000, 2000); } 
                    else if (wrongAnsver == 4) { return Wrong4; Console.Beep(2000, 2000); } 
                    else if (wrongAnsver == 5) { return Wrong5; Console.Beep(2000, 2000); } 
                    else if (wrongAnsver == 6) { return Wrong6; Console.Beep(2000, 2000); }
                    else return Begingame;
            
        }
        static void Draw(int a)
        {
            string[] appearance = GetAppearance(wrongAnsver);

            for (int i = 0; i < appearance.Length; i++)
            {
                Console.WriteLine(appearance[i]);
            }
        }
        static void ExtraPoint()
        {
            if (knownWords == questionWord.Length)  // eğer bilinen harf sayısı soru kelimesinin uzunluk değerine eşit ise
            {
                wordCompletion = score + extraPoint;// kelime tamamlanma değişkenine 
                wrongAnsver = 0;                    // extra puan  ve puan hanesi eklenir 
            }                                       // yanlış cevap değişkeni 0 olur

        }
        static void Correctguess(string harfGirdisi)
        {
            char questionLetter = char.Parse(harfGirdisi);

            for (int i = 0; i < questionWord.Length; i++)   // soru kelimesi dizisinin harfleri içersinde girilen harf aratılır. 
            {
                if (questionLetter == questionWord[i])
                {
                    knownWords++; //      eğer varise bilinen harf puanı bir artar.
                }                 
                else wrongAnsver++; //yoksa yanlış cevap puanı 1 artar
                ExtraPoint();
            }
        }
    }
