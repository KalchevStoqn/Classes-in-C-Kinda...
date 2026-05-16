
namespace ConsoleApp1;

class program 
{
 

    static void Main(string[] args)
    {
        //  okay first: Create a new Car object using the constructor. And add all the things you typed in!

        Devil devil = new Devil(true, "red", "Dante", 1000000);

        // now second:  Access properties

        Console.WriteLine($"the {devil.Colour} devil has {devil.Aura}  aura, and his name is {devil.Name} ,and the devil has {devil.Horns}!");

        // third: You call your methods!
        devil.Destruction(1000000);
        
    }
}

