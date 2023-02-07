string[] tastyTakeouts = {"mySushi", "peetriPizza", "mcDonalds", "KFC", "armuduShashlik"};

Random rnd = new Random();

int randomIndex = rnd.Next(0, tastyTakeouts.Length);

Console.WriteLine($"Random number is {randomIndex}. Tonight we are going to order from {tastyTakeouts[randomIndex]}.");
