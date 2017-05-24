using System;
namespace EventDelegateApp
{
    public class SecondClass
    {
        
        static void Main()
        {
            SomeClass someClass = new SomeClass();
            someClass.LetterAlphabetEvent += SendMeCharacter;//подписка
            someClass.StartEvent();//стартуем событие

            for (int thk = someClass.del.GetInvocationList().Length; thk >= 0;thk++)
                Console.WriteLine(thk);

            someClass.LetterAlphabetEvent -= SendMeCharacter;//одписка
            Console.WriteLine("There was an unsubscription");

            for (int thk2 = someClass.del.GetInvocationList().Length; thk2 >= 0; thk2++)
				Console.WriteLine(thk2);
            
            Console.ReadLine();
		}

        private static void SendMeCharacter(string _char)//подписчик(обработчик) события
        {
            Console.WriteLine("Take the letter A");
        }
    }
}
