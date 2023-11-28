// "kobieta poniżej 30 lat"
// "Ewa lat 33"
// "Niepełnoletni męszczyzna"

bool isWommen = true;
int age = 18;
string name = "Ewa;";

if (isWommen == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 )
{
    Console.WriteLine("Ewa lat 33");
}
else if (isWommen == false && age < 18)
{
    Console.WriteLine("Niepełnoletni męszczyzna");
}
else
{
    Console.WriteLine("Ktoś inny");
}
     















