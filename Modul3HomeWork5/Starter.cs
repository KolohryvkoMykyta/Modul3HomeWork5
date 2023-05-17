namespace Modul3HomeWork5
{
    public static class Starter
    {
        public static void Run()
        {
            var task = GetConcatenatedString();
            task.Wait();

            Console.WriteLine(task.Result);
            Console.ReadKey();
        }

        private static async Task<string> GetConcatenatedString()
        {
            var tasks = new Task<string>[]
            {
                Reader.ReadText("Hello.txt"),
                Reader.ReadText("World.txt")
            };

            await Task.WhenAll(tasks);
            var result = string.Concat(tasks[0].Result, tasks[1].Result);

            return result;
        }
    }
}
