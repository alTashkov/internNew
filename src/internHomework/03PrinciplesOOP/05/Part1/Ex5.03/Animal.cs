namespace Ex5._03
{
    public abstract class Animal : ISound
    {
        public string Name { get; protected set; }

        public int Age { get; protected set; }

        public bool IsMale { get; protected set; }

        public abstract void MakeSound();
    }
}
