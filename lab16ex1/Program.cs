using lab16ex1.Model;

/*Exercitiul – 1
 • Un student este caracterizat de
• Id (unic)
• Nume
• Prenume
• Varsta
• Specializare
• Specializarile vor fi
• Informatica
• Litere
• Constructii
Creeati modelul, adaugati EF 3.1,
Adaugati DB
• Creeati in clasa “main” o functie
“Seed” care va popula DB-ul
• Afisati toti studentii din DB in
ordine alfabetica
• Afisati cel mai tanar student de
la constructii cu varsta de peste
20 de ani.

Exercitiul 2
• Un autovehicul este caracterizat de
urmatoarele proprietati
• Id:int
• Nume
• Serie de sasiu: string
• An de fabricatie :int
• Producator
• Producatorul va avea
• Id:int
• Nume
• Adresa:string
 Creeati modelul, adaugati EF 3.1,
Adaugati DB
• Creeati in clasa “main” o functie
“Seed” care va popula DB-ul
• Afisati toate autovehiculele in ordine
descrescatoare a anului de fabricatie
• Suplimentar
• Afisati autovehiculele grupate in functie
de numele producatorului sub forma
“Autovehiculele producatorului Trabant”:
Id, nume, serie, an de fabricatie
.
.
.
etc.

*/


using var context=new StudentDBContext();

 var stud= context.Students.OrderBy(s=>s.Nume).ToList();
  stud.ForEach(s =>Console.WriteLine(s));


var studentTanarConstructii=
    context.Students.Where(s=>s.Specializare==Specializari.Constructii && s.Varsta>20)
    .OrderBy(s=>s.Varsta)
    .FirstOrDefault();

//Seed();

static void Seed()
{
   using var context = new StudentDBContext();

    
    context.Database.EnsureCreated();

    context.Students.Add(new Student
    {
        Nume = "Gigi",
        Prenume="Viorel",
        Varsta = 30,
        Specializare = Specializari.Constructii
    });

    context.Students.Add(new Student
    {
        Nume = "Marian",
        Prenume="Marin",
        Varsta = 35,
        Specializare = Specializari.Informatica
    });

    context.Students.Add(new Student
    {
        Nume = "Viorel",
        Prenume = "Dumitrel",
        Varsta = 42,
        Specializare = Specializari.Litere
    });

    context.Students.Add(new Student
    {
        Nume = "Carmen",
        Prenume = "Elena",
        Varsta = 20,
        Specializare = Specializari.Constructii
    });

    context.Students.Add(new Student
    {
        Nume = "George",
        Prenume = "Mihai",
        Varsta = 38,
        Specializare = Specializari.Informatica
    });

    context.SaveChanges();

}


 