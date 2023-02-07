int[] numbers = new int[10];
Random rnd = new Random();

int sum = 0;

// Poupulating the array
for (int i = 0; i < numbers.Length; i++)
{
    //generating numbers from 1 to 9 (less than 10). To include 10, add one.
    numbers[i] = rnd.Next(1,numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach(int i in numbers)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Total: {sum}");