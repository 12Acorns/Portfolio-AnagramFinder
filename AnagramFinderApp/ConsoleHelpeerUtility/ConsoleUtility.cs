using System.Text.RegularExpressions;

namespace AnagramFinderApp.ConsoleHelper
{
	internal class ConsoleUtility
	{
		public static string PromptUser(string _prompt)
		{
			Console.WriteLine(_prompt);
			string _responce = Console.ReadLine()!
				?? throw new NullReferenceException("Input cannot be empty.");
			return _responce;
		}
		public static string EnsureInputType(string _inputToCheck, InputType _inputType)
		{
			switch (_inputType)
			{
				case InputType.OnlyString:
					if (!Regex.Match(_inputToCheck, "^[a-zA-Z]+$").Success)
					{
						throw new Exception("String Contains non-alphabetical values");
					}
					break;
				case InputType.OnlyNumerical:
					if (!Regex.Match(_inputToCheck, "^[0-9]+$").Success)
					{
						throw new Exception("String Contains non-alphabetical values");
					}
					break;
			}
			return _inputToCheck;
		}
		public static string EnsureStringLength(string _input, int _maximumLength)
		{
			_maximumLength = Math.Min(_maximumLength, int.MaxValue);
			if(_input.Length > _maximumLength)
			{
				throw new ArgumentOutOfRangeException(nameof(_maximumLength));
			}
			return _input;
		}
	}
}