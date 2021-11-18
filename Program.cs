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

        }

        public static void UninstallSIN()
        {

        }
    }
}
