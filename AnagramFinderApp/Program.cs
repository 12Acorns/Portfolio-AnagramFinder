using AnagramFinderApp.ConsoleHelper;
using AnagramFinderApp.AnagramHandler;

namespace AnagramFinderApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string _anagramInstruction = "Please enter a string containing only alphabetical values\n" +
				"that will be checked containing a anagram.";

			string _anagramInput =
				ConsoleUtility.EnsureStringLength(
				ConsoleUtility.EnsureInputType
				(ConsoleUtility.PromptUser(
					_anagramInstruction),
				InputType.OnlyString),
					 20100).ToLower();

			string _comparerInputInstruction = "Please enter a string containing the letter(s)/word to check\n" +
				"for a anagram.";

			string _comparerInput =
				ConsoleUtility.EnsureStringLength(
				ConsoleUtility.EnsureInputType
				(ConsoleUtility.PromptUser(
					_comparerInputInstruction),
				InputType.OnlyString),
					 20100).ToLower();

			if(!Anagram.DoesStringContainAnagram(_anagramInput, _comparerInput, out Span<int> _output))
			{
				Console.WriteLine("Failed to find anagram");
				return;
			}
			Console.Write("Found anagram(s): ");
			for (int i = 0; i < _output.Length; i++)
			{
				Console.Write($"{_output[i]}{((i == (_output.Length -1)) ? "" : ",")} ");
			}
			Console.WriteLine();
		}
	}
}