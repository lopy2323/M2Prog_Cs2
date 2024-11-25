using Microsoft.CSharp.RuntimeBinder;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    internal class Program
    {
        string[] vragen = new string[]{
                "How long do you think you'd survive in a zombie apocalypse?",
                "What secret conspiracy would you like to actually start letting other people know?",
                "If you can still remember, what are your funniest childhood memories?",
                "What would you do if you won a million dollars?",
                "What is the worst game you played but that you liked anyway?"

            };
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Vraag7();//
            program.getvraag(0);
            program.radomvraag();
        }
        internal string getvraag(int vraagindex)
        {
            return vragen[vraagindex];

        }
        //internal string Vraag7()
        //{
            //Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            //string antword = Console.ReadLine();
//
            //return antword;
        //}
        internal string random()
        {
            var rand = new Random();
            int random = rand.Next(0,vragen.Length);
            return getvraag(random);

        }
        internal void radomvraag()
        {
            string vraag=random();
            Console.WriteLine(vraag);
            string antword = Console.ReadLine();
            Console.WriteLine(antword);

        }

    }
    

}
