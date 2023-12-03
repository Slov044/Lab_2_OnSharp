namespace Task2;

public class Converter
{
    private readonly decimal _eur;
    private readonly decimal _pln;
    private readonly decimal _usd;

    public Converter(decimal usd, decimal eur, decimal pln)
    {
        _usd = usd;
        _eur = eur;
        _pln = pln;
    }

    public decimal UahToUsd(decimal amount)
    {
        return amount / _usd;
    }

    public decimal UahToEur(decimal amount)
    {
        return amount / _eur;
    }

    public decimal UahToPln(decimal amount)
    {
        return amount / _pln;
    }

    public decimal UsdToUah(decimal amount)
    {
        return amount * _usd;
    }

    public decimal EurToUah(decimal amount)
    {
        return amount * _eur;
    }

    public decimal PlnToUah(decimal amount)
    {
        return amount * _pln;
    }
}