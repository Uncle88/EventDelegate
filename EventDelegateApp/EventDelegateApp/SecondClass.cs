using System;
using static EventDelegateApp.SomeClass;

namespace EventDelegateApp
{
    public class SecondClass
    {
        static void Main()
        {
            MyDelegate mDel = new MyDelegate(SendMeSum);
            SomeClass someClass = new SomeClass();
            //someClass.MyEvent += new MyDelegate(SendMeSum);
            someClass.MyEvent += SecondClass.SendMeMult;
            someClass.MyEvent += SecondClass.SendMeSum;//подписка
            someClass.StartEvent();//стартуем событие


			Console.WriteLine("=========================");
            MulticastDelegate m = (MulticastDelegate)mDel;
			var list = m.GetInvocationList();
			foreach (Delegate d in list)
			{
				Console.WriteLine(d);
            }

			someClass.MyEvent -= SendMeSum;//одписка
            //Console.WriteLine("There was an unsubscription");
            Console.WriteLine(mDel(6, 8));

            Console.ReadLine();
		}

        private static int SendMeSum(int s,int r)//подписчик(обработчик) события
        {
            return s + r;
        }

        private static int SendMeMult(int q,int e)
        {
            return q * e;
        }
    }
}
