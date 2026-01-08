// See https://aka.ms/new-console-template for more information

var rand = new Random();
int flip = (int)rand.Next(0, 2);
Console.WriteLine($"The resulting face after the flip is {(flip == 1? "heads": "tails")}!");
