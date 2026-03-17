// ++++++++++++++   REFERENCE CLASS   ++++++++++++++
//  ++++++++++++   Scripture Memorizer   ++++++++++++
// Develop 03 Prove Project - John S.

namespace ScriptureMemorizer
{
    public class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int StartVerse { get; private set; }
        public int? EndVerse { get; private set; }

        // Constructor for single verse (John 3:16)
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = verse;
            EndVerse = null;
        }

        // Constructor for verse range (Proverbs 3:5-6)
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        public override string ToString() //so the scripture reference is printed correctly if single or range.
        {
            if (EndVerse.HasValue)
            {
                return $"{Book} {Chapter}:{StartVerse}-{EndVerse.Value}";
            }
            return $"{Book} {Chapter}:{StartVerse}";
        }
    }
}