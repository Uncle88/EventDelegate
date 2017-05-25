using System;
namespace EventDelegateApp
{
    public class SomeClass
    {
        public delegate int MyDelegate(int a , int b);
        public event MyDelegate MyEvent;

        public void StartEvent()
        {
            MyEvent(3,2);
        }
    }
}
