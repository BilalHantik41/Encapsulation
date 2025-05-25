using Encapsulation;

Araba araba = new Araba();



Console.WriteLine("Lütfen Araç Bilgilerini Giriniz: ");

Console.Write("Arabanın Markası: ");
araba.Marka = Console.ReadLine();
 
Console.Write("Arabanın Modeli: ");
araba.Model = Console.ReadLine();

Console.Write("Arabanın Rengi: ");
araba.Renk = Console.ReadLine();


Console.Write("Arabanın Kapı Sayısı: ");
araba.KapıSayısı = int.Parse(Console.ReadLine());




Console.Clear();
Console.WriteLine("Arabanın Markası: " + araba.Marka);
Console.WriteLine("Arabanın Modeli: " + araba.Model);
Console.WriteLine("Arabanın Rengi: " +  araba.Renk);
Console.WriteLine("Arabanın Kapı Sayısı : " +  araba.KapıSayısı);