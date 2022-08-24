namespace SingletonDesignPattern
{
    public sealed class Counter
    {
        private static Counter instance;
        private static readonly object padlock = new();

        public static Counter GetInstance()
        {
            if(instance == null)
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new();
                    }
                }
            }
            return instance;
        }

        private int counter;

        public void Increase()
        {
            counter++;
        }

        public void Decrease()
        {
            counter--;
        }

        public int GetValue()
        {
            return counter;
        }
    }
}