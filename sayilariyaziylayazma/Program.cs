using System;

namespace sayilariyaziylayazma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string sayiyazisi = sayi.ToString();

            Console.WriteLine(sayiyazisi);

            int[] basamak = new int[sayiyazisi.Length];

            int i = 0;

            while (sayi > 0)
            {
                basamak[i] = sayi % 10;

                sayi = sayi / 10;

                i++;
            }

            //BASAMAK UZUNLUĞU
            bool isbirler = false;
            bool isonlar = false;
            bool isyuzler = false;
            bool isbinler = false;
            bool isonbinler = false;
            bool isyuzbinler = false;
            bool ismilyonlar = false;
            bool isonmilyonlar = false;
            bool isyuzmilyonlar = false;
            switch(basamak.Length)
            {
                case 1:
                    isbirler = true;
                    break;
                case 2:
                    isbirler = true;
                    isonlar = true;
                    break;
                case 3:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    break;
                case 4:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    isbinler = true;
                    break;
                case 5:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    isbinler = true;
                    isonbinler = true;
                    break;
                case 6:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    isbinler = true;
                    isonbinler = true;
                    isyuzbinler = true;
                    break;
                case 7:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    isbinler = true;
                    isonbinler = true;
                    isyuzbinler = true;
                    ismilyonlar = true;
                    break;
                case 8:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    isbinler = true;
                    isonbinler = true;
                    isyuzbinler = true;
                    ismilyonlar = true;
                    isonmilyonlar = true;
                    break;
                case 9:
                    isbirler = true;
                    isonlar = true;
                    isyuzler = true;
                    isbinler = true;
                    isonbinler = true;
                    isyuzbinler = true;
                    ismilyonlar = true;
                    isonmilyonlar = true;
                    isyuzmilyonlar = true;
                    break;
            }    


            //BİRLER BASAMAĞI
            string birlerbasString = "";
            if(isbirler)
            {
                switch(basamak[0])
            {
                case 1:
                    birlerbasString = "bir";
                    break;
                case 2:
                    birlerbasString = "iki";
                    break;
                case 3:
                    birlerbasString = "üç";
                    break;
                case 4:
                    birlerbasString = "dört";
                    break;
                case 5:
                    birlerbasString = "beş";
                    break;
                case 6:
                    birlerbasString = "altı";
                    break;
                case 7:
                    birlerbasString = "yedi";
                    break;
                case 8:
                    birlerbasString = "sekiz";
                    break;
                case 9:
                    birlerbasString = "dokuz";
                    break;
            }
            }
            

            //ONLAR BASAMAĞI
            string onlarbasString = "";
            
            if(isonlar)
            {
                switch(basamak[1])
            {
                case 1:
                    onlarbasString = "on";
                    break;
                case 2:
                    onlarbasString = "yirmi";
                    break;
                case 3:
                    onlarbasString = "otuz";
                    break;
                case 4:
                    onlarbasString = "kırk";
                    break;
                case 5:
                    onlarbasString = "elli";
                    break;
                case 6:
                    onlarbasString = "altmış";
                    break;
                case 7:
                    onlarbasString = "yetmiş";
                    break;
                case 8:
                    onlarbasString = "seksen";
                    break;
                case 9:
                    onlarbasString = "doksan";
                    break;
            }
            }
            

            //YÜZLER BASAMAĞI
            string yuzlerbasString = "";

            if(isyuzler)
            {
                switch (basamak[2])
            {
                case 1:
                    yuzlerbasString = "yüz";
                    break;
                case 2:
                    yuzlerbasString = "ikiyüz";
                    break;
                case 3:
                    yuzlerbasString = "üçyüz";
                    break;
                case 4:
                    yuzlerbasString = "dörtyüz";
                    break;
                case 5:
                    yuzlerbasString = "beşyüz";
                    break;
                case 6:
                    yuzlerbasString = "altıyüz";
                    break;
                case 7:
                    yuzlerbasString = "yediyüz";
                    break;
                case 8:
                    yuzlerbasString = "sekizyüz";
                    break;
                case 9:
                    yuzlerbasString = "dokuzyüz";
                    break;
            }
            }
            

            //BİNLER BASAMAĞI
            string binlerbasString = "";
            
            if(isbinler)
            {
                switch (basamak[3])
                {
                    case 1:
                        binlerbasString = "bin";
                        break;
                    case 2:
                        binlerbasString = "ikibin";
                        break;
                    case 3:
                        binlerbasString = "üçbin";
                        break;
                    case 4:
                        binlerbasString = "dörtbin";
                        break;
                    case 5:
                        binlerbasString = "beşbin";
                        break;
                    case 6:
                        binlerbasString = "altıbin";
                        break;
                    case 7:
                        binlerbasString = "yedibin";
                        break;
                    case 8:
                        binlerbasString = "sekizbin";
                        break;
                    case 9:
                        binlerbasString = "dokuzbin";
                        break;
            }
            }
            
            
            

            //ONBİNLER BASAMAĞI
            string onbinlerbasString = "";

            if(isonbinler)
            {
                if(basamak[3] == 0)
            {
                switch (basamak[4])
                {
                    case 1:
                        onbinlerbasString = "onbin";
                        break;
                    case 2:
                        onbinlerbasString = "yirmibin";
                        break;
                    case 3:
                        onbinlerbasString = "otuzbin";
                        break;
                    case 4:
                        onbinlerbasString = "kırkbin";
                        break;
                    case 5:
                        onbinlerbasString = "ellibin";
                        break;
                    case 6:
                        onbinlerbasString = "altmışbin";
                        break;
                    case 7:
                        onbinlerbasString = "yetmişbin";
                        break;
                    case 8:
                        onbinlerbasString = "seksenbin";
                        break;
                    case 9:
                        onbinlerbasString = "doksanbin";
                        break;
                }
            }
                else
            {
                switch (basamak[4])
                {
                    case 1:
                        onbinlerbasString = "on";
                        break;
                    case 2:
                        onbinlerbasString = "yirmi";
                        break;
                    case 3:
                        onbinlerbasString = "otuz";
                        break;
                    case 4:
                        onbinlerbasString = "kırk";
                        break;
                    case 5:
                        onbinlerbasString = "elli";
                        break;
                    case 6:
                        onbinlerbasString = "altmış";
                        break;
                    case 7:
                        onbinlerbasString = "yetmiş";
                        break;
                    case 8:
                        onbinlerbasString = "seksen";
                        break;
                    case 9:
                        onbinlerbasString = "doksan";
                        break;
                }
            }
            }
            

            //YÜZBİNLER BASAMAĞI
            string yuzbinlerbasString = "";

            if(isyuzbinler)
            { 
                if (basamak[3] == 0 && basamak[4] == 0)
            {
                switch (basamak[5])
                {
                    case 1:
                        yuzbinlerbasString = "yüzbin";
                        break;
                    case 2:
                        yuzbinlerbasString = "ikiyüzbin";
                        break;
                    case 3:
                        yuzbinlerbasString = "üçyüzbin";
                        break;
                    case 4:
                        yuzbinlerbasString = "dörtyüzbin";
                        break;
                    case 5:
                        yuzbinlerbasString = "beşyüzbin";
                        break;
                    case 6:
                        yuzbinlerbasString = "altıyüzbin";
                        break;
                    case 7:
                        yuzbinlerbasString = "yediyüzbin";
                        break;
                    case 8:
                        yuzbinlerbasString = "sekizyüzbin";
                        break;
                    case 9:
                        yuzbinlerbasString = "dokuzyüzbin";
                        break;
                }
            }
                else
            {
                switch (basamak[5])
                {
                    case 1:
                        yuzbinlerbasString = "yüz";
                        break;
                    case 2:
                        yuzbinlerbasString = "ikiyüz";
                        break;
                    case 3:
                        yuzbinlerbasString = "üçyüz";
                        break;
                    case 4:
                        yuzbinlerbasString = "dörtyüz";
                        break;
                    case 5:
                        yuzbinlerbasString = "beşyüz";
                        break;
                    case 6:
                        yuzbinlerbasString = "altıyüz";
                        break;
                    case 7:
                        yuzbinlerbasString = "yediyüz";
                        break;
                    case 8:
                        yuzbinlerbasString = "sekizyüz";
                        break;
                    case 9:
                        yuzbinlerbasString = "dokuzyüz";
                        break;
                }
            }
            }

            //MİLYONLAR BASAMAĞI
            string milyonlarbasString = "";

            if(ismilyonlar)
            {
                switch (basamak[6])
                {
                    case 1:
                        milyonlarbasString = "birmilyon";
                        break;
                    case 2:
                        milyonlarbasString = "ikimilyon";
                        break;
                    case 3:
                        milyonlarbasString = "üçmilyon";
                        break;
                    case 4:
                        milyonlarbasString = "dörtmilyon";
                        break;
                    case 5:
                        milyonlarbasString = "beşmilyon";
                        break;
                    case 6:
                        milyonlarbasString = "altımilyon";
                        break;
                    case 7:
                        milyonlarbasString = "yedimilyon";
                        break;
                    case 8:
                        milyonlarbasString = "sekizmilyon";
                        break;
                    case 9:
                        milyonlarbasString = "dokuzmilyon";
                        break;
                }
            }

            //ONMİLYONLAR BASAMAĞI
            string onmilyonlarbasString = "";

            if(isonmilyonlar)
            {
                if (basamak[6] == 0)
                {
                    switch (basamak[7])
                    {
                        case 1:
                            onmilyonlarbasString = "onmilyon";
                            break;
                        case 2:
                            onmilyonlarbasString = "yirmimilyon";
                            break;
                        case 3:
                            onmilyonlarbasString = "otuzmilyon";
                            break;
                        case 4:
                            onmilyonlarbasString = "kırkmilyon";
                            break;
                        case 5:
                            onmilyonlarbasString = "ellimilyon";
                            break;
                        case 6:
                            onmilyonlarbasString = "altmışbin";
                            break;
                        case 7:
                            onmilyonlarbasString = "yetmişmilyon";
                            break;
                        case 8:
                            onmilyonlarbasString = "seksenmilyon";
                            break;
                        case 9:
                            onmilyonlarbasString = "doksanmilyon";
                            break;
                    }
                }
                else
                {
                    switch (basamak[7])
                    {
                        case 1:
                            onmilyonlarbasString = "on";
                            break;
                        case 2:
                            onmilyonlarbasString = "yirmi";
                            break;
                        case 3:
                            onmilyonlarbasString = "otuz";
                            break;
                        case 4:
                            onmilyonlarbasString = "kırk";
                            break;
                        case 5:
                            onmilyonlarbasString = "elli";
                            break;
                        case 6:
                            onmilyonlarbasString = "altmış";
                            break;
                        case 7:
                            onmilyonlarbasString = "yetmiş";
                            break;
                        case 8:
                            onmilyonlarbasString = "seksen";
                            break;
                        case 9:
                            onmilyonlarbasString = "doksan";
                            break;
                    }
                }
            }

            //YÜZMİLYONLAR BASAMAĞI
            string yuzmilyonlarbasString = "";

            if (isyuzmilyonlar)
            {
                if (basamak[6] == 0 && basamak[7] == 0)
                {
                    switch (basamak[8])
                    {
                        case 1:
                            yuzmilyonlarbasString = "yüzmilyon";
                            break;
                        case 2:
                            yuzmilyonlarbasString = "ikiyüzmilyon";
                            break;
                        case 3:
                            yuzmilyonlarbasString = "üçyüzmilyon";
                            break;
                        case 4:
                            yuzmilyonlarbasString = "dörtyüzmilyon";
                            break;
                        case 5:
                            yuzmilyonlarbasString = "beşyüzmilyon";
                            break;
                        case 6:
                            yuzmilyonlarbasString = "altıyüzmilyon";
                            break;
                        case 7:
                            yuzmilyonlarbasString = "yediyüzmilyon";
                            break;
                        case 8:
                            yuzmilyonlarbasString = "sekizyüzmilyon";
                            break;
                        case 9:
                            yuzmilyonlarbasString = "dokuzyüzmilyon";
                            break;
                    }
                }
                else
                {
                    switch (basamak[8])
                    {
                        case 1:
                            yuzmilyonlarbasString = "yüz";
                            break;
                        case 2:
                            yuzmilyonlarbasString = "ikiyüz";
                            break;
                        case 3:
                            yuzmilyonlarbasString = "üçyüz";
                            break;
                        case 4:
                            yuzmilyonlarbasString = "dörtyüz";
                            break;
                        case 5:
                            yuzmilyonlarbasString = "beşyüz";
                            break;
                        case 6:
                            yuzmilyonlarbasString = "altıyüz";
                            break;
                        case 7:
                            yuzmilyonlarbasString = "yediyüz";
                            break;
                        case 8:
                            yuzmilyonlarbasString = "sekizyüz";
                            break;
                        case 9:
                            yuzmilyonlarbasString = "dokuzyüz";
                            break;
                    }
                }
            }
            
            //YAZDIRMA KISMI
            if(isbirler && !isonlar && !isyuzler && !isbinler && !isonbinler && !isyuzbinler && !ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(birlerbasString);
            }else if (isbirler && isonlar && !isyuzler && !isbinler && !isonbinler && !isyuzbinler && !ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(onlarbasString + " " +birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && !isbinler && !isonbinler && !isyuzbinler && !ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && isbinler && !isonbinler && !isyuzbinler && !ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(binlerbasString + " " + yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && isbinler && isonbinler && !isyuzbinler && !ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(onbinlerbasString + " " +binlerbasString + " " + yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && isbinler && isonbinler && isyuzbinler && !ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(yuzbinlerbasString + " " +onbinlerbasString + " " + binlerbasString + " " + yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && isbinler && isonbinler && isyuzbinler && ismilyonlar && !isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(milyonlarbasString + " " + yuzbinlerbasString + " " + onbinlerbasString + " " + binlerbasString + " " + yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && isbinler && isonbinler && isyuzbinler && ismilyonlar && isonmilyonlar && !isyuzmilyonlar)
            {
                Console.WriteLine(onmilyonlarbasString + " " + milyonlarbasString + " " + yuzbinlerbasString + " " + onbinlerbasString + " " + binlerbasString + " " + yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }
            else if (isbirler && isonlar && isyuzler && isbinler && isonbinler && isyuzbinler && ismilyonlar && isonmilyonlar && isyuzmilyonlar)
            {
                Console.WriteLine(yuzmilyonlarbasString + " " + onmilyonlarbasString + " " + milyonlarbasString + " " + yuzbinlerbasString + " " + onbinlerbasString + " " + binlerbasString + " " + yuzlerbasString + " " + onlarbasString + " " + birlerbasString);
            }

            Console.ReadLine();

        }
    }
}
