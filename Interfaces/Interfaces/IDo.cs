namespace Interfaces
{
    interface IDo
    {
        int Jump(int length);
        void Go();
        void Sleep();
         int Energy { get; }

    }
}
