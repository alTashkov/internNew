namespace _4._02
{
    [AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Enum |
                AttributeTargets.Method,
                Inherited = false)]
    public class VersionAttribute : Attribute
    {
        public int Major { get; }
        public int Minor { get; }

        public VersionAttribute(int major , int minor)
        {
            Major = major;
            Minor = minor;
        }

        public override string ToString()
        {
            return $"{Major}.{Minor}";
        }
    }
}
