using System;

class Firm
{
    static void Main()
    {
        Console.Write("Firm Name: ");
        string firmName = Console.ReadLine();
        Console.Write("Firm Address: ");
        string firmAddress = Console.ReadLine();
        Console.Write("Firm Telephone: ");
        string firmTelephone = Console.ReadLine();
        Console.Write("Firm Fax: ");
        string firmFax = Console.ReadLine();
        Console.Write("Firm Website: ");
        string firmWeb = Console.ReadLine();
        Console.Write("Manager`s First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager`s Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager`s Telephone: ");
        string telephone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Dear Mr/Mrs,");
        Console.Write("We would like to introduce you {0}, which is located at {1}. ", firmName, firmAddress); 
        Console.Write("If you like the adverisement you can call {0} and connect with us. ", firmTelephone);
        Console.WriteLine("Another way to connect with us is by sending a fax at {0} or sending a question at {1}. ", firmFax, firmWeb);
        Console.WriteLine("The manager {0} {1} leads {2} and his telephone number is {3}. ", firstName, lastName, firmName, telephone);
        Console.WriteLine("Have a nice day!\n{0}\n", firmName);
    }
}
