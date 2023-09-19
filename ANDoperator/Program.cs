//Math >= 90; ehk matemaatikas  pidi saama 90 p või rohkem. Biology >= 90, Chemistry >= 90;  - kuidas seda kontrollida
//
int math, biology, chemistry;  // muutujad mis pannakse vahemälus valmis, kui panen rakenduse tööle

Console.WriteLine("Enter yout Math result:");
math = Int32.Parse(Console.ReadLine());  // konvereerimine 

Console.WriteLine("Enter your Bilogy result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90  && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations ! You got accepted");
}
else
{

    Console.WriteLine("Your application can´t be approved");

}