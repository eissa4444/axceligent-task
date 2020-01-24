using System;

namespace AlexaSettings
{
    class Program
    {
        private static void Main(string[] args)
{
    var alexa = new Alexa();
    Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

    alexa.Configure(x =>
    {
        x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
        x.OwnerName = "Bob Marley";
    });

    Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

    Console.WriteLine("press any key to exit ...");
    Console.ReadKey();

}

    }
}
