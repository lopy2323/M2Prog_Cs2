namespace _04.list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        void Run()
        {
            double[] prijzen = new double[] { 0.99, 6.60, 10.11,99.99 };
            string[] artiekelen = new string[] { "snoepje", "luxe broodje", "luch menu","oplader" };
            Formulier[] formulieren = new Formulier[2];
            formulieren[0] = new Formulier()
            {
                Feedback = "prijzig maar lekker",
                Sterren = 5
            };
            formulieren[1] = new Formulier()
            {
                Feedback = "niet lekker",
                Sterren = 2
            };
            for (int i = 0; i < formulieren.Length; i++)
            {
                Console.WriteLine(formulieren[i]);
            }
            foreach (Formulier formulier in formulieren)
            {
                
            }

        }
    }
}
