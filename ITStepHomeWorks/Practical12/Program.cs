using Practical12;
using System.Globalization;

List<Car> carsList = new List<Car>();


string csvPath = @"C:\Users\magda\Desktop\ITStepHomeWorks\ITStepHomeWorks\Practical12\vehicles.csv";
string[] lines = File.ReadAllLines(csvPath).Skip(1).ToArray();
foreach (string line in lines)
{
    if (string.IsNullOrWhiteSpace(line)) continue;

    string[] cars = line.Split(',');

    Car car = new Car()
    {
        Make = cars[0],
        Model = cars[1],
        Cylinder = int.Parse(cars[2]),
        Engine = double.Parse(cars[3], CultureInfo.InvariantCulture),
        Drive = cars[4],
        Transmission = cars[5],
        MileageInCity = int.Parse(cars[6]),
        CombinedMileage = int.Parse(cars[7]),
        MileageInHwy = int.Parse(cars[8]),
    };
    carsList.Add(car);
}

var allMercedeses = carsList.Where(c => string.Equals(c.Make, "Mercedes-Benz", StringComparison.OrdinalIgnoreCase)).ToList();

var theMostEconomicalCars = carsList
    .OrderByDescending(c => c.CombinedMileage)
    .ThenBy(c => c.Make)
    .ThenBy(c => c.Model)
    .Take(10)
    .ToList();

string listToShow = "All Mercedes: " + string.Join(", ", allMercedeses.Select(c => $"{c.Model} ({c.CombinedMileage})"));

Console.WriteLine(listToShow);
Console.WriteLine("\n");
Console.WriteLine("Most Economical Cars: " + string.Join(", ", theMostEconomicalCars.Select(c => $"{c.Make} {c.Model} ({c.CombinedMileage})")));