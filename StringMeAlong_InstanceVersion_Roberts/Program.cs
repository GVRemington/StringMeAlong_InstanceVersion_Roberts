

using StringMeAlong_InstanceVersion_Roberts;

string toManipulate = "Sunbeam Tiger";

StringManager myManager = new StringManager(toManipulate);

Console.WriteLine(myManager.goBackwards("Sunbeam Tiger"));
Console.WriteLine(myManager.ToString());
Console.WriteLine("\t\nIs ABBA Symetrical?  " + myManager.symetrical("ABBA"));
Console.WriteLine("\t\nIs ABA  Symetrical?  " + myManager.symetrical("ABA"));
Console.WriteLine("\t\nIs ABba Symetrical?  " + myManager.symetrical("ABba"));
Console.WriteLine("\t\n Does Sunbeam Tiger = Sunbeam Tiger? " + (myManager.Equals("Sunbeam Tiger")));
Console.WriteLine("\t\n Does Tiger Sunbeam = Sunbeam Tiger? " + (myManager.Equals("Tiger Sunbeam")));

//Console.WriteLine(StringManager.casePreservation("Lets Give This A Try"));//not working correctly I remarked it out
