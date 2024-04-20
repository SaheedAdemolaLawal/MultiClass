class Pig : Animal // derived class - inherited from the base class (animal)
{
    public string Owner { get; set; }
    public string Colour { get; set; }

    //AnimalsRun () method in the class Pig is defined by keyword "override" to allow the keyword to be override and redefine.
    public override void AnimalsRun()
    {
        Console.WriteLine("Pigs run slowly");
    }
}