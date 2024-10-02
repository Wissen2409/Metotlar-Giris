

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



}*/

// yukarıdaki imzayı biraz açalım

// Erişim belirteçler: bir metodun hangi katmandan yada nereden erişebileceğini belirler
// Erişim belirteçler şunlardır

// Public 
// Private
// Protected
// Protected Internal
// Internal

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
string ters = TersCevir("wissen besiktas");

Console.WriteLine(ters);



static string TersCevir(string deger ){

    // parametre olarak aldığı değeri ters çevirip geri döndüren bir metot yazalım
    string ters ="";
    for (int i = deger.Length - 1; i >= 0 ; i--)
    {
        ters+=deger[i];
    }
    return ters;
}




