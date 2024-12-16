
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
            RijLeraar rijLeraar1 = new RijLeraar()
            {
                leeftijd = 30,
                naam = "jonh",
                zzp = false,
            };
            RijLeraar rijLeraar2 = new RijLeraar()
            {
                leeftijd = 20,
                naam = "Ben",
                zzp = false,
            };
            Student student1 = new Student()
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
                    afnameDatum = new DateTime(2016,6,23)
                }
            };
            Student student2 = new Student()
            {
                lesPakket = new LesPakket()
                {
                    automaat = true,
                    urenVerbruikt = 155,
                    examenPogingen = 7,
                    urenGekocht = 175,
                },
                theorieTest = new TheorieTest()
                {
                    aantalFouten = 6,
                    gehaald = true,
                    afnameDatum = new DateTime(2001, 5, 18)
                },
                rijTest = new RijTest()
                {
                    gehaald = true,
                    afnameDatum = new DateTime(2019, 6, 23)
                }
            };

            LesUur lesUur1 = new LesUur()
            {
                auto = auto1,
                student = student1,
                rijLeraar = rijLeraar1,

                tijd = 1130
            };
            LesUur lesUur2 = new LesUur()
            {
                auto = auto2,
                student = student2,
                rijLeraar = rijLeraar2
            };

            Dag dag = new Dag()
            {
                lesuren = new LesUur[]
                {
                    lesUur1,
                    lesUur2
                }


            };
        }
    }
    
    
}
