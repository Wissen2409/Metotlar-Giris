

// Metotlar, iş yapan küçük program parçalarıdır.
// Metotlar, içlerine  aldıkları değerler ve size geriye döndürdükleri değerler ile birlikte çalışır


// Gerçek hayatta problemler ile karşılaştığımızda, onları çözüm yoluna gideriz.
// Genelde büyük problemler karşımıza çıktığında, büyük bir problem ile uğraşmak oldukça zordur.

// Bu tarz durumlarda, küçük bir problemi, küçük parçalar haline bölüp çözmeye çalışmak önerilir.

// Yazılım tarafındaki büyük boyuttaki işler gerçek hayattaki probleme benzer. Eğer bu tip işleri
// o boyutuyla çözmeye çalışırsak, genelde çok karmaşık çözümlerle karşılaşırız

// problemi ufak çarçalara ayırmak yazılım dünyasında, metotlara denk gelir.

// Metotlar, yukarıda da belirttiğimiz gibi ufak kod parçacıklarıdır. Her bir problem çözümünü ufak metotlara ayırarak, 
// problem çözüm süresici boyunca başarılı olunur.

// Metot türleri nelerdir. 
// 1- Parametre alan metotlar(bir parametre alabildiği gibi n adet parametre alabilir)
// 2- Geriye değer döndüren metotlar(çalıştıktan sonra bir değer üretiyor ve onu dönüyor ise değer döndüren metotdur.)
// 3- Parametre almayan metot(Dışarıdan parametre içeride bir şekilde kendi işini kendi yapan metotdur)
// 4- Geriye değer döndürmeyen metotlar(Çalıştıktan sonra geriye bir değer döndürmeyen metotdur.)

// Metot Syntax : 

/*erişim belirteci + static/ yada static olmama + geri dönüş tipi / yada değer dönmeyecekse void + Metot Adı(Metot Parametreleri){

// Metot içi

}*/

// yukarıdaki imzayı biraz açalım

// Erişim belirteçler: bir metodun hangi katmandan yada nereden erişebileceğini belirler
// Erişim belirteçler şunlardır

// Public : Her katömandan erişilebilir.
// Private : Sadece kendi katmanında erişilir diğer tüm yerlere erişimi kapalıdır
// Protected : Kalıtım hiyerarşisi olan katmandan erişilir. Diğer katmanlara kapalıdır
// Protected Internal : Ya kalıtım hiyerarşisi yada dış bir paket tarafından erişilir, diğer yerlere kapalıdır
// Internal : Sadece dış bir paket tarafından erişilir.

// yukarıdaki erişim belirteçlerden bir süre  sadece public olanı kullanacağız, diğer erişim belirteçlere daha sonra deyineceğiz.

// Static yada Static olmama : Metotlar için en önemli kavramlardan bir tanesidir. Bu belirteçten şimdilik sadece static olanı kullanacağız. Static olamama durumu daha sonra deyineceğiz

// Geri Dönüş tipi : Bir metotdan geriye .net içerisindeki tüm değişken tipleri dönebilir.Ancak metot geriye değer döndürmüyor ise, void olarak işaretlenmelidir.

// Metot Adı : Metot adı, metodun yapacağı iş ile ilgili olmaldır.(tek harf metot olmamalıdır.)

// Metot isimlendirme kuralları

/*
Metot adı tek harf olmamalıdır.
Metot adından önce rakam veya karakter kullanılmamalıdır.
Metot adı metodun yapacağı iş ile ilgili olmalıdır
Metot adı çok uzun olmamalıdır
Metotlar isimlendirilirken Pascal Casing kullanılmalıdır Örnek : WissenMetot yani metot isminin baş harfi büyük sonraki harfler küçük olmaldırı
Eğer metot adı iki kelime ise, her kelimenin baş harfi büyük geri kalan harfler küçük olmalıdır.
*/

// Metot Parametreleri : Bir metot 1 yada birden çok parametre alabilir Parametre sayısının bir sınırı yoktur.Aynı yeri dönüş tipinde olduğu gibi bir metot .net ilçeridsindeki tüm değişken tiplerini parametre olarak alabilir


// Bazı kurallar : 
/*

Metot yazarken, satır sayısı na dikkat edilmelidir. Bu bir yazılım görgü kuralıdır. 30-34 satır kodu geçmemelidir.
Aynı şekilde metot parametrelerinde de bir genel geçer kural vardır. Metot parametre sayısı 4'ü geçerse buraya bir önlem alınması gerektiğini söyler.


// Metot yazalım 

// Parametre alan ve geriye değer döndüren bir metot yazalım 

 

*/

