using System;
namespace HangmanUpdate
{
    public class RandomWord
    {
       
            Random rnd = new Random();
            string[] wordlist = new string[]
            { "Patriots" , "Vikings","Chargers", "Panthers",
            "Saints","Bengals", "Cardinals","Bears", "Texans"};

            public string getRandom()
            {
                int index = rnd.Next(wordlist.Length);
                return wordlist[index];
            }
    }
    
}
