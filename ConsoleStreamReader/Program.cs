namespace ConsoleStreamReader
{
   internal abstract class Program {
        private static void Main() {
            const string path = @"C:temp\FIle.txt";
            var sr = File.OpenText(path);
            try{
                while (!sr.EndOfStream)
                    Console.WriteLine(sr.ReadLine());
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sr.Close();
                sr.Dispose();
            }
        }
    }
}