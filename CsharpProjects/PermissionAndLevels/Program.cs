// Permission and Levels exercise

string permission = "User";
int level = 55;

if ((!permission.Contains("Admin") && !permission.Contains("Manager")) || (permission.Contains("Manager") && level < 20))
{
    Console.WriteLine("You do not have sufficient priveleges.");
}

else if (permission.Contains("Admin"))
{
    Console.WriteLine(level > 55? "Welcome, Super Admin user." : "Welcome, Admin user.");
}

else if (permission.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact an admin for access.");
}