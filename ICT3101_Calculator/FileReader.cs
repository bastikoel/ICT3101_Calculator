public class FileReader : IFileReader
{
    public string[] Read(string path = @"C:\Users\sebas\source\repos\")
    {
        return File.ReadAllLines(path);
    }
}