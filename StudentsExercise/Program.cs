using StudentsExercise.Models;

Student peter = new("Peter", 'C', 2);
Console.WriteLine(peter.Name); // Peter
Console.WriteLine(peter.Grade); // C

peter.Upgrade();
Console.WriteLine(peter.Grade); // B

peter.Upgrade();
Console.WriteLine(peter.Grade); // A

peter.Upgrade();
Console.WriteLine(peter.Grade); // A

peter.Downgrade();
Console.WriteLine(peter.Grade); // B

Console.ReadLine();