// TersCevir metodu, string parametre alıp, string değer döndürüyor

string ters = TersCevir("wissen besiktas");
string ters1 = TersCevir("Hilltown");

TersCevir("ters");

//dönen değeri alıp, ekrana yazdırdık
Console.WriteLine(ters);
Console.WriteLine(ters1);



// metot yazıldığında bellekte kaplamaz ve derleyici tarafından derlenmez
// ancak ne zaman çağırılırsa o zaman bellekte belli bir miktar alan işgal eder.
// Ne kadar işgal eder : İçerinde kullanılan tiplere bağlı olarak değişir.


// Metotların faydaları : Kod tekrarı önlemek(kod tekrarını önlemek yazılım geliştirmede en önemli kavramlardan bir tanesidir.)
// Kod tekrarı yapılan bir projede, hata çıkma oranı çok fazladır. 

// Bakım kolaylığı : Metotlar kod içerisinde bakım kolaylığı sağlar
// çok tekrar ettiğiniz kod bloklarını metot haline getirirseniz, o kod bloğunda bir sorun çıkarsa
// sadece metot içeriğini değiştiriemk bakım anlamında yeterli olacaktır.


// Örnek 1 : İki sayı al ve topla

int toplam = Topla(50, 80);
Console.WriteLine(toplam);

// Örnek 2 : YariÇap al ve dairenin alanını hesapla
double alan = AlanHesapla(30);
Console.WriteLine(alan);

// Örnek 3 : Max ve min değeri al ve random bir değer üret 
int random = RandomDeger(50, 700);
Console.WriteLine(random);

// Örnek 4 : Pi sayısının belirli index numarasını getirmek
string karakter =PiSayisiKarakter(1);
Console.WriteLine(karakter);

// Örnek 5 : Girdiğimiz yıl değeri ile bugün arasındaki farkı gün olarak versin

Console.WriteLine(DateTime.MinValue.ToLongDateString());
double fark = YilFarki(124);
Console.WriteLine(fark);


// Örnek 6 : Char karakteri verip, rakamsal karşılığını geri dönen metot
int rakamsalKarsilik = KarakterRakamsalKarsilik('Z');
Console.WriteLine(rakamsalKarsilik);


static string TersCevir(string deger)
{

    // parametre olarak aldığı değeri ters çevirip geri döndüren bir metot yazalım
    string ters = "";
    for (int i = deger.Length - 1; i >= 0; i--)
    {
        ters += deger[i];
    }

    // geriye değer döndüren metotlarda return ifadesi kullanılır
    return ters;
}

// Örnek 1 : Parametre olarak iki tane int tipinde değer alan ve geriye int dönen bir 
//metot yazınız
// bu metot, aldığı iki parametreyi birbiri ile toplayıp, toplamı geriye döndürsün

static int Topla(int a, int b)
{

    int toplam = a + b;
    return toplam;

}

// Örnek 2 :  bir tane int tipinde yarı çap değeri alıp, dairenin alanını hesaplayıp 
//geriye değer döndüren metodu yazınız

static double AlanHesapla(int yaricap)
{

    double hesap = Math.PI * yaricap * yaricap;


    return hesap;
}

// Örnek 3 : iki tane int tipinde aralık değerialan ve geriye random bir int döndüren 
//metotu yazınız

static int RandomDeger(int min, int max)
{

    Random rnd = new Random();
    int random = rnd.Next(min, max);
    return random;
}


// Örnek 4 : 
// Dışarıdan gönderdiğimiz bir değer ile , Pı sayısının o sayı olan
//  basamadığını geri döndüren metott

static string PiSayisiKarakter(int index)
{
    string pi = Math.PI.ToString();
    string subString = pi.Substring(index,1);
    return subString;
}


// Örnek 5 : 
// yıl değerini giriniz ve bugünden o yıla kadar kaç gün olduğunu söyleyen metot
static double YilFarki(int yil){

    DateTime time = new DateTime(yil,1,1);
    DateTime now = DateTime.Now;
    TimeSpan fark = time-now;
    return fark.TotalDays;
}

// Örnek 6 : Girmiş olduğunuz tek karakter dğeerinin, rakamsal karşılığını dönen metot
static  int KarakterRakamsalKarsilik(char karakter){

    int rakam = Convert.ToInt32(karakter);
    return rakam;
}