// ++++++++++++++   WORD CLASS   ++++++++++++++
//  ++++++++++++   Scripture Memorizer   ++++++++++++
// Manages single word manipulation (hidden or visible)
// Develop 03 Prove Project - John S.

using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private readonly string _text;
        private bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public bool IsHidden => _isHidden;

        public override string ToString()
        {
            if (_isHidden)
            {
                return new string('_', _text.Length); //to preserve letters in missing word (hint)
            }
            return _text;
        }

        
    }
}