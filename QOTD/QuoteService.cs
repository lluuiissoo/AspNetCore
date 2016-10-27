
using System;
using System.IO;

public interface IQuoteService
{
    string GetRandomQuote();
}

public class QuoteService : IQuoteService
{
    string[] quotes;

    public QuoteService()
    {
        quotes = File.ReadAllLines("quotes.txt");
    }

    public string GetRandomQuote()
    {
        var randomQuote = quotes[new Random().Next(0, quotes.Length-1)]; 

        return randomQuote;
    } 
}