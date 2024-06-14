Console.WriteLine("Input string:");
var input = Console.ReadLine();

var (vowels, consonants, otherCharacters) = CountVowelsAndConsonants(input.ToLower());

Console.WriteLine($"Vowels: {vowels}");
Console.WriteLine($"Consonants: {consonants}");
Console.WriteLine($"Numbers and special characters: {otherCharacters}");

(object vowels, object consonants, object otherCharacters) CountVowelsAndConsonants(string input)
{
    var vowelsSet = "aeiou";
    var consonantsSet = "bcdfghjklmnpqrstvwxyz";
    int vowels = 0, consonants = 0, otherCharacters = 0;

    foreach (var character in input)
    {
        if (vowelsSet.Contains(character))
        {
            vowels++;
        }
        else if (consonantsSet.Contains(character))
        {
             consonants++;
        }
        else
        {
            if(!char.IsWhiteSpace(character))
            {
                otherCharacters++;
            }
        }
    }

    return (vowels, consonants, otherCharacters);
}