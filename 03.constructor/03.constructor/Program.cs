using System.Runtime.InteropServices;

namespace _03.constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.run();

        }
        void run()
        {
            QuizVraag quizVraag1 = new QuizVraag("wat is 1 + 1","2");
            QuizVraag quizVraag2 = new QuizVraag("wat is 1 + 1", "2");
            QuizVraag quizVraag3 = new QuizVraag("wat is 1 + 1", "2");
            QuizVraag quizVraag4 = new QuizVraag("wat is 1 + 1", "2");
            QuizVraag quizVraag5 = new QuizVraag("wat is 1 + 1", "2");
            Quiz qi = new Quiz(10);
            qi.VoegVraagToeOpIndex(0, quizVraag1);
            qi.VoegVraagToeOpIndex(1,quizVraag2);
            qi.VoegVraagToeOpIndex(2, quizVraag3);
            qi.VoegVraagToeOpIndex(3, quizVraag4);
            qi.VoegVraagToeOpIndex(4, quizVraag5);
        }
    }
}
