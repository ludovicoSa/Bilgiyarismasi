using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bilgiiii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 0;
            string s1 = ("Aşağıdakilerden hangisi doğal ışık kaynağı değildir ?");
            string s2 = ("Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir?");
            string s3 = ("Üç Büyük Dince Kutsal Sayılan Şehir Hangisidir?");
            string s4 = ("Pirinç hangi ürünün kabuğunun soyulması ile elde edilir?");
            string a1 = ("Milli mücadele döneminde işgallere karşı direnen düzensiz birliklerin adı nedir?");
            string a2 = ("Hangisi vücudumuzdaki kemik türlerinden değildir?");
            string a3 = ("Gezilerini ‘Seyahatname’ adlı eserde toplayan Türk gezgin kimdir?");
            string a4 = ("İstanbul hangi coğrafi bölgemizde yer almaktadır?");
            string b1 = ("En büyük uydusu olan gezegen aşağıdakilerden hangisidir?");
            string b2 = ("Mercekler ışığın hangi özelliği kullanılarak yapılmıştır?");
            string b3 = ("Uçaklarda pilot kabinine ne ad verilir?");
            string b4 = ("Ses en hızlı hangi ortamda yayılır?");
            string c1 = ("Galatasaray hangi yıl UEFA kupasını almıştır?");
            string c2 = ("Hangisi bir hücrede bulunan organeldir?");
            string c3 = ("-Türk ordusunun ve Türk Kara Kuvvetlerinin kuruluşu hangi yıl kabul edilir?");
            string c4 = ("İstiklal Marşı hangi yıl yazılmıştır?");
            string z1 = ("Türkiye'de kaç tane coğrafi bölge var?");
            string z2 = ("Rumeli hisarını hangi padişah yaptırmıştır?");
            string z3 = ("Hangisi tarihteki Türk devletlerinden biri değildir?");
            string z4 = ("Kıbrıs Barış harekatı hangi tarihte gerçekleşmiştir?");
            string n1 = ("Osmanlı’da Lale devri hangi padişah döneminde yaşamıştır?");
            string n2 = ("Hangisi Kurtuluş Savaşı sırasında gerçekleşmiştir?");
            string n3 = ("Güneş Sistemi'nin en sıcak gezegeni hangisidir?");
            string n4 = ("Dünya üzerinde bilinen en derin nokta aşağıdakilerden hangisidir?");
            string q1 = ("Dünyanın en fazla 1000 yıllık bir ömrü kaldığı teorisinin öne süren Kıyamet teorisi kime aittir?");
            string q2 = ("\"Sorgulanmamış bir hayat, yaşanmaya değmez.\" sözü kime aittir?");
            string q3 = ("İzafiyet teorisi kime aittir?");
            string q4 = ("Parapsikoloji görüş olan beden ile ruhun bir süreliğine ayrıldığına inanılan yöntem nedir?");
            string d1 = ("6 ayda yaklaşık 7164 kilometre yol gidip dünyanın en büyük GPS çizimini yaparak Guinness Dünya Rekorlarına giren Yasuşi Takahani'nin bu çizimle yazdığı cümlenin Türkçe çevirisi hangisidir?\r\n\r\n");
            string d2 = ("Hangisi \"kesinlikle\" anlamına gelmez?\"");
            string d3 = ("Hangisi TDK sözlüklerinde tanımı olan bir ifade değildir?");
            string d4 = ("ABD New York'taki Özgürlük Heykeli bir elinde meşale tutarken diğer elinde ne tutar?");
            string y1 = ("Bitkilerin sap ve dallarını öğütmek veya fındığın dış kabuğunu ayırmak için kullanılan, harman işini yapan makineye ne ad verilir?");
            string y2 = ("Al Pease, Formula 1 tarihinde, hangi sebepten dolayı yarışmadan diskalifiye edilen ilk ve tek sporcudur?");
            string y3 = ("Türkiyede ki herkes kendi memleketinde yaşamaya devam etseydi,en kalabalık şehrimiz hangisi olurdu?");
            string y4 = ("Psikolojik bir işkence yöntemi olarak geçen \"Ludovico\" hangi kitapta geçmektedir?");
            string m1 = ("Hangi ülkede bir evin kapısını tıklatıp kaçmak suçtur?");
            string m2 = ("\"Atatürk'ün Samsun'a çıktığı gün\" doğan bir bebek Türkiye'de cumhuriyet ilan edildiğinde kaç aylıktır?");
            string m3 = ("5 makinenin 5 cihaz üretmesi 5 dakika sürüyorsa 100 makinenin 100 cihaz üretmesi ne kadar sürer?\r\n");
            string m4 = ("Cebelitarık Boğazı hangi ikisini birbirinden ayırır?");

            while (true)
            {
                Console.WriteLine("Kim milyoner yarışmasına hoşgeldiniz!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yarışmaya hazır mısınız ?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Evet veya hayır");
                string ask = Console.ReadLine();

                if (ask == "evet" || ask == "Evet")
                {
                    Console.WriteLine("1.Soru geliyor");
                    SoundPlayer soruilk = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\ilksoru.wav");
                    soruilk.Play();
                    string[] sorular = { s1, s2, s3, s4 };
                    Random rastgelekolay = new Random();
                    int kolay;
                    kolay = rastgelekolay.Next(0, sorular.Length);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sorular[kolay]);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (kolay == 0)
                    {
                        Console.WriteLine("A)Güneş");
                        Console.WriteLine("B)Mum");
                        Console.WriteLine("C)Ateş Böceği");
                        Console.WriteLine("D)Şimşek");
                        string ask2 = Console.ReadLine();
                        if (ask2 == "B" || ask2 == "b")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                            Console.WriteLine("500TL KAZANDINIZ");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                            dogru.Play();
                            bakiye = bakiye + 500;
                        }
                        if (ask2 == "D" || ask2 == "d" || ask2 == "a" || ask2 == "A" || ask2 == "C" || ask2 == "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Doğru Cevap:B idi");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                            yanlis.Play();
                            continue;
                        }
                    }
                    if (kolay == 1)
                    {
                        Console.WriteLine("A)Hititler");
                        Console.WriteLine("B)Elamlar");
                        Console.WriteLine("C)Sümerler");
                        Console.WriteLine("D)Urartular");
                        string ask3 = Console.ReadLine();
                        if (ask3 == "C" || ask3 == "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                            Console.WriteLine("500TL KAZANDINIZ");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                            dogru.Play();
                            bakiye = bakiye + 500;
                        }
                        if (ask3 == "D" || ask3 == "d" || ask3 == "a" || ask3 == "A" || ask3 == "B" || ask3 == "b")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Doğru Cevap:C idi");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                            yanlis.Play();
                            continue;
                        }
                    }
                    if (kolay == 2)
                    {
                        Console.WriteLine("A)Mekke");
                        Console.WriteLine("B)Kudüs");
                        Console.WriteLine("C)Roma");
                        Console.WriteLine("D)İstanbul");
                        string ask4 = Console.ReadLine();
                        if (ask4 == "B" || ask4 == "b")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                            Console.WriteLine("500TL KAZANDINIZ");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                            dogru.Play();
                            bakiye = bakiye + 500;
                        }
                        if (ask4 == "D" || ask4 == "d" || ask4 == "a" || ask4 == "A" || ask4 == "C" || ask4 == "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Doğru Cevap:B idi");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                            yanlis.Play();
                            continue;
                        }

                    }
                    if (kolay == 3)
                    {
                        Console.WriteLine("A)Yulaf");
                        Console.WriteLine("B)Çeltik");
                        Console.WriteLine("C)Ayçiçeği");
                        Console.WriteLine("D)Buğday");
                        string ask5 = Console.ReadLine();
                        if (ask5 == "B" || ask5 == "b")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                            Console.WriteLine("500TL KAZANDINIZ");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                            dogru.Play();
                            bakiye = bakiye + 500;
                        }
                        if (ask5 == "D" || ask5 == "d" || ask5 == "a" || ask5 == "A" || ask5 == "C" || ask5 == "c")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Doğru Cevap:B idi");
                            Console.ForegroundColor = ConsoleColor.White;
                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                            yanlis.Play();
                            continue;
                        }


                    }
                    Console.WriteLine("2.soru için Hazır mısınız");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Mevcut Bakiye=" + bakiye);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Evet veya hayır");
                    string sad = Console.ReadLine();
                    if (sad == "evet" || sad == "Evet")
                    {
                        SoundPlayer soruhep = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                        soruhep.Play();
                        string[] sorular1 = { a1, a2, a3, a4 };
                        Random rastgelekolay1 = new Random();
                        int kolay1;
                        kolay1 = rastgelekolay1.Next(0, sorular1.Length);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(sorular1[kolay1]);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (kolay1 == 0)
                        {
                            Console.WriteLine("A)Kuvâ-yi Milliye");
                            Console.WriteLine("B)Tekâlif-i Milliye");
                            Console.WriteLine("C)Tulumbacı Ocağı");
                            Console.WriteLine("D)Yeniçerililer");
                            string ask6 = Console.ReadLine();
                            if (ask6 == "A" || ask6 == "a")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                Console.WriteLine("2000TL KAZANDINIZ");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                dogru.Play();
                                bakiye = bakiye + 2000;
                            }
                            if (ask6 == "D" || ask6 == "d" || ask6 == "C" || ask6 == "b" || ask6 == "B" || ask6 == "c")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Doğru Cevap:A idi");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                yanlis.Play();
                                continue;
                            }
                        }
                        if (kolay1 == 1)
                        {
                            Console.WriteLine("A)Sert");
                            Console.WriteLine("B)Yassı");
                            Console.WriteLine("C)Uzun");
                            Console.WriteLine("D)Kısa");
                            string ask7 = Console.ReadLine();
                            if (ask7 == "A" || ask7 == "a")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                Console.WriteLine("2000TL KAZANDINIZ");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                dogru.Play();
                                bakiye = bakiye + 2000;
                            }
                            if (ask7 == "D" || ask7 == "d" || ask7 == "C" || ask7 == "b" || ask7 == "B" || ask7 == "c")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Doğru Cevap:A idi");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                yanlis.Play();
                                continue;
                            }
                        }
                        if (kolay1 == 2)
                        {
                            Console.WriteLine("A)Evliya çelebi");
                            Console.WriteLine("B)Katip Çelebi");
                            Console.WriteLine("C)Namık kemal");
                            Console.WriteLine("D)Mevlana");
                            string ask8 = Console.ReadLine();
                            if (ask8 == "A" || ask8 == "a")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                Console.WriteLine("2000TL KAZANDINIZ");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                dogru.Play();
                                bakiye = bakiye + 2000;
                            }
                            if (ask8 == "D" || ask8 == "d" || ask8 == "C" || ask8 == "b" || ask8 == "B" || ask8 == "c")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Doğru Cevap:A idi");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                yanlis.Play();
                                continue;
                            }
                        }
                        if (kolay1 == 3)
                        {
                            Console.WriteLine("A)Ege bölgesi");
                            Console.WriteLine("B)Marmara bölgesi");
                            Console.WriteLine("C)Karadeniz bölgesi");
                            Console.WriteLine("D)İç anadolu");
                            string ask8 = Console.ReadLine();
                            if (ask8 == "B" || ask8 == "b")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                Console.WriteLine("2000TL KAZANDINIZ");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                dogru.Play();
                                bakiye = bakiye + 2000;
                            }
                            if (ask8 == "D" || ask8 == "d" || ask8 == "C" || ask8 == "a" || ask8 == "A" || ask8 == "c")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Doğru Cevap:B idi");
                                Console.ForegroundColor = ConsoleColor.White;
                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                yanlis.Play();
                                continue;
                            }
                        }
                        Console.WriteLine("3.soru için Hazır mısınız");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Mevcut Bakiye=" + bakiye);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Evet veya hayır");
                        string sad1 = Console.ReadLine();
                        if (sad1 == "evet" || sad1 == "Evet")
                        {
                            SoundPlayer soruhep1 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                            soruhep1.Play();
                            string[] sorular2 = { b1, b2, b3, b4 };
                            Random rastgelekolay2 = new Random();
                            int kolay2;
                            kolay2 = rastgelekolay2.Next(0, sorular2.Length);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(sorular2[kolay2]);
                            Console.ForegroundColor = ConsoleColor.White;
                            if (kolay2 == 0)
                            {
                                Console.WriteLine("A)Merkür");
                                Console.WriteLine("B)Mars");
                                Console.WriteLine("C)Dünya");
                                Console.WriteLine("D)Jüpiter");
                                string ask9 = Console.ReadLine();
                                if (ask9 == "D" || ask9 == "d")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                    Console.WriteLine("5000TL KAZANDINIZ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                    dogru.Play();
                                    bakiye = bakiye + 5000;
                                }
                                if (ask9 == "B" || ask9 == "b" || ask9 == "C" || ask9 == "a" || ask9 == "A" || ask9 == "c")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Doğru Cevap:D idi");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                    yanlis.Play();
                                    continue;
                                }
                            }
                            if (kolay2 == 1)
                            {
                                Console.WriteLine("A)Yansıma");
                                Console.WriteLine("B)Kırılma");
                                Console.WriteLine("C)Yayılma");
                                Console.WriteLine("D)Dalga");
                                string ask10 = Console.ReadLine();
                                if (ask10 == "B" || ask10 == "b")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                    Console.WriteLine("5000TL KAZANDINIZ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                    dogru.Play();
                                    bakiye = bakiye + 5000;
                                }
                                if (ask10 == "D" || ask10 == "d" || ask10 == "C" || ask10 == "a" || ask10 == "A" || ask10 == "c")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Doğru Cevap:B idi");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                    yanlis.Play();
                                    continue;
                                }
                            }
                            if (kolay2 == 2)
                            {
                                Console.WriteLine("A)Kabin");
                                Console.WriteLine("B)Pilot");
                                Console.WriteLine("C)Muavin");
                                Console.WriteLine("D)Kokpit");
                                string ask11 = Console.ReadLine();
                                if (ask11 == "D" || ask11 == "d")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                    Console.WriteLine("5000TL KAZANDINIZ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                    dogru.Play();
                                    bakiye = bakiye + 5000;
                                }
                                if (ask11 == "B" || ask11 == "b" || ask11 == "C" || ask11 == "a" || ask11 == "A" || ask11 == "c")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Doğru Cevap:D idi");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                    yanlis.Play();
                                    continue;
                                }
                            }
                            if (kolay2 == 3)
                            {
                                Console.WriteLine("A)Katı");
                                Console.WriteLine("B)Sıvı");
                                Console.WriteLine("C)Gaz");
                                Console.WriteLine("D)Plazma");
                                string ask12 = Console.ReadLine();
                                if (ask12 == "A" || ask12 == "a")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                    Console.WriteLine("5000TL KAZANDINIZ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                    dogru.Play();
                                    bakiye = bakiye + 5000;
                                }
                                if (ask12 == "B" || ask12 == "b" || ask12 == "C" || ask12 == "d" || ask12 == "D" || ask12 == "c")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Doğru Cevap:A idi");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                    yanlis.Play();
                                    continue;
                                }
                            }
                            Console.WriteLine("4.soru için Hazır mısınız");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Mevcut Bakiye=" + bakiye);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Evet veya hayır");
                            string sad2 = Console.ReadLine();
                            if (sad2 == "evet" || sad2 == "Evet")
                            {
                                SoundPlayer soruhep2 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                soruhep2.Play();
                                string[] sorular3 = { c1, c2, c3, c4 };
                                Random rastgelekolay3 = new Random();
                                int kolay3;
                                kolay3 = rastgelekolay3.Next(0, sorular3.Length);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(sorular3[kolay3]);
                                Console.ForegroundColor = ConsoleColor.White;
                                if (kolay3 == 0)
                                {
                                    Console.WriteLine("A)2001");
                                    Console.WriteLine("B)2000");
                                    Console.WriteLine("C)2003");
                                    Console.WriteLine("D)2004");
                                    string ask13 = Console.ReadLine();
                                    if (ask13 == "B" || ask13 == "b")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                        Console.WriteLine("7.500TL KAZANDINIZ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                        dogru.Play();
                                        bakiye = bakiye + 7500;
                                    }
                                    if (ask13 == "D" || ask13 == "d" || ask13 == "C" || ask13 == "a" || ask13 == "A" || ask13 == "c")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("Doğru Cevap:B idi");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                        yanlis.Play();
                                        continue;
                                    }
                                }
                                if (kolay3 == 1)
                                {
                                    Console.WriteLine("A)Lizozom");
                                    Console.WriteLine("B)RNA");
                                    Console.WriteLine("C)DNA");
                                    Console.WriteLine("D)Hücre Duvarı");
                                    string ask14 = Console.ReadLine();
                                    if (ask14 == "a" || ask14 == "A")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                        Console.WriteLine("7.500TL KAZANDINIZ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                        dogru.Play();
                                        bakiye = bakiye + 7500;
                                    }
                                    if (ask14 == "D" || ask14 == "d" || ask14 == "C" || ask14 == "B" || ask14 == "c" || ask14 == "b")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("Doğru Cevap:A idi");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                        yanlis.Play();
                                        continue;
                                    }
                                }
                                if (kolay3 == 2)
                                {
                                    Console.WriteLine("A)M.Ö.209");
                                    Console.WriteLine("B)1071");
                                    Console.WriteLine("C)1919");
                                    Console.WriteLine("D)2023");
                                    string ask15 = Console.ReadLine();
                                    if (ask15 == "a" || ask15 == "A")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                        Console.WriteLine("7.500TL KAZANDINIZ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                        dogru.Play();
                                        bakiye = bakiye + 7500;
                                    }
                                    if (ask15 == "D" || ask15 == "d" || ask15 == "C" || ask15 == "B" || ask15 == "c" || ask15 == "b")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("Doğru Cevap:A idi");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                        yanlis.Play();
                                        continue;
                                    }
                                }
                                if (kolay3 == 3)
                                {
                                    Console.WriteLine("A)1922");
                                    Console.WriteLine("B)1920");
                                    Console.WriteLine("C)1919");
                                    Console.WriteLine("D)1921");
                                    string ask16 = Console.ReadLine();
                                    if (ask16 == "D" || ask16 == "d")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                        Console.WriteLine("7.500TL KAZANDINIZ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                        dogru.Play();
                                        bakiye = bakiye + 7500;
                                    }
                                    if (ask16 == "B" || ask16 == "b" || ask16 == "C" || ask16 == "a" || ask16 == "c" || ask16 == "A")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("Doğru Cevap:D idi");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                        yanlis.Play();
                                        continue;
                                    }
                                }
                            Console.WriteLine("5.soru için ve ZOR bölüm için Hazır mısınız");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Mevcut Bakiye=" + bakiye);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Evet veya hayır");
                            string sad3 = Console.ReadLine();
                            if (sad3 == "evet" || sad3 == "Evet")
                                {
                                    SoundPlayer soruhep3 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                    soruhep3.Play();
                                    string[] sorular4 = { z1, z2, z3, z4 };
                                    Random rastgelekolay4 = new Random();
                                    int kolay4;
                                    kolay4 = rastgelekolay4.Next(0, sorular4.Length);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(sorular4[kolay4]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if (kolay4 == 0)
                                    {
                                        Console.WriteLine("A)7");
                                        Console.WriteLine("B)6");
                                        Console.WriteLine("C)4");
                                        Console.WriteLine("D)5");
                                        string ask17 = Console.ReadLine();
                                        if (ask17 == "a" || ask17 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("15.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 15000;
                                        }
                                        if (ask17 == "D" || ask17 == "d" || ask17 == "C" || ask17 == "B" || ask17 == "c" || ask17 == "b")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:A idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    if (kolay4 == 1)
                                    {
                                        Console.WriteLine("A)II. Abdülhamid");
                                        Console.WriteLine("B)Fatih Sultan Mehmet");
                                        Console.WriteLine("C)Kanuni Sultan Süleyman");
                                        Console.WriteLine("D)III.Selim");
                                        string ask18 = Console.ReadLine();
                                        if (ask18 == "b" || ask18 == "B")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("15.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 15000;
                                        }
                                        if (ask18 == "D" || ask18 == "d" || ask18 == "C" || ask18 == "a" || ask18 == "c" || ask18 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:B idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    if (kolay4 == 2)
                                    {
                                        Console.WriteLine("A)Emevi Devleti");
                                        Console.WriteLine("B)Avar Kağanlığı");
                                        Console.WriteLine("C)Hun İmparatorluğu");
                                        Console.WriteLine("D)Türk boyu");
                                        string ask19 = Console.ReadLine();
                                        if (ask19 == "a" || ask19 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("15.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 15000;
                                        }
                                        if (ask19 == "D" || ask19 == "d" || ask19 == "C" || ask19 == "B" || ask19 == "c" || ask19 == "b")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:A idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    if (kolay4 == 3)
                                    {
                                        Console.WriteLine("A)1970");
                                        Console.WriteLine("B)1972");
                                        Console.WriteLine("C)1974");
                                        Console.WriteLine("D)1975");
                                        string ask20 = Console.ReadLine();
                                        if (ask20 == "c" || ask20 == "C")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("15.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 15000;
                                        }
                                        if (ask20 == "D" || ask20 == "d" || ask20 == "A" || ask20 == "B" || ask20 == "a" || ask20 == "b")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:A idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                }
                                Console.WriteLine("6.soru için Hazır mısınız");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Mevcut Bakiye" + bakiye);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Evet veya hayır");
                                string sad4 = Console.ReadLine();
                                if (sad4 == "evet" || sad4 == "Evet")
                                {
                                    SoundPlayer soruhep3 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                    soruhep3.Play();
                                    string[] sorular5 = { n1, n2, n3, n4 };
                                    Random rastgelekolay5 = new Random();
                                    int kolay5;
                                    kolay5 = rastgelekolay5.Next(0, sorular5.Length);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(sorular5[kolay5]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    if (kolay5 == 0)
                                    {
                                        Console.WriteLine("A)IV.Murat");
                                        Console.WriteLine("B)III.Ahmet");
                                        Console.WriteLine("C)III.Selim");
                                        Console.WriteLine("D)I.Osman");
                                        string ask21 = Console.ReadLine();
                                        if (ask21 == "b" || ask21 == "B")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("30.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 30000;
                                        }
                                        if (ask21 == "D" || ask21 == "d" || ask21 == "C" || ask21 == "a" || ask21 == "c" || ask21 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:B idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    if (kolay5 == 1)
                                    {
                                        Console.WriteLine("A)Kut'ul Amare Zaferi");
                                        Console.WriteLine("B)İnönü Zaferi");
                                        Console.WriteLine("C)Çanakkale Zaferi");
                                        Console.WriteLine("D)Bâb-ı Âli Baskını");
                                        string ask22 = Console.ReadLine();
                                        if (ask22 == "b" || ask22 == "B")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("30.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 30000;
                                        }
                                        if (ask22 == "D" || ask22 == "d" || ask22 == "C" || ask22 == "a" || ask22 == "c" || ask22 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:B idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    if (kolay5 == 2)
                                    {
                                        Console.WriteLine("A)Merkür");
                                        Console.WriteLine("B)Satürn");
                                        Console.WriteLine("C)Venüs");
                                        Console.WriteLine("D)Jüpiter");
                                        string ask23 = Console.ReadLine();
                                        if (ask23 == "C" || ask23 == "c")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("30.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 30000;
                                        }
                                        if (ask23 == "D" || ask23 == "d" || ask23 == "B" || ask23 == "a" || ask23 == "b" || ask23 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:C idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    if (kolay5 == 3)
                                    {
                                        Console.WriteLine("A)Fidel Çukuru");
                                        Console.WriteLine("B)Donald Çukuru");
                                        Console.WriteLine("C)Mariana Çukuru");
                                        Console.WriteLine("D)Alesa Çukuru");
                                        string ask24 = Console.ReadLine();
                                        if (ask24 == "C" || ask24 == "c")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                            Console.WriteLine("30.000TL KAZANDINIZ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                            dogru.Play();
                                            bakiye = bakiye + 30000;
                                        }
                                        if (ask24 == "D" || ask24 == "d" || ask24 == "B" || ask24 == "a" || ask24 == "b" || ask24 == "A")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("Doğru Cevap:C idi");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                            yanlis.Play();
                                            continue;
                                        }
                                    }
                                    Console.WriteLine("7.soru için Hazır mısınız");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Mevcut Bakiye" + bakiye);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Evet veya hayır");
                                    string sad5 = Console.ReadLine();
                                    if (sad5 == "evet" || sad5 == "Evet")
                                    {
                                        SoundPlayer soruhep4 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                        soruhep4.Play();
                                        string[] sorular6 = { q1, q2, q3, q4 };
                                        Random rastgelekolay6 = new Random();
                                        int kolay6;
                                        kolay6 = rastgelekolay6.Next(0, sorular6.Length);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(sorular6[kolay6]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        if (kolay6 == 0)
                                        {
                                            Console.WriteLine("A)Stephen Hawking");
                                            Console.WriteLine("B)John Maynard Keynes");
                                            Console.WriteLine("C)John Forbes Nash");
                                            Console.WriteLine("D)Nikola Tesla");
                                            string ask25 = Console.ReadLine();
                                            if (ask25 == "a" || ask25 == "A")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                Console.WriteLine("60.000TL KAZANDINIZ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                dogru.Play();
                                                bakiye = bakiye + 60000;
                                            }
                                            if (ask25 == "D" || ask25 == "d" || ask25 == "B" || ask25 == "c" || ask25 == "b" || ask25 == "C")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("Doğru Cevap:A idi");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                yanlis.Play();
                                                continue;
                                            }
                                        }
                                        if (kolay6 == 1)
                                        {
                                            Console.WriteLine("A)Platon");
                                            Console.WriteLine("B)Nikola Tesla");
                                            Console.WriteLine("C)Sokrates");
                                            Console.WriteLine("D)Descartes");
                                            string ask26 = Console.ReadLine();
                                            if (ask26 == "C" || ask26 == "c")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                Console.WriteLine("60.000TL KAZANDINIZ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                dogru.Play();
                                                bakiye = bakiye + 60000;
                                            }
                                            if (ask26 == "D" || ask26 == "d" || ask26 == "B" || ask26 == "a" || ask26 == "b" || ask26 == "A")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("Doğru Cevap:C idi");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                yanlis.Play();
                                                continue;
                                            }
                                        }
                                        if (kolay6 == 2)
                                        {
                                            Console.WriteLine("A)Isaac Newton");
                                            Console.WriteLine("B)Albert Einstein");
                                            Console.WriteLine("C)Nikola Tesla");
                                            Console.WriteLine("D)Edison");
                                            string ask27 = Console.ReadLine();
                                            if (ask27 == "b" || ask27 == "B")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                Console.WriteLine("60.000TL KAZANDINIZ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                dogru.Play();
                                                bakiye = bakiye + 60000;
                                            }
                                            if (ask27 == "D" || ask27 == "d" || ask27 == "a" || ask27 == "c" || ask27 == "A" || ask27 == "C")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("Doğru Cevap:B idi");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                yanlis.Play();
                                                continue;
                                            }
                                        }
                                        if (kolay6 == 3)
                                        {
                                            Console.WriteLine("A)Lucid Rüya");
                                            Console.WriteLine("B)Telekinezi");
                                            Console.WriteLine("C)Astral Seyahat");
                                            Console.WriteLine("D)Telepati");
                                            string ask28 = Console.ReadLine();
                                            if (ask28 == "c" || ask28 == "C")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                Console.WriteLine("60.000TL KAZANDINIZ");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                dogru.Play();
                                                bakiye = bakiye + 60000;
                                            }
                                            if (ask28 == "D" || ask28 == "d" || ask28 == "a" || ask28 == "b" || ask28 == "A" || ask28 == "B")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("Doğru Cevap:C idi");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                yanlis.Play();
                                                continue;
                                            }
                                        }
                                        Console.WriteLine("8.soru için Hazır mısınız");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Mevcut Bakiye" + bakiye);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Evet veya hayır");
                                        string sad6 = Console.ReadLine();
                                        if (sad6 == "evet" || sad6 == "Evet")
                                        {
                                            SoundPlayer soruhep5 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                            soruhep5.Play();
                                            string[] sorular7 = { d1, d2, d3, d4 };
                                            Random rastgelekolay7 = new Random();
                                            int kolay7;
                                            kolay7 = rastgelekolay7.Next(0, sorular7.Length);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine(sorular7[kolay7]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            if (kolay7 == 0)
                                            {
                                                Console.WriteLine("A)Seni seviyorum");
                                                Console.WriteLine("B)Merhaba Dünya");
                                                Console.WriteLine("C)Evlen benimle");
                                                Console.WriteLine("D)Bunu yazan Yasuşi");
                                                string ask29 = Console.ReadLine();
                                                if (ask29 == "c" || ask29 == "C")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("125.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 125000;
                                                }
                                                if (ask29 == "D" || ask29 == "d" || ask29 == "a" || ask29 == "b" || ask29 == "A" || ask29 == "B")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:C idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }

                                            }
                                            if (kolay7 == 1)
                                            {
                                                Console.WriteLine("A)Katiyen");
                                                Console.WriteLine("B)Kesinkes");
                                                Console.WriteLine("C)Pekâlâ");
                                                Console.WriteLine("D)Daima");
                                                string ask30 = Console.ReadLine();
                                                if (ask30 == "D" || ask30 == "d")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("125.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 125000;
                                                }
                                                if (ask30 == "C" || ask30 == "c" || ask30 == "a" || ask30 == "b" || ask30 == "A" || ask30 == "B")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:D idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }

                                            }
                                            if (kolay7 == 2)
                                            {
                                                Console.WriteLine("A)Yıldızları barışmamak");
                                                Console.WriteLine("B)Perileri bağdaşmak");
                                                Console.WriteLine("C)Kafası uyuşmak");
                                                Console.WriteLine("D)Gönlü çelinmek");
                                                string ask31 = Console.ReadLine();
                                                if (ask31 == "C" || ask31 == "c")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("125.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 125000;
                                                }
                                                if (ask31 == "D" || ask31 == "d" || ask31 == "a" || ask31 == "b" || ask31 == "A" || ask31 == "B")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:C idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay7 == 3)
                                            {
                                                Console.WriteLine("A)Anayasa kitabı");
                                                Console.WriteLine("B)Tabela");
                                                Console.WriteLine("C)Terazi");
                                                Console.WriteLine("D)Hiçbir şey");
                                                string ask32 = Console.ReadLine();
                                                if (ask32 == "b" || ask32 == "B")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("125.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 125000;
                                                }
                                                if (ask32 == "D" || ask32 == "d" || ask32 == "a" || ask32 == "c" || ask32 == "A" || ask32 == "C")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:B idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                        }
                                        Console.WriteLine("9.soru için Hazır mısınız");
                                        Console.ForegroundColor= ConsoleColor.Blue;
                                        Console.WriteLine("Mevcut Bakiye"+bakiye);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Evet veya hayır");
                                        string sad7 = Console.ReadLine();
                                        if (sad7 == "evet" || sad7 == "Evet")
                                        {
                                            SoundPlayer soruhep7 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                            soruhep7.Play();
                                            string[] sorular8 = { y1, y2, y3, y4 };
                                            Random rastgelekolay9 = new Random();
                                            int kolay9;
                                            kolay9 = rastgelekolay9.Next(0, sorular8.Length);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine(sorular8[kolay9]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            if (kolay9 == 0)
                                            {
                                                Console.WriteLine("A)Patoz");
                                                Console.WriteLine("B)Takoz");
                                                Console.WriteLine("C)Tonoz");
                                                Console.WriteLine("D)Moloz");
                                                string ask33 = Console.ReadLine();
                                                if (ask33 == "d" || ask33 == "D")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("250.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 250000;
                                                }
                                                if (ask33 == "B" || ask33 == "b" || ask33 == "a" || ask33 == "c" || ask33 == "A" || ask33 == "C")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:D idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay9 == 1)
                                            {
                                                Console.WriteLine("A)Emniyet kemeri takmamak");
                                                Console.WriteLine("B)Çok yavaş gitmek");
                                                Console.WriteLine("C)Ehliyetini evde unutmak");
                                                Console.WriteLine("D)Araçta müzik dinlemek");
                                                string ask34 = Console.ReadLine();
                                                if (ask34 == "B" || ask34 == "b")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("250.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 250000;
                                                }
                                                if (ask34 == "D" || ask34 == "d" || ask34 == "a" || ask34 == "c" || ask34 == "A" || ask34 == "C")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:B idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay9 == 2)
                                            {
                                                Console.WriteLine("A)Sivas");
                                                Console.WriteLine("B)İstanbul");
                                                Console.WriteLine("C)Erzurum");
                                                Console.WriteLine("D)Şanlıurfa");
                                                string ask35 = Console.ReadLine();
                                                if (ask35 == "d" || ask35 == "D")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("250.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 250000;
                                                }
                                                if (ask35 == "B" || ask35 == "b" || ask35 == "a" || ask35 == "c" || ask35 == "A" || ask35 == "C")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:D idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay9 == 3)
                                            {
                                                Console.WriteLine("A)Suç ve ceza");
                                                Console.WriteLine("B)Olasılıksız");
                                                Console.WriteLine("C)Otomatik Portakal");
                                                Console.WriteLine("D)Yeraltından notlar");
                                                string ask36 = Console.ReadLine();
                                                if (ask36 == "C" || ask36 == "c")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.WriteLine("250.000TL KAZANDINIZ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                    bakiye = bakiye + 250000;
                                                }
                                                if (ask36 == "B" || ask36 == "b" || ask36 == "a" || ask36 == "D" || ask36 == "A" || ask36 == "d")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:C idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                        }
                                        Console.WriteLine("FİNAL sorusu için Hazır mısınız");
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Mevcut Bakiye" + bakiye);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Evet veya hayır");
                                        string sad8 = Console.ReadLine();
                                        if (sad8 == "evet" || sad8 == "Evet")
                                        {
                                            SoundPlayer soruhep8 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\sorumuzik.wav");
                                            soruhep8.Play();
                                            string[] sorular9 = { m1, m2, m3, m4 };
                                            Random rastgelekolay10 = new Random();
                                            int kolay10;
                                            kolay10 = rastgelekolay10.Next(0, sorular9.Length);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine(sorular9[kolay10]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            if (kolay10 == 0)
                                            {
                                                Console.WriteLine("A)Birleşik Krallık");
                                                Console.WriteLine("B)Çin");
                                                Console.WriteLine("C)Küba");
                                                Console.WriteLine("D)Danimarka");
                                                string ask37 = Console.ReadLine();
                                                if (ask37 == "A" || ask37 == "a")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                }
                                                if (ask37 == "B" || ask37 == "b" || ask37 == "C" || ask37 == "D" || ask37 == "c" || ask37 == "d")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:A idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay10 == 1)
                                            {
                                                Console.WriteLine("A)41");
                                                Console.WriteLine("B)43");
                                                Console.WriteLine("C)51");
                                                Console.WriteLine("D)53");
                                                string ask38 = Console.ReadLine();
                                                if (ask38 == "D" || ask38 == "d")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                }
                                                if (ask38 == "A" || ask38 == "a" || ask38 == "C" || ask38 == "B" || ask38 == "c" || ask38 == "b")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:B idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay10 == 2)
                                            {
                                                Console.WriteLine("A)5 dakika");
                                                Console.WriteLine("B)25 dakika");
                                                Console.WriteLine("C)1 saat");
                                                Console.WriteLine("D)1 saat 40 dakika");
                                                string ask39 = Console.ReadLine();
                                                if (ask39 == "d" || ask39 == "D")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                }
                                                if (ask39 == "A" || ask39 == "a" || ask39 == "C" || ask39 == "B" || ask39 == "c" || ask39 == "b")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:D idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                            if (kolay10 == 3)
                                            {
                                                Console.WriteLine("A)Asya ve Amerika");
                                                Console.WriteLine("B)Afrika ve Avrupa");
                                                Console.WriteLine("C)Avrupa ve Asya");
                                                Console.WriteLine("D)Asya ve Afrika");
                                                string ask40 = Console.ReadLine();
                                                if (ask40 == "B" || ask40 == "b")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Tebrikler Doğru cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer dogru = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\dogruses.wav");
                                                    dogru.Play();
                                                }
                                                if (ask40 == "A" || ask40 == "a" || ask40 == "C" || ask40 == "d" || ask40 == "c" || ask40 == "D")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("Maalesef Yanlış cevap verdiniz");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("Doğru Cevap:B idi");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    SoundPlayer yanlis = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\lose.wav");
                                                    yanlis.Play();
                                                    continue;
                                                }
                                            }
                                        }
                                        Console.WriteLine("Tebrikler SİZ BİR MİLYONERSİNİZ!!!");
                                        SoundPlayer milyon = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\bilgi\1milyon.wav");
                                        milyon.Play();
                                        break;
                                    }
                                }
                            }
                        }
                    }

                }
                if (ask == "Hayır" || ask == "hayır")
                {
                    Console.WriteLine("Demek buraya kadar");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}

