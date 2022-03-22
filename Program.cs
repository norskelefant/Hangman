using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int hangmanPos = 0;
            Console.WriteLine(@"
 _    _      _                                _              _   _                                           _ 
| |  | |    | |                              | |            | | | |                                         | |
| |  | | ___| | ___ ___  _ __ ___   ___      | |_ ___       | |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __   | |
| |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \     | __/ _ \      |  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \  | |
\  /\  /  __/ | (_| (_) | | | | | |  __/     | || (_) |     | | | | (_| | | | | (_| | | | | | | (_| | | | | |_|
 \/  \/ \___|_|\___\___/|_| |_| |_|\___|      \__\___/      \_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_| (_)
                                                                                __/ |                          
                                                                               |___/                           
");
            Console.WriteLine("Press Enter to start");

            switch (hangmanPos)
            {
                case 1:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
+---+
|   |
    |
    |
    |
    |
=====
");
                    break;

                case 2:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
+---+
|   |
O   |
    |
    |
    |
=====
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("Mistake: 1/7");
                    break;

                case 3:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
+---+
|   |
O   |
|   |
    |
    |
=====
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("Mistake: 2/7");
                    break;

                case 4:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
 +---+
 |   |
 O   |
/|   |
     |
     |
======
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("Mistake: 3/7");
                    break;

                case 5:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
 +---+
 |   |
 O   |
/|\  |
     |
     |
======
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("Mistake: 4/7");
                    break;

                case 6:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
 +---+
 |   |
 O   |
/|\  |
/    |
     |
======
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("Mistake: 5/7");
                    break;

                case 7:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
 +---+
 |   |
 O   |
/|\  |
/ \  |
     |
======
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("Mistake: 6/7");
                    break;

                case 8:
                    Console.WriteLine(@"
 _   _                                         
| | | |                                        
| |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __  
|  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
| | | | (_| | | | | (_| | | | | | | (_| | | | |
\_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                    __/ |                      
                   |___/                       
");
                    Console.WriteLine(@"
 +---+
 |   |
 X   |
/|\  |
/ \  |
     |
======
");
                    Console.WriteLine("WRONG! The letter" + hangmanPos + "isn't in the word");
                    Console.WriteLine("You killed him!!");
                    Console.WriteLine("Mistake: 7/7");
                    break;

            }
            Console.ReadKey();
        }
    }
}
