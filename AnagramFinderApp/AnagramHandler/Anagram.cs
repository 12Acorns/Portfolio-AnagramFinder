namespace AnagramFinderApp.AnagramHandler
{
    internal class Anagram
    {
        public static bool DoesStringContainAnagram(string _anagram, string _anagramComparer, out int[] _output)
        {
            int[] _valueIndex = Array.Empty<int>();
            int _valueIndexCurrentRange = 0;
            for (int i = 0; i < _anagram.Length; i++)
            {
                if (_anagramComparer.
                    Any((x) => x != _anagram[i])) continue;

				_valueIndexCurrentRange++;

                Span<int> _previousValueIndex = _valueIndex;
                _valueIndex = new int[_valueIndexCurrentRange];

                _valueIndex[^1] = i;
				for (int j = 0; j < _previousValueIndex.Length; j++)
				{
					_valueIndex[j] = _previousValueIndex[j];
				}
			}
            if(_valueIndex == Array.Empty<int>())
            {
                _output = _valueIndex;
				return false;
            }



            _output = new int[_anagramComparer.Length];
            return true;
        }
    }
}
