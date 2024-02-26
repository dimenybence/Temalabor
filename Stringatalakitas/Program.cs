namespace Stringatalakitas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FirstCharacterRemove(input));
            Console.WriteLine(LastCharacterRemove(input));
        }

        static string FirstCharacterRemove(string text)
        {
            string[] words = text.Split(" ");
            for(int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = words[i].Substring(1);
                }
            }
            return string.Join(" ", words);
        }

        static String LastCharacterRemove(string text)
        {
            string[] words = text.Split(" ");
            for (int i = 0;i < words.Length;i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                }
            }
            return string.Join(" ", words);
        }
    }
}
