// kuidas kasutada AND operaatorit, et vaadata mis vahemikus mis vahemikus väärtused asuvad, et seda kasutada otsuse tegemiseks. 

//  kui õhutemperatur on <= 0 - see on Freezing cold
// temp > 0 AND temp < 10 - Cold 
// temp >= 10 AND temp <= 15 - Chilly  - kui temperatuur on suurem kui 10 ja väiksem/võrnde 15 , siis on jahe 
// temp >= 15 AND temp < 20 - Warm  - kui temperatuur on suurem kui 15 ja väikem kui 20 
// temp >=20 AND temp < 30 - Hot 
// temp >=30 - Boiling hot 

Console.WriteLine("Enter the temperature");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Boling hot.");
}
else if (temp <= 30 && temp >= 20)
{
    Console.WriteLine("Hot.");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm.");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly");
}
else if(temp < 10 && temp > 0)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing cold");
}