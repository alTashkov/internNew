namespace _4._02
{
    class PathStorage
    {
        public static void SavePathToFile(Path3D path3D, string filePath)
        {
            if (path3D == null) throw new ArgumentNullException("Path must be defined.");

            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                writer.WriteLine(path3D);
            }
            Console.WriteLine("Path was saved successfully!");
        }

        public static void LoadPathFromFile(Path3D path3D,string filePath)
        {
            string[] contents = File.ReadAllLines(filePath);
            for (int i = 0; i < contents.Length; i++)
            {
                if (!string.IsNullOrEmpty(contents[i]))
                {
                    path3D.Points.Add(new Point3D(contents[i]));
                }
            }
            Console.WriteLine("Path was loaded successfuly!");
        }
    }
}
