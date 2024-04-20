using System.Security.Cryptography.X509Certificates;

class Dog : Animal
{
    public string Owner { get; set; }
    public string Colour { get; set; }

    //AnimalsRun () method in the class Dog is defined by keyword "override" to allow the keyword to be override and redefine.
    public override void AnimalsRun()
    {
        Console.WriteLine("Dogs run after rudents");
    }
  
}

