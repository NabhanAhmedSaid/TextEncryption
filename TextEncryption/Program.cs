Console.WriteLine("Enter your secret text");
string text = Console.ReadLine();
if (text != null)
{
    string textHash = BCrypt.Net.BCrypt.EnhancedHashPassword(text,13);
    Console.Clear();
    Console.WriteLine(textHash);
    
}
else
{
    Console.WriteLine("Please enter you text");
}
