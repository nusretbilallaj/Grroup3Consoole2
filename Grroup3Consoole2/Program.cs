using Grroup3Consoole2;

Console.WriteLine("Profesori Leron Berisha");
//string emri="Armend Kryeziu";
//Console.WriteLine($"Studenti {emri}");

//int numriIBanoreve=3000;

//DefinoMadhesineEQytetit(numriIBanoreve);
//numriIBanoreve = 2500;
//DefinoMadhesineEQytetit(numriIBanoreve);

//void DefinoMadhesineEQytetit(int numri)
//{
//    if (numri <= 1000)
//    {
//        Console.WriteLine("Vendi eshte qytet i vogel");
//    }
//    else if (numri <= 2000)
//    {
//        Console.WriteLine("Vendi eshte qytet me i madh");
//    }
//    else
//    {
//        Console.WriteLine("Vendi eshte metropol");
//    }
//}

// int numri=100;
// Console.WriteLine(numri);
// Studenti studenti1 = new Studenti("Ardit","Berisha","Prishtine");
// studenti1.Pershendete();
// Studenti studenti2 = new Studenti("Argjent", "Celaj", "Prizren");
// studenti2.Pershendete();
//
// Profesori profesor1 = new Profesori("Leron", "Berisha");
// profesor1.Pershendete();

List<Person> lista = new List<Person>();

lista.Add(new Studenti("Muhamet","Berisha","Ohio"));
lista.Add(new Profesori("Leron", "Berisha"));

foreach (var person in lista)
{
    person.Pershendete();
}
