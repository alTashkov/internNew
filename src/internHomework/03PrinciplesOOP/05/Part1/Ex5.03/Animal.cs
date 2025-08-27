namespace Ex5._03
{
    public abstract class Animal : ISound
    {
        public abstract string Name { get; set; }

        public abstract int Age { get; set; }

        public abstract bool IsMale { get; set; }

        public abstract void MakeSound();
    }
}
