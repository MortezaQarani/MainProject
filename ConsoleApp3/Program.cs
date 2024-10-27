
string firstName;
string lastName;
long phoneNumber;
string phone="";
int age=0;
bool ageFlag = true;
bool phonNumberFlag = true;
Console.ForegroundColor = ConsoleColor.Green;
int top = Console.GetCursorPosition().Top;
Console.WriteLine("Please ente your first name:");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition("Please ente your first name:".Length,top);
firstName = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Green;
top = Console.GetCursorPosition().Top;
Console.WriteLine("Please ente your last name:");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.SetCursorPosition("Please ente your last name:".Length + 1, top);
lastName = Console.ReadLine();
while (ageFlag)
{
    top = Console.GetCursorPosition().Top;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please ente your age:");
    try
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition("Please ente your age:".Length + 1, top);
        age = int.Parse(Console.ReadLine());
        ageFlag = false;
        if (age < 15 || age > 130)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your registration faild. because, your age is out of range.");
            Console.ReadKey();
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("invalid value.");
    }
}

while (phonNumberFlag)
{
    top = Console.GetCursorPosition().Top;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please ente your phone number:");
    Console.SetCursorPosition("Please ente your phone number:".Length + 1, top);
    Console.ForegroundColor = ConsoleColor.Yellow;
    phone = Console.ReadLine();
    try
    {
        if ((phone.Length == 11 && phone.StartsWith('0')) || (phone.Length == 10 && !phone.StartsWith('0')))
        {
            phoneNumber = long.Parse(phone);
            phone = phoneNumber.ToString();
            phonNumberFlag = false;
        }
        else if (phone.Length == 13 && phone.StartsWith("+98"))
        {
            phone = phone.Remove(0, 3);
            phoneNumber = long.Parse(phone);
            phonNumberFlag = false;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid phone number.");
            phonNumberFlag = true;
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid character in phone number.");
        phonNumberFlag = true;
    }
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"\nA user was registered with the following information:\nName: {firstName} {lastName}\nPhone number: 0{phone}\nAge: {age} ");

