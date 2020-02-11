using System;
using System.Collections.Generic;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Warrior("John The Strong", 33, 14, "Sword"));
            gameCharacters.Add(new Wizard("Wes The Wise", 33, 14, 99, 5));
            gameCharacters.Add(new Warrior("Duncaan the Destroyer", 68, 8, "Great Sword"));
            gameCharacters.Add(new Wizard("Elswynn of the Forest", 17, 99, 57, 10));
            gameCharacters.Add(new Wizard("Shannon of the Lucky Isle", 20, 88, 99, 7));
            gameCharacters.Add(new Wizard("Thrall the Crusher", 67, 19, 99, 2));
            Dragon();

            Console.WriteLine();
            Console.WriteLine("Player Stats: ");
            Console.WriteLine();
            
            foreach (GameCharacter gc in gameCharacters)
            { 
                Console.WriteLine("     /");
                Console.WriteLine("O===[====================-");
                Console.WriteLine("     \\");
               
                Console.WriteLine(gc.Play());
                if (gc is Warrior)
                {
                    Console.WriteLine($"Class: Warrior");
                }
                else if (gc is Wizard)
                {
                    Console.WriteLine($"Class: Wizard");
                }

            }
            Console.WriteLine("     /");
            Console.WriteLine("O===[====================-");
            Console.WriteLine("     \\");

            Console.SetCursorPosition(0, 0);
            
            while (true)
            {
                
                if (Console.ReadKey().Key == ConsoleKey.Enter) 
                {
                    Console.Clear();
                    Monster();
                    break;
                }

            }

        }

        static void Dragon()
        {
            Console.WriteLine("        ,     \\    /      ,    ");
            Console.WriteLine("       / \\    )\\__/(     / \\ ");
            Console.WriteLine("      /   \\  (_\\  /_)   /   \\  ");
            Console.WriteLine(" ____/_____\\__\\@  @/___/_____\\____ ");
            Console.WriteLine("|             |\\../|             |");
            Console.WriteLine("|              \\VV/              |");
            Console.WriteLine("|      Welcome to Castle John    |");
            Console.WriteLine("|________________________________|");
            Console.WriteLine(" |    /\\ /      \\\\       \\ /\\    | ");
            Console.WriteLine(" |  /   V        ))       V   \\  | ");
            Console.WriteLine(" |/     `       //        '     \\| ");
            Console.WriteLine(" `              V                '");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void Monster()
        {


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tIt's a Terrible Night to Have A Curse!");
            Console.WriteLine();
            Console.WriteLine(@"                                             ,--,  ,.-.");
            Console.WriteLine(@"               ,                   \,       '-,-`,'-.' | ._");
            Console.WriteLine(@"              /|           \\    ,   |\         }  )/  / `-,',");
            Console.WriteLine(@"              [ ,          |\\  /|   | |        /  \|  |/`  ,`");
            Console.WriteLine(@"              | |       ,.`  `,` `, | |  _,...(   (      .',");
            Console.WriteLine(@"              \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\");
            Console.WriteLine(@"               \  \_\,``,   ` , ,  /  |         )         _,/");
            Console.WriteLine(@"                \  '  `  ,_ _`_,-,<._.<        /         /");
            Console.WriteLine(@"                 ', `>.,`  `  `   ,., |_      |         /");
            Console.WriteLine(@"                   \/`  `,   `   ,`  | /__,.-`    _,   `\");
            Console.WriteLine(@"               -,-..\  _  \  `  /  ,  / `._) _,-\`       \");
            Console.WriteLine(@"                \_,,.) /\    ` /  / ) (-,, ``    ,        |");
            Console.WriteLine(@"               ,` )  | \_\       '-`  |  `(               \");
            Console.WriteLine(@"              /  /```(   , --, ,' \   |`<`    ,            |");
            Console.WriteLine(@"             /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)");
            Console.WriteLine(@"       ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`");
            Console.WriteLine(@"      (-, \           ) \ ('_.-._)/ /,`    /");
            Console.WriteLine(@"      | /  `          `/ \\ V   V, /`     /");
            Console.WriteLine(@"   ,--\(        ,     <_/`\\     ||      /");
            Console.WriteLine(@"  (   ,``-     \/|         \-A.A-`|     /");
            Console.WriteLine(@" ,>,_ )_,..(    )\          -,,_-`  _--`");
            Console.WriteLine(@"(_ \|`   _,/_  /  \_            ,--`");
            Console.WriteLine(@" \( `   <.,../`     `-.._   _,-`");
        }
    }
}
