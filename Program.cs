using System;

namespace PickRandomCards
{
  class Program
  {
    static void Main(string[] args)
    {
      bool result = true;
      while(result)
      {
        Console.Write("Enter the number of cards to pick: ");
        string? line = Console.ReadLine();

        if(int.TryParse(line, out int numberOfCards))
        {
          foreach(string card in CardPicker.PickSomeCards(numberOfCards))
          {
            Console.WriteLine(card);
            result = false;
          }
        }
        else
        {
          Console.WriteLine("Please give valid number of cards that you need");
        }
      }
    }
  }
  class CardPicker
  {
    static Random random = new Random();
    public static string[] PickSomeCards(int numberOfCards)
    {
      string[] pickedCards = new string[numberOfCards];
      for(int i = 0; i < numberOfCards; i++)
      {
        pickedCards[i] = RandomValue() + " of " + RandomSuit();
      }
      return pickedCards;
    }
    private static string RandomSuit()
    {
      int value = random.Next(1,5); // 1-4 cenli
      switch(value)
      {
        case 1: return "Spades";
        case 2: return "Hearts";
        case 3: return "Clubs";
        default: return "Diamonds";
      }
    }
    private static string RandomValue()
    {
      int value = random.Next(1,14);
      switch(value)
      {
        case 1: return "Ace";
        case 11: return "Jack";
        case 12: return "Queen";
        case 13: return "King";
        default: return value.ToString();
      }
    }
  }
}