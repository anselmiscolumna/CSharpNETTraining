// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
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

/* ***Code Block and Variable Demo*** */

/*
bool flag = true;
int value = 0;

if (flag)
{
  Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

if(flag) Console.WriteLine(flag);

string name = "steve";

if (name == "bob") 
  Console.WriteLine("Found Bob");
else if (name == "steve") 
  Console.WriteLine("Found Steve");
else 
  Console.WriteLine("Found Chuck");

*/
// ====================================================================================================================================================

/* ***Code Challenge for updating Problematic Code */

/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;


foreach (int number in numbers)
{
    total += number;

    if (number == 42)
      found = true;
}

if (found) 
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
*/

// ====================================================================================================================================================

/* ***Switch Statement Demo*** */

/*
switch (fruit)
{
  case "apple":
    Console.WriteLine($"App will display information for apple.");
    break;
  
  case "banana":
    Console.WriteLine($"App will display information for banana");
    break;

  case "cherry":
    Console.WriteLine($"App will display information for cherry.");
    break;
}
*/

// ====================================================================================================================================================

/* ***Employee Level and Name Demo*** */

/*
int employeeLevel = 300;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
  case 100:
  case 200:
    title = "Senior Associate";
    break;

  case 300:
    title = "Manager";
    break;

  case 400:
    title = "Senior Manager";
    break;

  default:
    title = "Associate";
    break;
}

Console.WriteLine($"{employeeName}, {title}");
*/

// ====================================================================================================================================================

/* ***Convert if-elseif-else blocks into Switch Case*** */


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

/* Switch Case Blocks
switch (product[0])
{
  case "01":
    type = "Sweat shirt"; 
    break;

  case "02":
    type = "T-Shirt";
    break;

  case "03":
    type = "Sweat pants";
    break;
  
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;

  case "MN":
    color = "Maroon";
    break;

  default:
    color = "White";
    break;
}

switch (product[2])
{
  case "S":
    size = "Small";
    break;

  case "M":
    size = "Medium";
    break;

  case "L":
    size = "Large";
    break;

  default:
    size = "One Size Fits All";
    break;
}

*/

/* If-elseif-else Blocks
if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}
*/
// Console.WriteLine($"Product: {size} {color} {type}");

// ====================================================================================================================================================

/* *** Foreach and For Loop Demos */

/*
for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
  Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
  Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
  if (i == 7) break;
}

string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--)
{
  Console.WriteLine(names[i]);
}

for (int i = 0; i < names.Length; i++)
  if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

*/

// ====================================================================================================================================================

/* ***Code Challenge FizzBuzz For Loops*** */

/*
for (int i = 0; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
    Console.WriteLine($"{i} - FizzBuzz");

  else if (i % 3 == 0)
    Console.WriteLine($"{i} - Fizz");

  else if (i % 5 == 0)
    Console.WriteLine($"{i} - Buzz");

  else
    Console.WriteLine(i);
}
*/

// ====================================================================================================================================================

/* ***Do While Loop Demo*** */
/*
Random random = new Random();
int current = random.Next(1, 11);


do
{
  current = random.Next(1, 11);

  if (current >= 8) continue;

  Console.WriteLine(current);
} while (current != 7);

*/
/*
while (current >= 3)
{
  Console.WriteLine(current);
  current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// ====================================================================================================================================================

/* ***Role Playing Hero Game (While - Do While Loop Challenge)*** */

/* My Solution for Role Playing Game
Random rand = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int attack = 0;

string winner = "";
string turn = "Hero";

do
{

  attack = rand.Next(1, 11);
  winner = turn;

  switch (turn)
  {
    case "Hero":
      monsterHealth -= attack;
      Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth}.");
      turn = "Monster";
      break;

    case "Monster":
      heroHealth -= attack;
      Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth}.");
      turn = "Hero";
      break;
  }

} while(monsterHealth > 0 && heroHealth > 0);

Console.WriteLine($"{winner} wins!");
*/

/* Solution from Learning Path
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/

// ====================================================================================================================================================

/* ***User Input Challenge with Do While*** */

string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10 ");


do
{
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber == true)
    {
      if(!(numericValue > 5 && numericValue < 10))
        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
    }
    else
      Console.WriteLine("Sorry, you entered an invalid number, please try again");
  }
} while (!(numericValue > 5 && numericValue < 10));
Console.WriteLine($"Your input value ({numericValue}) has been accepted.");

Console.WriteLine($"Enter your role name (Administrator, Manager, or User)");

bool validEntry = false;
string role = "";

do
{
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    role = readResult.Trim().ToLower();

    if(role == "administrator" || role == "manager" || role == "user")
      validEntry = true;

    else
      Console.WriteLine($"The role name that you entered, \"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
  }
}while(!validEntry);
Console.WriteLine($"Your input value ({role}) has been accepted.");