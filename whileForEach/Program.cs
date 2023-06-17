using System;


namespace whileForeach
{
     class Program
{
     static void Main(string[] args)
    {
        // while
        // 1den başlayarak consoledan girilen sayıya kadar sayıl dahil ortalama hesaplayıp
        //console a yazdıran program
        Console.Write("Lütfen Bir Sayı Giriniz: ");
        int sayi=int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam=0;
        while (sayac<=sayi)
        {
            toplam+=sayac;
            sayac++;
        }

        Console.WriteLine(toplam/sayi);

        // a dan z ye kadar tüm harfleri console a yazdır

        char character='a';
        while (character<'z')
        {
            Console.Write(character);
            character ++;
        }

        //

        Console.Write("****Foreach******");
        string[] arabalar={"BMV","Ford","Fiat","Opel"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}
}
