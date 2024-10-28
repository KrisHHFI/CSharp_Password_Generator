class Program
{
    static readonly List<string> passwordList = [];
    static string password = "";
    static readonly int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
    static readonly string[] letters =
     ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
    "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
    static readonly string[] symbols =
     ["!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=", "{", "}", "[", "]", ":", ";", "\"", "'", "<", ">", ",", ".",
    "?", "/", "|", "\\", "~", "`"];

    static string GeneratePassword()
    {
        for (int i = 1; i <= 20; i++)
        {
            int numberOrLetterOrSymbol = new Random().Next(1, 4);

            if (numberOrLetterOrSymbol == 1)
            {
                int chosenNumber = new Random().Next(0, numbers.Length);
                passwordList.Add(numbers[chosenNumber].ToString());
            }
            else if (numberOrLetterOrSymbol == 2)
            {
                int chosenLetter = new Random().Next(0, letters.Length);
                passwordList.Add(letters[chosenLetter]);
            }
            else if (numberOrLetterOrSymbol == 3)
            {
                int chosenSymbol = new Random().Next(0, symbols.Length);
                passwordList.Add(symbols[chosenSymbol]);
            }
        }

        password = String.Join("", passwordList);

        return password;
    }

    static void PrintPassword(string password)
    {
        Console.WriteLine("Generated password: " + password);
    }

    static void Main()
    {
        GeneratePassword();
        PrintPassword(password);
    }
}