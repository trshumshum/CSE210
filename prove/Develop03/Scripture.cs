// ++++++++++++++   SCRIPTURE CLASS   ++++++++++++++
// ++++++++++++   Scripture Memorizer   ++++++++++++
// Develop 03 Prove Project - John S.

using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private readonly Reference _reference;
        private readonly List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Simple split 
            string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                _words.Add(new Word(part));
            }
        }

        public void HideRandomWords(int count = 2)
        {
            var visibleWords = _words.Where(w => !w.IsHidden).ToList();

            if (visibleWords.Count == 0)
                return;

            int toHide = Math.Min(count, visibleWords.Count);

            Random rand = new Random();
            var selected = visibleWords
                .OrderBy(_ => rand.Next())
                .Take(toHide)
                .ToList();

            foreach (var word in selected)
            {
                word.Hide();
            }
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden);
        }

        public override string ToString()
        {
            string refText = _reference.ToString();
            string scriptureText = string.Join(" ", _words.Select(w => w.ToString()));

            return $"{refText}  {scriptureText}";
        }

        // Get command for debug
        public int GetVisibleWordCount()
        {
            return _words.Count(w => !w.IsHidden);
        }
    }
}