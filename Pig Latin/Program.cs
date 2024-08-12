using System.Globalization;
using System.Xml.Serialization;

/*
 string username = "Admin";
 string uName = "admin";
 Console.WriteLine(username.Equals(uname, StringComparison.OrdinallgnoreCase));
 */

// look up white space built into C#
// ✔

/*
 TASK:
  - TRANSLATE ENGLISH TO PIG LATIN

BUILD SPECS:
    ✔ 1. PROMPTS USER FOR WORDS
    2. TRANSLATES TEXT TO PIG LATIN AND DISPLAYS TO CONSOLE
    3. ASKS USER IS THEY WANT TO ADD ANOTHER WORD
    ✔ 4. CONVERT WORD TO LOWERCASE BEFORE TRANSLATING 
    ✔ 5. WORD STARTS WITH VOWEL (A, E , I, O, U):
        - ADD "WAY" TO ENDING 
    ✔ 6. WORD STARTS WITH CONSONANT (EVERYTHING THAT ISN'T A VOWEL): 
        - MOVE ALL OF CONSONANTS THAT APPEAR BEFORE VOWEL TO END OF WORD
        - ADD "AY" TO END OF WORD
    ✔ 7. KEEP CASE OF WORDS:
        - UPPERCASE (WORD)
        - lowercase (word)
        - Title Case (Word)
    8. Allow punctuation in input string 
    9. Translate words with contractions 
*/

/*
                                  FAILED ATTEMPT AT USING A METHOD???????
static bool VowelChecker()
{
    string input = Console.ReadLine(); 
    string vowelFirstWord = input.Substring(0, 1);
    if (vowelFirstWord == "a" || vowelFirstWord == "e" || vowelFirstWord == "i" || vowelFirstWord == "o" || vowelFirstWord == "u")
    {
        return true;
    }
    else
    {
        return false;
    }
}
*/


// 1. prompts user for words
Console.WriteLine("Please enter word.");
string wordOriginal = Console.ReadLine();

// 4. convert to lowercase 
string wordProxy = wordOriginal.ToLower();
// Console.WriteLine(word.Length); // say the length of word

// 5. vowels
string vowelCheck = wordProxy.Substring(0, 1); // rock returns r AKA first letter of word 
string letterMover = wordOriginal.Substring(1) + wordOriginal.Substring(0,1); // black = lackb

// create a bool that returns true/false if there is vowel present
bool vowelsPresent = true;
if (vowelsPresent)
{
    if (vowelCheck == "a" || vowelCheck == "e" || vowelCheck == "i" || vowelCheck == "o" || vowelCheck == "u")
    {
        vowelsPresent = true;
    }
    else
    {
        vowelsPresent = false;
    }
}
if (vowelsPresent) // if vowel present 
{
    Console.WriteLine($"{wordOriginal}" + "way");
}

// 6. consonants -- FIND A WAY TO MAKE THIS LOOP
else // that means there is no vowel present 
{ 
    for (int v = 0; v < wordProxy.Length; v++) 
    {
        char currentLetter = wordProxy[v];
        if (currentLetter != 'a' || currentLetter != 'e' || currentLetter != 'i' || currentLetter != 'o' || currentLetter != 'u')
        {
            letterMover = wordOriginal.Substring(1) + wordOriginal.Substring(0,1);
        }
    }
    Console.WriteLine($"{letterMover}" + "ay");
}

    
    
    
    /*
    letterMover = wordOriginal.Substring(1) + wordOriginal.Substring(0,1);
    Console.WriteLine(letterMover + "              HERE 1");
    if (!vowelsPresent)
    {
        letterMover = letterMover = wordOriginal.Substring(2) + wordOriginal.Substring(0,2);
        Console.WriteLine(letterMover + "                     HERE 2");
    }
    else
    {
        Console.WriteLine(letterMover);
    }
    Console.WriteLine($"{letterMover}" + "ay");
}*/

// 7. casing
// convert word all into one case 

static bool hasSpecialChar(string input)
{
    string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
    foreach (var item in specialChar)
    {
        if (input.Contains(item)) return true;
    }
    return false;
}


// loop through letters 
/*string m10 = "Cookie";
for (int i = 0; i < m10.Length; i++)
{
    char currentLetter = m10[i]
    Console.WriteLine(currentLetter);
    if (currentLetter )
}
*/












/*
string hello = "AAAAA";
string wordPlay = hello.ToLower();
Console.WriteLine(wordPlay);
vowelCheck = wordPlay.Substring(0, 1); // rock returns r AKA first letter of word 
Console.WriteLine(vowelCheck);
if (vowelCheck == "a") 
{
    Console.WriteLine("hell yeah brother");
    Console.WriteLine(hello);
}
else
{
    Console.WriteLine("do nothing");
}
*/