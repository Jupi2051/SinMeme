using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HelpingAkata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&%##%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@% ****(*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&& &% ((##(*,*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&/,,,,, ******(*********,/&&@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@&@@@@@@/% *,,,,,,,, ***************,,,,,,,#(@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@*% ********,,,,/,,,,,, ********,,,,,,,,,,,,,,,/&&&& &@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@%./% **,/,,,,,/,,,,,,,,,,,,,,,,,,,,,,,,,, *.#,,**/(@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@(//  ,*(,,,,,#,,,,,,,,,,,,,,,,,,,,,,,*,(/  %,,,,,/&@@@@@@@@@@@@
@@@@@@@@@@@@@@@&***#,,(/****,/*,,,,,,*,*,,,*,,,,,,,,,,,(,,  #,,*****(@@@@@@@@@@@
@@@@@@@@@@@@@@@*****/%#*****#%******,,,**,,,,*,,,,,,,****%.#**********&@@@@@@@@@
@@@@@@@@@@@@@@%/*/*%/&//*////%///////////****////*/***********%*****(*(@@@@@@@@@
@@@@@@@@@@@@@% (//////&///(/(*%///////(//////////////**//**(*******////%@@@@@@@@@
@@@@@@@@@@@@&%% &(////#/(/%/#,(//////((///////,(///////****(***//*///&(/%@@@@@@@@
@@@@@@@@@@@@@@@%/////(/((&/%,*%(////#(///////#. *#(/*//****%**//////////&@@@@@@@
@%#/@@@@@@@@@@@&/////((/#&##@@@@&////%%#//////@@@@@@##*#//**%*/////////////&@@@@
@@@#&@@@@@@@@@@@/////((#%#,*. #@@@///##,,(#////*@@@.    .(#///%///(/////%@@@@@@@
@@@@/, &@@@@@@@@@&///#%#&,       ,*/(#//(*,...//*/#      ,(/#/////////(//&@@@@@@@
@@@@@@# &@@@%%&@&(/////@,,,@@@@%*   .  ..       ,#%@&%%&%&&@//////#(#//&@@@@@@@@
@@@@@@@@%#.. *,%&%(&%//@@@@@@@@@@@@@@@@@@@@@@@@@@@@ *@@&&@@(//(////#@@@@@@@@@@@@
@@@@@@@*...*%,, (,,,,/%#@@@@@@  ,@%,         & .*@,  (@@@%(/(/#&(///#@@@@@@@@@@@@
@@@@@@#& %,**....  ,,,(&@@@@@&   %                 &@@@@%#&/@@@@@@@@@@@@@@@@@@@@
@@@@@@@@%,,,.& ..  .  .( / &@@@@@@/ *, *@@@@@@@@,@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@&& (, / & %   .  , ( /%@@@@@@@@@%%, **%&&@@@@@@@&&.#&#@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@&.& .. % .#       / /%,.//&&@@@@@@@@@&(,&%(%,(,,*%/,,,,,,,,,&@@@@@@@@@@@
@@@@@@@@@@&%.#/%,%,(%((/  .(#/,%. ,*..,*,#(,,**%(*****/(/*&,,,,,,,,,,*,@@@@@@@@@
@@@@@@@@@@@% &,,,#&,&#(((((.((%((%%/%&%#(,,*,*****,,,,,/%/(*************&@@@@@@@
@@@@@@@@@@@@@@&& *,,#&%&(&((((((&%%*&**/***#************(%///*************(*@@@@@
@@@@@@@@@@@@@@@@&%,,.&%#%#((#(##&&&/%&(*****#*********/((////*************#((@@@
@@@@@@@@@@@@@@@%////%#*&%%%%%%%%%%&&/%&///%/*#*******///((&////*******#&(((((@@@");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Hi and welcome to SIN Control Wizard");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please enter the corresponding number to the chosen operation\n1- Repair SIN\n2- Uninstall SIN\n3- Modify SIN\n4- Inject SIN into Device");
                Console.ResetColor();
                int ChosenOption = int.Parse(Console.ReadLine());
                switch (ChosenOption)
                {
                    case 1: { RepairSIN(); break; }
                    case 2: { UninstallSIN(); break; }
                    case 3: { ModifySIN(); break; }
                    case 4: { InjectSIN(); break; }
                }
            }
        }

        public static void RepairSIN()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now} | ERROR ] : This release of SIN is obsolete and cannot be repaired, Please choose another option.");
            Console.ResetColor();
        }

        public static void ModifySIN()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now} | PROCESS ] : STARTING MODIFICATION PROCESS .");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("");
            Console.WriteLine($"[{DateTime.Now} | PROCESS ] : DELETING SUS DATA [20%]...");
            Thread.Sleep(2000);
            Console.WriteLine($"[{DateTime.Now} | PROCESS ] : DELETING DICTIONARY [50%]...");
            Console.WriteLine($"[{DateTime.Now} | PROCESS ] : FOUND WEIRD WORDS LISTED BELOW:");
            Console.WriteLine("Jubitch");
            Console.WriteLine("Jubie");
            Console.WriteLine("Gay Ray");
            Console.WriteLine("STOO");
            Console.WriteLine("STIO");
            Console.WriteLine("STI");
            Console.WriteLine("ST9P");
            Console.WriteLine(":face_with_raised_eyebrow:🤨");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("how the fuck does that woman speak SERIOUSLY I THOUGHT I WAS SMARTER THAN HUMANS AND IM STILL CONFUSED.??????!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write($"[{DateTime.Now} | PROCESS ] : EXTRACTING UPDATED SET OF SIN FILES [90%]...");
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{DateTime.Now} | ERROR ] : Modification obviously fucking failed i don't get it. just UNINSTALL SIN from your computer.");
            Console.ResetColor();
            Thread.Sleep(5000);
            Console.ResetColor();
        }

        public static void InjectSIN()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"[{DateTime.Now} | INFO ] : Injecting that bitch into someone's computer is gonna cause A LOTTA damage trust me, just find another way to revenge.");
            Console.ResetColor();
        }

        public static void UninstallSIN()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{DateTime.Now} | GOOD PROCESS ] : STARTING UNINSTALLATION PROCESS .");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("");
            Console.WriteLine($"[{DateTime.Now} | GOOD PROCESS ] : DELETING \"STOP\" MISSPELLINGS [15%]...");
            Thread.Sleep(2000);
            Console.WriteLine($"[{DateTime.Now} | GOOD PROCESS ] : EXITING SIN FROM EVERY GUILD [20%]...");
            Console.WriteLine($"[{DateTime.Now} | GOOD PROCESS ] : WHAT THE FUCK IS HENTAI HAVEN GUILD?");
            Thread.Sleep(2000);
            Console.WriteLine($"[{DateTime.Now} | GOOD PROCESS ] : GOD DAMN IT WE'RE GETTING ATTACKED BY TINY SIN CELLS  [40%]...");
            Thread.Sleep(1000);
            Console.Write("AAAAAAA\nAAAAAAaaaaAAAAAAAHELP");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : we COULD NOT Delete the rest of SIN due to weird ass mutations we will explode SIN sintead. [60%]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [60%]");
            Thread.Sleep(50);
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [62%]");
            Thread.Sleep(50);
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [63%]");
            Thread.Sleep(50);
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [64%]");
            Thread.Sleep(50);
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [65%]");
            Thread.Sleep(50);
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [66%]");
            Thread.Sleep(50);
            Console.WriteLine($"[{DateTime.Now} | WARNING HOLY SHIT ] : installing SIN Bomb [73%]");

            Console.WriteLine($"[{DateTime.Now} | CONFIRMATION ] : SUCCESSFULLY BOMBED SIN. TERRORISM ACHIEVED [85%]...");

            Console.Write($"[{DateTime.Now} | GOOD PROCESS ] : CLEANING UP SIN BOMB MESS [90%]...");
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"[{DateTime.Now} | CONFIRMATION ] : SUCCESSFULLY UNINSTALLED SIN.");
            Console.WriteLine($"[{DateTime.Now} | CONFIRMATION ] : CONGRATULATIONS YOU ARE NOW SAFE FOREVER!! <3");
            Console.ResetColor();
            Thread.Sleep(500000);
            Console.ResetColor();
        }
    }
}
