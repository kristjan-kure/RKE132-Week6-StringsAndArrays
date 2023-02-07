//string array - can only hold same type members
//string[] cities = {"London", "Paris", "Tallinn", "Helsinki"}; 

//cant add once you define the size of the array
string[] cities = new string[3];

cities[0] = "london";
cities[1] = "paris";
cities[2] = "tallinn";

//Console.WriteLine($"{cities[0]}, {cities[1]}, {cities[2]}");

// Array length
int citiesArrayLength = cities.Length;
Console.WriteLine($"There are {citiesArrayLength} items in your array:");

// Looping over array length
for (int i = 0; i < citiesArrayLength; i++)
{
    Console.WriteLine($"{cities[i]}");
}

// Foreach loop - cant change array
Console.WriteLine($"\nForeach loop:");
foreach (string value in cities)
{
   Console.WriteLine(value);
}

// Changing the values
Console.WriteLine($"\nCapitalizing first letters:");
for (int i = 0; i < citiesArrayLength; i++)
{
    cities[i] = cities[i].Replace(cities[i][0], char.ToUpper(cities[i][0]));
    Console.WriteLine($"{cities[i]}");
}

