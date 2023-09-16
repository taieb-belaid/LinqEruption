List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// First eruption in Chili 
IEnumerable<Eruption> ChiliEruption = eruptions.Where(l => l.Location == "Chile").OrderBy(y => y.Year).Take(1).ToList();
PrintEach(ChiliEruption, "First chili eruption");

// First Hawaiian Is eruption 

IEnumerable<Eruption> hawaiian = eruptions.Where(l => l.Location == "Hawaiian Is").OrderBy(y => y.Year).Take(1).ToList();
if (hawaiian != null)
{
    PrintEach(hawaiian, "First hawaiian eruption");
}
else
{
    Console.WriteLine("No hawaiian is eruption found");
}

// First  New Zealand eruption after 1900

IEnumerable<Eruption> zealand = eruptions.Where(l => l.Location == "New Zealand" && l.Year > 1900).Take(1).ToList();
PrintEach(zealand,"first new zealand after 1900");

// Volcano ELevation Over 2000m

IEnumerable<Eruption> elevation = eruptions.Where(e=> e.ElevationInMeters > 2000).ToList();
PrintEach(elevation,"Volcanoelevation over 2000");

// Volcano name start with L and how many eruption found

IEnumerable <Eruption> volcano = eruptions.Where(v=> v.Volcano.StartsWith("L")).ToList();
Console.WriteLine(volcano.Count());
PrintEach(volcano,"volcano start with L");

// The highest elevation

int MaxElevation = eruptions.Max(e=>e.ElevationInMeters);
Console.WriteLine(MaxElevation);

IEnumerable <Eruption> nameHightElevat = eruptions.Where(e=> e.ElevationInMeters == MaxElevation).ToList();
PrintEach(nameHightElevat,"volcano high elevation");

// all volcano ordered 
IEnumerable <Eruption> orderedVolcano = eruptions.OrderBy(a => a.Volcano).ToList();
PrintEach(orderedVolcano,"alphabetic ordered volcano");

// all volcano ordered and erupted befor year 1000
IEnumerable <Eruption> orderedVolcanoBefore = eruptions.Where( a=>a.Year < 1000).OrderBy(o=>o.Volcano).ToList();
PrintEach(orderedVolcanoBefore,"alphabetic ordered volcano Before 1000av");

// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
