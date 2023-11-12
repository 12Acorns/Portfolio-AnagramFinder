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
			Anagram.DoesStringContainAnagram(_anagramInput, _comparerInput, out int[] _output);
		}
	}
}