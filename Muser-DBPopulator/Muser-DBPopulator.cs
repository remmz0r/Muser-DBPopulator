using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace flippedout
{

    class RandomMuser
    {

        private string[] WordFile { get; set; }
        private string[] FirstNames { get; set; }
        private string[] LastNames { get; set; }

        // array(5) of possible instruments
        private string[] Instruments = new string[] { "Acoustic Guitar", "Electric Guitar", "Vocals", "Bass Guitar", "Drums" };


        // Muser object property
        private Muser Muser { get; set; }
        Random rnd = new Random();

        // private functions
        private string RandomLocation()
        {
            // setup location var
            string Location = null;

            // get a new Rand object
            

            // generate random int value
            int randomNumber = rnd.Next(0, 8);

            switch(randomNumber) {
                case 0: Location = "Sydney"; break;
                case 1: Location = "Brisbane"; break;
                case 2: Location = "Melbourne"; break;
                case 3: Location = "Adelaide"; break;
                case 4: Location = "Perth"; break;
                case 5: Location = "Darwin"; break;
                case 6: Location = "Canberra"; break;
                case 7: Location = "Hobart"; break;
                default: Location = "Melbourne"; break;

            }



            return Location;
        }

        private bool OnlineCollab()
        {

            //setup OnlineCollab var
            bool OnlineCollab = false;

            if (rnd.Next(1, 3) == 1)
            {

                OnlineCollab = false;

            }
            else
            {

                OnlineCollab = true;

            }

            return OnlineCollab; 
        }

        private string RandomInstrument()
        {
            // get a random number
            int randomNum = rnd.Next(0, 100);

            if (randomNum < 21)
            {

                Muser.Instruments.Add(Instruments[0]);
                return Instruments[0];

            }
            else if (randomNum >= 21 && randomNum <= 45)
            {

                Muser.Instruments.Add(Instruments[1]);
                return Instruments[1];

            }
            else if (randomNum >= 46 && randomNum <= 65)
            {

                Muser.Instruments.Add(Instruments[2]);
                return Instruments[2];

            }
            else if (randomNum >= 66 && randomNum <= 84)
            {

                Muser.Instruments.Add(Instruments[3]);
                return Instruments[3];

            }
            else if (randomNum >= 85 && randomNum <= 99)
            {

                Muser.Instruments.Add(Instruments[4]);
                return Instruments[4];

            }
            else
            {

                return null;

            }
           
        }

        // RandomMuser constructor
        public RandomMuser()
        {
            // read text files from folder
            FirstNames = File.ReadAllLines(@"~/txt/firstNames.txt");
            LastNames = File.ReadAllLines(@"~/txt/lastNames.txt");
            WordFile = File.ReadAllLines(@"~/txt/wordFile.txt");

        }


        public bool MainLoop(RandomMuser m, int NumUsers = 3000)
        {
            // random muser algorithm v0.69
            // start loop NumUsers times

            while (NumUsers > 0) { 

            // create muser object
            Muser Muser = new Muser();

            // 1 - roll for location

            Muser.Location = m.RandomLocation();

            //              function: RandomLocation() {} : string
            //              @params: rand[0-7]
            //              0: "Sydney"; 
            //              1: "Brisbane"; 
            //              2: "Melbourne"; 
            //              3: "Adelaide"; 
            //              4: "Perth"; 
            //              5: "Darwin"; 
            //              6: "Canberra"; 
            //              7: "Hobart"; 
            //              default: "Melbourne";
            //
            // 2 - roll for online_collab

            Muser.OnlineCollaboration = m.OnlineCollab();

            //              function: OnlineCollab() {} : bool
            //              params: rand[0-99] 
            //               0-49 == false;
            //              50-99 == true;
            //
            // 3 - roll for main 

            Muser.Instruments.Add(m.RandomInstrument());

            //              function: RandomInstrument() {} : string
            //              @params: rand[0-250]
            //                       Rand[0-550]
            //
            //
            // 4 - roll for secondary and tertiary instruments

            // roll random to see if user plays secondary instrument; 200+ == true;
            int Instrument2 = rnd.Next(0, 251);

                // if the random Instrument2 value falls above 200, follow this logic
                if ((Instrument2 > 200 && Instrument2 <= 250 && Muser.NumInstruments < 3))
                {
                    // create counter for tracking for loop
                    int xcounter = 0;


                    // for each instrument in the current musicians instrument list
                    foreach (string Instrument in Muser.Instruments)
                    {

                        // if the current value for xcounter equals the current instrument in the loop
                        if (m.Instruments[xcounter++].Equals(Instrument))
                        {

                            // skip the current iteration and continue from the top
                            continue;

                        }
                        else
                        {

                            // otherwise, add the instrument into the musician's list
                            Muser.Instruments.Add(m.RandomInstrument());
    
                        }

                    }

                }

                // roll random to see if user plays a third instrument; 500+ == true;
                int Instrument3 = rnd.Next(0, 551);

                if ((Instrument3 >= 500 && Instrument3 < 551))
                {

                    // add a random instrument to the stack
                    Muser.Instruments.Add(m.RandomInstrument());

                }
            }

            //              function: Instrument2 = SecondaryInstrument(string[] Instruments) {} : bool
            //              @vars: rand1[0-250]
            //                   225-250 == true;
            //                     0-224 == false;
            //              function: Instrument3 = TertiaryInstrument(string[] Instruments) {} : bool
            //              @vars: rand2[0-550]
            //                   500-550 == true;
            //                     0-499 == false;
            //   
            //     
            //             -> if Instrument2 == true { Muser.Instrument2 = RandomInstrument() : string }
            //             -> if Instrument2 == true && Instrument3 == true { Muser.Instrument3 = RandomInstrument() : string }
            //
            // 5 - roll genres (iterations == rand[1-3])
            //              function: RandomGenre(int iterations = 2)
            //              @vars: rand[0-99]
            //              0-19 == rock;
            //             20-39 == metal; 
            //             40-64 == pop;
            //             65-74 == folk;
            //             75-89 == indie;
            //             90-99 == jazz;
            //
            // 6 - roll skill level 
            //              function: RandomSkill() {} : string              
            //              @vars: rand[0-3]
            //              0 == beginner;
            //              1 == amateur;
            //              2 == skilled;
            //              3 == professional;
            //
            // 7 - generate random emails
            //              function: RandomEmail(string[] wordFile, string[] domainList) {} : string
            //              a) read from private array of words from .txt file
            //              b) concatenate two words; string email = wordFile[rand[0-2000]] + wordFile[rand[0-2000]]
            //              c) concatenate email + .tld
            //                      0 == .com
            //                      1 == .net
            //                      2 == .org
            //                      default == .com
            //
            // 8 - generate random names
            //              function: RandomFirstName(string[] firstNames) {} : string
            //              function: RandomLastName(string[] lastNames) {} : string
            //              a) private array of FirstNames and LastNames from .txt file(s)
            //              b) get FirstName[rand[0-2000]], LastName[rand[0-3000]] 
            //
            // 9 - generate random username
            //              function: randomUsername(string[] wordFile, int randomNumOne = 0, int randomNumTwo = 0) {} : string
            //              a) private array of dictionary words from .txt file
            //              b) concatenate two words; string username = wordFile[randomNumOne] + wordFile[randomNumTwo];
            // 


            // SQL integration


            // end loop
            }

        }


        static void Main(string[] args)
        {
            
            const int numResults = 25; // the number of results/iterations for the script

            // run the main constructor
            RandomMuser m = new RandomMuser();

            // start the main logic with numResults iterations
            if (m.MainLoop(m, numResults))
            {

                Console.WriteLine("Program exited cleanly.");

            }
            else
            {

                Console.WriteLine("Program caked it");

            }

        }

    }

