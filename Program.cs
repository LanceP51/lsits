using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------------ Lightning Exercise: Looping and .Add ------------ //
            // 1. Create a list of strings. Each string should represent an employee at the zoo. Add your own name in there somewhere.
            // 2. Loop through the list of names and print each one to the console.
            List<string> zooEmployees = new List<string>(){
                "Dave", "Jeb", "Zoey", "Caleb"
            };
            zooEmployees.Add("Lance");
            foreach (string singleZooEmployee in zooEmployees)
            {
                Console.WriteLine(singleZooEmployee);
            };
            // .Find method
            string employeeOfTheMonth = zooEmployees.Find(employee => employee == "Jeb");
            Console.WriteLine(employeeOfTheMonth);
            // ForEach Method, not the foreach loop (basically the same)
            zooEmployees.ForEach(employee => Console.WriteLine(employee));

            // Practice Exercises
            // ----------Planets
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string> { "Neptune", "Pluto" };
            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");
            planetList.Add("Charon");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Charon");

            foreach (String planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            };

            foreach (String planet in planetList)
            {
                Console.WriteLine(planet);

            };
            // ------------Numbers
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
};
            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"list contains {i}");
                }
                else
                {
                    Console.WriteLine($"list does not contain {i}");
                }

            };
            // -------------Dictionaries
            // Lightning Ex's
            // 1. Create a dictionary to represent the menu at the taco shop. Each KeyValuePair in the dictionary should have a key of a string that represents the name of the menu item and a value that represents its price (double).
            // 2. Create a dictionary to represent the employees at the taco shop. Each KeyValuePair should have a key of a string that represents the employee's name and a value of a string that represents their favorite menu item.
            Dictionary<string, double> tacoMenu = new Dictionary<string, double>(){
                {"empanada", 1.99},
                {"soft taco", 0.99},
                {"nachos", 4.99},
                {"queso", 1.49}
            };
            Dictionary<string, string> tacoShopEmployees = new Dictionary<string, string>(){
                {"Frida","empanada"},
                {"Caiou","soft taco"},
                {"Mary","nachos"},
                {"Chico","queso"}
            };
            foreach (KeyValuePair<string, string> employee in tacoShopEmployees)
            {
                Console.WriteLine($"{employee.Key}'s favorite menu item is the {employee.Value} for ${tacoMenu[employee.Value]}.");
            };
            // ------Dictionary Practices
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#.");
            wordsAndDefinitions.Add("Swell", "This description of the C# Introduction course.");
            wordsAndDefinitions.Add("Nice", "A descriptive term of our instructor.");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Awesome"]);

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            };

            // Practice 2

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>(){
                    {"word", "excited"}
            };

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> sadWord = new Dictionary<string, string>(){
                    {"word", "sad"}
            };
            sadWord.Add("definition", "having, showing, or characterized by a lowered state of energy, enthusiasm, eagerness");
            sadWord.Add("part of speech", "adjective");
            sadWord.Add("example sentence", "I am sad to leave JavaScript!");

            dictionaryOfWords.Add(sadWord);

            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> word in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in word
                )
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                };
            };
            // --------English Idioms Practice

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });


            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                Console.WriteLine($"{idiom.Key}: {String.Join(" ", idiom.Value)}");
            };
            
        }
    }
}
