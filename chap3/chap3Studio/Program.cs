Console.WriteLine("Enter a word or phrase to count: ");
//string? text = Console.ReadLine();
string text = File.ReadAllText(@"C:\Users\ritab\Desktop\test.txt");
char[] chars = text.ToLower().ToCharArray();

Dictionary<char, int> charCounts = new Dictionary<char, int>();

foreach (char character in chars) {
    if (!Char.IsLetter(character)) {
        continue;
    }
    if (charCounts.ContainsKey(character)) {
        charCounts[character] += 1;
    } else {
        charCounts.Add(character, 1);
    }
}
foreach (KeyValuePair<char, int> count in charCounts) {
    Console.WriteLine(count.Key + ": " + count.Value);
}