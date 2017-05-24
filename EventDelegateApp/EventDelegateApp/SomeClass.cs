using System;
namespace EventDelegateApp
{
    public class SomeClass
    {
        public delegate void Alphabet(string _char);
        public Alphabet del;
        public event Alphabet LetterAlphabetEvent;

        public void StartEvent()
        {
            LetterAlphabetEvent("jojo- event is start!!!");
        }
    }
}
