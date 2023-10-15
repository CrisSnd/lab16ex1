// See https://aka.ms/new-console-template for more information
using lab16ex2.Model;
using Microsoft.EntityFrameworkCore;

using var context = new CarParkDbContext();
context.Cars.OrderBy(c => c.ProductionYear).ToList()  
    .ForEach(c=>Console.WriteLine(c));

var carGroup = context.Cars.GroupBy(c => c.Manufacturer.Name).ToList();
carGroup.ForEach(c =>
{
    Console.WriteLine($"Autovehiculele producatorului{c.Key}");
    c.ToList().ForEach(c => Console.WriteLine(c));
});

//Afisare perechi nume producator-nume autovehicul
// context.Cars.Include(c=>c.Manufacturer).ToList().ForEach(c=>Console.WriteLine($"{c.Name} {c.Manufacturer.Name}"));
//sau
 var summaryList=context.Cars.Select(c => new
{
    CarName=c.Name,
    ManufacturerName=c.Manufacturer.Name,
})
    .ToList();

summaryList.ForEach(s => Console.WriteLine($"{s.CarName} {s.ManufacturerName}"));

//Seed();

static void Seed()
{
    using var context = new CarParkDbContext();

    context.Cars.Add(new Car
    {
        Name = "Skoda",
        ProductionYear=2020,
        VIN=Guid.NewGuid().ToString(),
        Manufacturer=new Manufacturer
        {
            Name = "AAA",
            Adress = "XXX"
        }
    });

    context.Cars.Add(new Car
    {
        Name = "Dacia",
        ProductionYear = 2010,
        VIN = Guid.NewGuid().ToString(),
        Manufacturer = new Manufacturer
        {
            Name = "BBB",
            Adress = "ZZZ"
        }
    });

    context.Cars.Add(new Car
    {
        Name = "Opel",
        ProductionYear = 2015,
        VIN = Guid.NewGuid().ToString(),
        Manufacturer = new Manufacturer
        {
            Name = "CCC",
            Adress = "YYY"
        }
    });

    context.SaveChanges();
}