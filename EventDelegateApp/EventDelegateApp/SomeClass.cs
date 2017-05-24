using System;
namespace EventDelegateApp
{
    public class SomeClass
    {
        public delegate string Alphabet(string _char);
        event Alphabet LetterAlphabet;


    }
}
