namespace SingletonPattern
{
    class Singleton
    {
        //private STATIC instance
        private static Singleton uniqueInstance;

        private static object instanceLock = new object();

        private Singleton() { }

        public static Singleton getInstance()
        {
            //if(uniqueInstance == null) // if an instance is found, don't do the operation. other threads won't check
            //{
            //    lock (instanceLock) // thread safe
            //    {
            //        if (uniqueInstance == null)
            //        {
            //            uniqueInstance = new Singleton();
            //        }
            //    }
            //}
            
            
            return uniqueInstance;
        }
    }
}
