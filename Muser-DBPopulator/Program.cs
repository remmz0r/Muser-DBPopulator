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
        // Muser property
        private Muser Muser { get; set; }



        // RandomMuser constructor
        public RandomMuser()
        {

            this.FirstNames = File.ReadAllLines(@"~")


        }


        private static bool Start(int NumUsers = 3000)
        {

            // random muser algorithm v0.69

            // 0 = Muser Muser = new Muser();

            // 1 - roll for location
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
            //              function: OnlineCollab() {} : bool
            //              params: rand[0-99] 
            //               0-49 == false;
            //              50-99 == true;
            //
            // 3 - roll for main instrument
            //              function: RandomInstrument() {} : string
            //              @params: rand[0-99]
            //               0-20 == acoustic guitar;
            //              21-45 == electric gutiar;
            //              46-65 == vocals;
            //              66-84 == bass guitar; 
            //              85-99 == drums;
            //
            // 4 - roll for secondary and tertiary instruments
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

            return true;

        }


        static void Main(string[] args)
        {
            
            const int numResults = 25; // the number of results/iterations for the script

            // run the main control branch
            if (Start(numResults))
            {

                Console.WriteLine("System exited cleanly.");

            } else {

                Console.WriteLine("System terminated erroneously");

            }

        }

    }

}
