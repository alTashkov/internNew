using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ex2._01
{
    public class Bunnies
    {
        static void Main(string[] args)
        {
            List<Bunny> bunnies = new List<Bunny>()
            {
                new Bunny() { Name = "Leonid", Age= 1, FurType = FurType.NotFluffy },
                new Bunny() { Name = "Rasputin", Age= 2, FurType = FurType.ALittleFluffy },
                new Bunny() { Name = "Tiberii", Age= 3, FurType = FurType.ALittleFluffy },
                new Bunny() { Name = "Neron", Age= 1, FurType = FurType.ALittleFluffy },
                new Bunny() { Name = "Klavdii", Age= 3, FurType = FurType.Fluffy },
                new Bunny() { Name = "Vespasian", Age= 3, FurType = FurType.Fluffy },
                new Bunny() { Name = "Domician", Age = 4, FurType = FurType.FluffyToTheLimit },
                new Bunny() { Name = "Tit", Age= 2, FurType = FurType.FluffyToTheLimit }
            };

            // Introduce all bunnies
            ConsoleWriter consoleWriter = new ConsoleWriter();

            foreach (Bunny bunny in bunnies)
            {
                bunny.Introduce(consoleWriter); 
            }

            // Create bunnies text file
            string bunniesFilePath = @"..\..\bunnies.txt";
            FileStream fileStream = File.Create(bunniesFilePath);

            fileStream.Close();

            // Save bunnies to a text file
            using (StreamWriter streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (Bunny bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }

    [Serializable] 
    public class Bunny
    {
        public int Age { get; set; } 
        
        public string Name { get; set; } 
        
        public FurType FurType { get; set; } 
        
        public void Introduce(IWriter writer)
        {
            writer.WriteLine($"{Name} - \"I am {Age} years old!\"");
            writer.WriteLine($"{Name} - \"And I am " +
                $"{FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        } 

        public override string ToString()
        {
            int builderSize = 200;

            StringBuilder builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {Name}");
            builder.AppendLine($"Bunny age: {Age}");
            builder.AppendLine($"Bunny fur: " +
                $"{FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }

    public enum FurType
    {
        NotFluffy,
        ALittleFluffy,
        Fluffy,
        FluffyToTheLimit
    }

    public interface IWriter 
    {
        void Write ( string message );

        void WriteLine ( string message );
    }

    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message); 
        }

        public void WriteLine(string message) 
        {
            Console.WriteLine(message);
        }
    }

    public static class StringExtensions
    {
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            int probableStringMargin = 10;
            int probableStringSize = sequence.Length + probableStringMargin;

            StringBuilder builder = new StringBuilder(probableStringSize);

            char singleWhitespace = ' ';
            foreach (char letter in sequence)
            {
                if (Char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}
