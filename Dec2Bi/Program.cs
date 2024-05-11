using System.Numerics;

bool isValid = true;

do
{
    Console.WriteLine("Digite o número que deseja converter para decimal:");
    string? decimalInput = Console.ReadLine();
    bool isValidParse = int.TryParse(decimalInput, out int parsedDecimal);

    if(isValidParse)
    {
        string result = "";
        int divisionResult = parsedDecimal;
        while (divisionResult != 1)
        {
            int division = divisionResult / 2;
            string remainer = Convert.ToString(divisionResult % 2);
            
            divisionResult = division;
            result = remainer + result;
            
        }
        Console.WriteLine("1" + result);
    }
    else
    {
        Console.WriteLine("Insira úm número decimal!");
    }
} while (isValid);
