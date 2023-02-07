//string[] colors = { "red", "green", "blue", "pink", "yellow" };

//foreach (string color in colors)
//{
//    colors = colors.ToUpper();
//}

//for (int i = 0; i < colors.Length; i++)
//{
//    colors[i] = colors[i].ToUpper();
//}

//string[] tastyTakeouts = { "mySushi", "peetriPizza", "mcDonalds", "KFC", "armuduShashlik" };

//Random rnd = new Random();

//int randomIndex = rnd.Next(0, tastyTakeouts.Length);

//int randomIndex = rnd.Next(0, tastyTakeouts.Length);

//Console.WriteLine($"Random number is {randomIndex}. Tonight we are going to order from {tastyTakeouts[randomIndex]}.");


//string[] colors = { "red", "green", "blue", "pink", "yellow" };

//Random rnd = new Random();

//int randomColor = rnd.Next(0, colors.Length);

//Console.WriteLine($"You should wear {colors[randomColor]} today.");



//string[] colors = { "red", "green", "blue", "pink", "yellow" };

//for (int i = 0; i > 5; i--; ) {
//    Console.WriteLine([i]);
//}


//for (int i = 0; i < citiesArrayLength; i++)
//{
//    Console.WriteLine($"{cities[i]}");
//}

//string hello = "Hello, world!".Trim();
//int spaceCounter = 0;

//for (int i = 0; i < hello.Length; i++) { 
//    if (char.IsWhiteSpace(hello[i])) {
//        spaceCounter++;
//    }
//}
//Console.WriteLine(spaceCounter + 1);


//string hello1 = " hello ".Trim();
//int hello1Length = hello1.Length;
//Console.WriteLine($"{hello1Length}");

//string hello2 = " hello ";
//int hello2Length = hello2.Length;
//Console.WriteLine($"{hello2Length}");

//string hello3 = " hello";
//int hello3Length = hello3.Length;
//Console.WriteLine($"{hello3Length}");

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//string[] myNumbers = { "1, 2, 3", "4, 5, 6", "7, 8, 9" };
//string[] colors = { "red", "green", "blue", "pink", "yellow" };
//string[] seasons = { "autumn", "winter", "spring", "summer" };

//int numbersLength = numbers.Length;
//Console.WriteLine($"There are {numbersLength} items in your array:");

//int myNumbersLength = myNumbers.Length;
//Console.WriteLine($"There are {myNumbersLength} items in your array:");

//int colorsLength = colors.Length;
//Console.WriteLine($"There are {colorsLength} items in your array:");

//int seasonsLength = seasons.Length;
//Console.WriteLine($"There are {seasonsLength} items in your array:");




//string hello = "hello!";
//Console.WriteLine($"Before: {hello}");

//hello = hello.Replace(hello[0], char.ToUpper(hello[0]));
//Console.WriteLine($"After: {hello}");



//string hello = "HeLLo, world!".ToLower();
//int counter = 0;

//for (int i = 0; i < hello.Length; i++)
//{
//    if (hello[i] == 'l') {
//       counter++;
//    }
//}

//Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");




//string[] colors = { "red", "green", "blue", "pink", "yellow" };
//for (int i = colors.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(colors[i]);
//}

//string[] colors = { "red", "green", "blue", "pink", "yellow" };
//for (int i = colors.Length - 1; i >=  0; i--)
//{
//    Console.WriteLine($"{colors.Length - 1}. {colors[i]}");
//}




//string[] colors = { "red", "green", "blue", "pink", "yellow" };
//Random rnd = new Random();
////int randomColor = colors[rnd.Next(0,colors.Length)]; //Visual Studio karjub selle peale
//int randomColor = rnd.Next(0, colors.Length);
//Console.WriteLine($"You should wear {colors[randomColor]} today.");


string[] colors = { "red", "green", "blue", "pink", "yellow" };
Random rnd = new Random();

string randomColor = colors[rnd.Next(0, colors.Length)];
Console.WriteLine($"randomColor: {randomColor}");

Console.WriteLine($"You should wear {randomColor} today.");


