
using CsevegesCLI;

List<Beszelgetes> beszelgetesek = new();
List<string> tagok = new();

using StreamReader srBeszelgetesek = new(@"..\..\..\src\csevegesek.txt");
_ = srBeszelgetesek.ReadLine();
while (!srBeszelgetesek.EndOfStream) beszelgetesek.Add(new(srBeszelgetesek.ReadLine()));

using StreamReader srTagok = new(@"..\..\..\src\tagok.txt");
while (!srTagok.EndOfStream) tagok.Add(srTagok.ReadLine());

Console.WriteLine("4. feladat:\n" +
    $"\ttagok száma: {tagok.Count} fő\n" +
    $"\tbeszélgetések száma: {beszelgetesek.Count} db");

var leghoszabb = beszelgetesek.MaxBy(b => b.Veg - b.Kezdet);
Console.WriteLine("5. feladat: leghosszabb beszélgetés adatai");
Console.WriteLine(leghoszabb.ToString());

Console.Write("6. feladat: Adja meg egy tag nevét: ");
string tag = Console.ReadLine().ToLower();

var osszMasodperc = (int)beszelgetesek
    .Where(b => b.Fogado.ToLower() == tag || b.Kezdemenyezo.ToLower() == tag)
    .Sum(b => (b.Veg - b.Kezdet).TotalSeconds);
Console.WriteLine($"\tA beszélgetések összes ideje: {TimeSpan.FromSeconds(osszMasodperc)}");

var beszelgetok = beszelgetesek.Select(b => b.Kezdemenyezo).ToList();
beszelgetok.AddRange(beszelgetesek.Select(b => b.Fogado));
beszelgetok = beszelgetok.Distinct().ToList();

var kimaradt = tagok.Except(beszelgetok);
Console.WriteLine("7. feladat: nem beszélgettek senkivel");
foreach (var nev in kimaradt) Console.WriteLine($"\t{nev}");

//8as még nincs kész!