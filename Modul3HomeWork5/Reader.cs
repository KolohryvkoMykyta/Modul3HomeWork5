namespace Modul3HomeWork5
{
    public static class Reader
    {
        public static async Task<string> ReadText(string path)
        {
            return await File.ReadAllTextAsync(path);
        }
    }
}
