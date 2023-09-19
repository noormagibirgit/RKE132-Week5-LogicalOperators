// OR - operaator , paindlikum. 
// Math >= 90 OR Chemistry >= 90   , matemaatikas või keemias rohkem kui 90 p, siis saab sisse astuda ülikooli 

// Math >= 90 OR Chemistry >= 90 OR Biology >= 90  - siin peab tooma AND operaatori , kui juba kolm tingimust

// Math && chemistry || math && biology || chemistry && biology  - matem ja keemia peavad olema rohkem kui 90p, või mat ja bioloogia rohkem kui 90 p jne. - Keerulisem veidi

int math, biology, chemistry;  // muutujad mis pannakse vahemälus valmis, kui panen rakenduse tööle. biloogia võib sisse jääda lihtsalt. 

Console.WriteLine("Enter yout Math result:");
math = Int32.Parse(Console.ReadLine());  // konvereerimine 

Console.WriteLine("Enter your Bilogy result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result");
chemistry = Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >= 90 ) || (math >= 90 && biology >= 90 ) || (chemistry >= 90 && biology >= 90))  // ehk kui matemaatika või keemia on suurem võrne 90 p, siis tulemus on true ja saab ülikooli sisse. 
{
    Console.WriteLine("Congratulations ! You got accepted");
}
else
{

    Console.WriteLine("Your application can´t be approved");

}