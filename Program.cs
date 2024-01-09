// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type in an integer...");

string? s = Console.ReadLine();

if(!double.TryParse(s, out double myNumber)){
    Console.WriteLine("Not a number!");
    Console.ReadKey();
    return;
}

//Make sure the number is an absolute
myNumber = Math.Abs(myNumber);

int totalLoops = 0;

do
{
    int potenciaDivisor = 1;
    double restoAnterior = 0;
    double soma = 0;
    bool flagBreak = false;

    do
    {
        double restoAtual = myNumber % Math.Pow(10, potenciaDivisor);
        soma += (restoAtual - restoAnterior) / Math.Pow(10, potenciaDivisor - 1);
        restoAnterior = restoAtual;
        potenciaDivisor++;

        if (restoAtual == myNumber)
        {
            flagBreak = true;
            myNumber = soma;
            totalLoops++;
        }
    } while (!flagBreak);

} while (myNumber >= 10);


Console.WriteLine($"Additive persistance: {totalLoops}");
Console.WriteLine($"Digital root: {myNumber}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

