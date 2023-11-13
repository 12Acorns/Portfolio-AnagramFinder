using AnagramFinderApp.Utility;

namespace AnagramFinderApp.AnagramHandler
{
    internal static class Anagram
    {
        public static bool DoesStringContainAnagram(string _anagram,
            string _anagramComparer,
            out Span<int> _output)
        {
			int[] _letterFrequency = new int[26];
            for (int i = 0; i < _anagramComparer.Length; i++)
            {
                _letterFrequency[ConversionUtility.CharToIndex(_anagramComparer[i])]++;
            }

            int[] _indices = new int[_anagram.Length];
            int _indicesIndex = 0;

			for (int i = 0; i <= _anagram.Length - _anagramComparer.Length; i++)
            {
				int[] _anagramLetterFrequency = new int[26];
                for (int j = 0; j < _anagramComparer.Length; j++)
                {
                    _anagramLetterFrequency[ConversionUtility.CharToIndex(_anagram[i + j])]++;
                }
                if (_letterFrequency.SequenceEqual(_anagramLetterFrequency))
                {
                    _indices[_indicesIndex] = i;
                    _indicesIndex++;
				}
            }

            if(_indicesIndex == 0)
            {
				_output = Array.Empty<int>();
				return false;
            }

            _output = _indices.AsSpan()[.._indicesIndex];
			return true;
		}
    }
}