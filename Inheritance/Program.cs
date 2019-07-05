using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {          
            MySecondClass mySecondClass = new MySecondClass();
            mySecondClass.ValueAssignmentWithoutArguments();
            Console.WriteLine($"Text line length: { mySecondClass.TextSize}");
            int k = 3;
            Console.WriteLine($"Text line element: {mySecondClass[k]}");
            string name="Olya";
            mySecondClass.ValueAssignmentWithOneArgumen(name);
            Console.WriteLine(mySecondClass.number);

            Console.ReadKey();
        }

        class MyFirstClass
        {
            protected string text;

            public char this[int k]
            {
                get
                {
                    return text[k];
                }
            }

            public int TextSize
            {
                get
                { 
                    return text.Length;
                }
            }

            public virtual void ValueAssignmentWithoutArguments()
            {
                text = "Hello, Olya";
            }

            public virtual void ValueAssignmentWithOneArgumen(string text)
            {
                this.text = text;
            }
        }

        class MySecondClass : MyFirstClass
        {
            public int number = 0;

            public override void ValueAssignmentWithoutArguments()
            {
                base.ValueAssignmentWithoutArguments();
                number = 5;
            }

            public override void ValueAssignmentWithOneArgumen(string text)
            {
                base.ValueAssignmentWithOneArgumen(text);
                number = 9;
            }

            public void ValueAssignmentWithOneArgument(int number)
            {
                this.number = number;
            }
        }
    }
}
