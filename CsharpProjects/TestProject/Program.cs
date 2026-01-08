// See https://aka.ms/new-console-template for more information
using System;
// Getting started in C# with VSCode
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello C#!");

// ====================================================================================================================================================

// ***Call Methods of a .NET Class***
// Random dice = new Random();
// Random dice = new();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// The following line of code results in an error because the Random Class is not Stateless
// int result = Random.Next();

// ====================================================================================================================================================

// ***Overloaded Method Example***
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// ***Coding challenge: Math Class Implementation***
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// ====================================================================================================================================================

//*** Dice Conditional Example***
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // int roll1 = 6;
// // int roll2 = 6;
// // int roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }

//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }

// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }

// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }

// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// ====================================================================================================================================================

//***Boolean Expressions Example***
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// ====================================================================================================================================================

// ***Conditional Expiration Date Message Example***
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }

// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine("Your subscription expires within a day!");
// }

// else if (daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

// ====================================================================================================================================================

//***Fradulent Order String Array Example***
// string[] fradulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
// Console.WriteLine();

// string[] names = { "Rowena", "Robin", "Bao"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// ====================================================================================================================================================

// ***Inventory Array for ForEach Example***
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

// ====================================================================================================================================================

//***String Array Order ID ForEach Example***
// string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach (string id in orderIDs)
// {
//     if (id.StartsWith("B"))
//     {
//         Console.WriteLine(id);
//     }
// }

// ====================================================================================================================================================

/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// ====================================================================================================================================================

/* ***Coding Challenges for Guidelines on Improving Readability*** */
/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach(char letter in charMessage) 
{
    if (letter == 'o') 
    { 
        letterCount++; 
    }
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times");
*/

// ====================================================================================================================================================

/* ***Equality Operator Demo*** */

/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine("a" == "a ");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/

// ====================================================================================================================================================

/* ***Inequality Operator Demo*** */

/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/

// ====================================================================================================================================================

/* ***Evaluating Comparisons Demo*** */

/*
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/

// ====================================================================================================================================================

/* ***Methods Returning Booleans Demo*** */

/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cows"));

// Negate Boolean Logic
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False
*/

// ====================================================================================================================================================

/* ***Conditional Operator Demo*** */

/*
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/

// ====================================================================================================================================================
