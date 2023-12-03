using Task2;

var converter = new Converter(36M, 40M, 8.5M);
const decimal uah = 100M;
const decimal usd = 3600M;
const decimal eur = 4000M;
const decimal pln = 850M;

PrintConverter(converter.UahToEur, eur);
PrintConverter(converter.UahToPln, pln);
PrintConverter(converter.UahToUsd, usd);

PrintConverter(converter.EurToUah, uah);
PrintConverter(converter.PlnToUah, uah);
PrintConverter(converter.UsdToUah, uah);

void PrintConverter(Func<decimal, decimal> func, decimal arg)
{
    var result = func(arg);
    var name = func.Method.Name;
    var splitName = name.Split("To");
    var fromName = splitName[0].ToLowerInvariant();
    var toName = splitName[1].ToLowerInvariant();

    Console.WriteLine($"{fromName} to {toName}: {arg} -> {result}");
}