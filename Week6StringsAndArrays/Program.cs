// "hello, world!" length is 13 characters
// index of last character is always length - 1
string hello = "hello, world!";
int stringLength = hello.Length;
Console.WriteLine($"The length of string '{hello}' is {stringLength} characters.");

// string with additional space in the end
string helloWithSpace = "hello, world! ";
int stringLengthWithSpace = helloWithSpace.Length;
Console.WriteLine($"The length of string '{helloWithSpace}' is {stringLengthWithSpace} characters.");

// trimmed string
string trimmedhelloWithSpace = helloWithSpace.Trim();
stringLengthWithSpace = trimmedhelloWithSpace.Length;
Console.WriteLine($"I trimmed it! The length of string '{trimmedhelloWithSpace}' is {stringLengthWithSpace} characters.");

// best practices - assiging trimmed version back to myString
string myString = " hello, world! ";
int myStringLength = myString.Length;
myString = myString.Trim();

// Looping over the string to count the characters and words
int wordCounter = 1;
for (int i = 0; i < myString.Length; i++)
{

    //character is space - option 1
    /*if (myString[i] == ' ')
    {
        Console.WriteLine($"{i} character: [SPACE]");
        wordCounter++;
    }*/

    //character is space - option 2
    if (char.IsWhiteSpace(myString[i]))
    {
        Console.WriteLine($"{i} character: [SPACE]");
        wordCounter++;
    }
    else
    {
        Console.WriteLine($"{i} character: {myString[i]}");
    }
}
Console.WriteLine($"The length of string '{myString}' is {myString.Length} characters and {wordCounter} words.");

// defining new string
string lowerCaseString = " we are the champions? ";
int lowerCaseStringLength = lowerCaseString.Length;
lowerCaseString = lowerCaseString.Trim();

// first symbol of the string
char firstLetter = lowerCaseString[0];
Console.WriteLine($"First letter before replace: {firstLetter}");

// using replace method to change first letter to capital letter + chaining replace()
lowerCaseString = lowerCaseString.Replace(lowerCaseString[0], char.ToUpper(lowerCaseString[0])).Replace("?","!");
firstLetter = lowerCaseString[0];

Console.WriteLine($"First letter after replace: {firstLetter}");
Console.WriteLine($"lowerCaseString: {lowerCaseString}");