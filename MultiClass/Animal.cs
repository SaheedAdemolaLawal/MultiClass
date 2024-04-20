class Animal //Base Class inherited by dog and pig
{
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public int Age { get; set; }

    // Animal sound overloading
    public void MakeSound(string specificSound)
    {
        Console.WriteLine($"{specificSound}");

    }

    // Animal feed overloading
    public void AnimalFeed(string specificFeed) 
    {
        Console.WriteLine($"{specificFeed}"); 
    }

    //AnimalsRun () method in the class Animal is defined by keyword "virtual" to allow derived class override and redefine it
    public virtual void AnimalsRun()
    {
        Console.WriteLine("Animals run tiredlessly");
    }


}


