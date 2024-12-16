
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program program = new Program();
            program.run();
                }

        private void run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };
            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };
            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd = 30,
                naam = "jonh",
                zzp = false,
            };
            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,
                
                tijd = 1130
            };
            Student student = new Student()
            {
                lesPakket = new LesPakket()
                {
                    automaat = true,
                    urenVerbruikt = 100,
                    examenPogingen = 4,
                    urenGekocht = 200,
                },
                theorieTest = new TheorieTest()
                {
                    aantalFouten = 12,
                    gehaald = true,
                    afnameDatum = new DateTime(2012,6,18)
                },
                rijTest = new RijTest()
                {
                    gehaald = true,
                    afnameDatum = new DateTime(16,6,23)
                }
            };
            Dag dag = new Dag()
            {
                
            };
        }
    }
    
    
}
