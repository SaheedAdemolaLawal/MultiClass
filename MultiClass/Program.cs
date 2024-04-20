



    Pig pig = new Pig();
    pig.Name = "Hero";
    pig.SerialNumber = "A102";
    pig.Owner = "Ganduge";
    pig.Age = 2;
    pig.Colour = "White";

    Dog dog = new Dog();
    dog.Name = "Killer";
    dog.SerialNumber = "EC102";
    dog.Owner = "Rob";
    dog.Age = 3;
    dog.Colour = "Yellow";

    Console.WriteLine("The name of the dog that bit Yemi is "  + dog.Name + " and the dog is owned by "  + dog.Owner);

    Console.WriteLine(pig.Name + " is " + pig.Age + "years old");

    //sound overloaded to give sound for dog and pig
    pig.MakeSound("pig sounds: hnn hnn"); 
    dog.MakeSound("Dogs bark: gbou gbou");

    //overloaded to give discribe animal food
    dog.AnimalFeed("Feed on flesh");
    pig.AnimalFeed("Raw food");

    dog.AnimalsRun(); // overrun polymorphism
    pig.AnimalsRun(); //overrun polymorphism

