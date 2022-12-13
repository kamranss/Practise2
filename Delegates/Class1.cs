namespace Delegates
{
    public class Class1
    {
        public delegate bool Check(int m);

        public bool IsEven(int m)
        {
            return m % 2 == 0;
        }
    }
}