class Program
{
    static void Main(string[] args)
    {
        // A string is a sequence of characters (chars) presented as a single object.

        //Strings are immutable - they cannot be changed once created. The operations such as Replace, Insert, Remove actually create new string objects in
        //the memory.

        //The most important methods for strings are:
        // Equals(s1,s2) - compares two strings for equality and returns true or false.
        // Contains(substring) - checks if a string contains a given substring
        // IndexOf(char/substring) - finds the first occurence of a character or substring and returns its index within the string.
        // Replace(old,new) - returns a new string with all the occurences of the value given replaced by the new given value.
        // Insert(index, value) - returns a new string with the given substring inserted at the given index.
        // ToLower - returns a new string with all the characters converted to lowercase.
        // ToUpper - returns a new string with all the characters converted to uppercase.
        // Split(separator) - splits a string into an array of substrings by the given separator.
        // Join(separator, stringArray) - joins a string array into a new string with a separator between the elements.

    }

}