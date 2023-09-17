var name = "Ewa";
var age = 17;
var gender = "M";

if(gender=="F" && age < 30)
    
{
    Console.WriteLine("Kobieta ponizej 30 lat.");
}

else if(name == "Ewa" && age == 33)

{
    Console.WriteLine("Ewa, lat 33.");
}

else if(gender!="F" && age <= 17) 

{
    Console.WriteLine("Niepelnoletni mezczyzna.");
}
