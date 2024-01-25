// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Cryptography;

namespace ah //christmas breakcore
{
    class Program
    {
        static void Main(string[] args)
        {
          //NOTES: 1. Add more moments where the creator questions if the player is having fun. 2. Add special dialouge saying "This is not a card you have." if the player names their card BORF. 3. Add dialouge at the end of TEST that gives them the cheat, the dialouge should be dark gray representing the fake voice the creator talks through. 4. Make it where the game doesn't close when you get an ending. Additionally, add a value at the start of the game that goes up (starting at 0) avery time you get to the "Bing?" section, if that value is higher than 0, the title should be changed to something like "Choose Your Route..." instead of "Answer The Question...", this should (hopefully) make it clearer where to enter Route Words. 5(?). Add a route called "thoughts". This route will hold thoughts that I would like to write down :). 6. If you answer the "bing" question with "help" it will bring you back to the tutorial. 7. Change the color for the "fight me!" route to yellow and change the player's color for the creator's part to cyan. 8. Find music to fit the routes. Game osts that might work [INSCRYPTION || NEON WHITE || UNDERTALE/DELTARUNE || ROR2 || CELESTE || CASTLE CRASHERS || LBP1/2/3 || CUPHEAD || OOBLETS (CLASSY) || Guilty Gear Strive] continue if you think of anything else 9. Credit the VA's in the credits. 10. On the BORF fight, the points you've earned in the duel me route adds to your attack roll, same goes with makamori, but BORF will always have a +5 to their roll. 11. Add the melon man "Don't make me comit a melony". 12. Winning the practice BORF fight will give you a fake bad ending and gives you the BORF card which allows you to choose the outcome of Makamori's turn, winning the actuall borf fight will give you the true ending. 13. If the player has already went through the creator's part and they go through the duel me route again, the player will be asked if they want to go through the creator's part again. 14. Give a hint about the overheal buff just before the real borf fight. 15. (MAYBE) Keep the player's text color cyan after the creator's part in the duel me route. 16. Make sure you can answer any question with all caps 17. CODSWALLOP
            Console.Title = "Tutorial";

            Console.ForegroundColor = ConsoleColor.DarkGray;

            bool quizComplete = false; 
            
            Console.WriteLine("\n1.\n In this game there are times where you can type (Giving an answer)\n and times where pressing a key just continues dialouge,\n but it is hard to tell when exactly you can type and when you can continue dialouge.\n This might get you confused and you might start typing when you can't,\n then not understand why your answer didn't work.\n If this happens make sure when you start to type you can see what you're typing on the screen.\n If you can't see what you're typing and instead the dialouge continues,\n then continue pressing any key untill you can type again.\n2.\n There are no moments in this game where you have to wait, so if nothing is happening, continue the dialouge.\n3.\n Although you can press any key to continue dialouge, it is recomended that you do not use the 'ENTER' key to do so.\n4.  \n Please do not press ctrl + c without selecting something with your mouse first.\n5. \n Lastly, the top left corner will display words occasionally, pay attention to it, it may help you.");

            Console.WriteLine("\n Press any key to start/continue. (Answer the question with 'HELP' to view this tutorial again\n (This feature has not been added yet))");

            Console.ForegroundColor = ConsoleColor.Black;

            Console.ReadKey();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Console.Title = "ATYCHIPHOBIA";

            Console.ReadKey();

            Console.Title = "";

            Console.ForegroundColor = ConsoleColor.Green;
                            
            Console.WriteLine("\n //Calculating BONKAGE..."); 

            Console.ForegroundColor = ConsoleColor.Black;

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n //Locating THE FUNNY..."); 

            Console.ForegroundColor = ConsoleColor.Black;

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n //Checking for THE BOY..."); 

            Console.ForegroundColor = ConsoleColor.Black;

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n //Simulating SKILL ISSUE...");

            Console.ForegroundColor = ConsoleColor.Black;

            Console.ReadKey();

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            while (quizComplete == false)
            {
            Console.Title = "Answer The Question...";

            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n 'Bing?'"); 

            string bong = Console.ReadLine();

            if (bong == "bong" || bong == "Bong" || bong == "BONG" || bong == "BONG!" || bong == "Bong!" || bong == "bong!" || bong == "bong." || bong == "Bong." || bong == "BONG." || bong == "bong?" || bong == "Bong?" || bong == "BONG?" || bong == "BONG!?" || bong == "Bong!?" || bong == "bong!?")
            {
                Console.Title = ""; 

                Console.WriteLine("\n 'Yes...'");

                Console.ReadKey();

                Console.Title = "";

                Console.WriteLine("\n 'Finally...'");

                Console.ReadKey();

                Console.WriteLine("\n 'I can go home now...'");

                Console.ReadKey();

                Console.WriteLine("\n 'Thank you...'");

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n Silence quickly fills the air after their body desolves into the sky, leaving only their clothes...");

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\n Nothing...");

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.Title = "RAPTURE";

                Console.WriteLine("\n ENDING 1: RAPTURE...");

                Console.ReadKey(); 

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.Title = "Copy...";

                Console.WriteLine("\nFIGHT ME");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Black;
                
                Console.ReadKey();
            } else if (bong == "Connection terminated. I'm sorry to interrupt you, Elizabeth, if you still even remember that name, But I'm afraid you've been misinformed. You are not here to receive a gift, nor have you been called here by the individual you assume, although, you have indeed been called. You have all been called here, into a labyrinth of sounds and smells, misdirection and misfortune. A labyrinth with no exit, a maze with no prize. You don't even realize that you are trapped. Your lust for blood has driven you in endless circles, chasing the cries of children in some unseen chamber, always seeming so near, yet somehow out of reach, but you will never find them. None of you will. This is where your story ends. And to you, my brave volunteer, who somehow found this job listing not intended for you, although there was a way out planned for you, I have a feeling that's not what you want. I have a feeling that you are right where you want to be. I am remaining as well. I am nearby. This place will not be remembered, and the memory of everything that started this can finally begin to fade away. As the agony of every tragedy should. And to you monsters trapped in the corridors, be still and give up your spirits. They don't belong to you. For most of you, I believe there is peace and perhaps more waiting for you after the smoke clears. Although, for one of you, the darkest pit of Hell has opened to swallow you whole, so don't keep the devil waiting, old friend. My daughter, if you can hear me, I knew you would return as well. It's in your nature to protect the innocent. I'm sorry that on that day, the day you were shut out and left to die, no one was there to lift you up into their arms the way you lifted others into yours, and then, what became of you. I should have known you wouldn't be content to disappear, not my daughter. I couldn't save you then, so let me save you now. It's time to rest - for you, and for those you have carried in your arms. This ends for all of us. End communication.")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Title = "Why";

                Console.WriteLine("\n You're not funny.");
              
                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "NOT FUNNY";

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("\n ENDING 81: NOT FUNNY...");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\n Actually no, I'm not going to give you an ending for this. Do better.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

            } else if (bong == "hint" || bong == "Hint" || bong == "HINT" || bong == "hint!" || bong == "Hint!" || bong == "HINT!" || bong == "hint." || bong == "Hint." || bong == "HINT." || bong == "help" || bong == "Help" || bong == "HELP" || bong == "help!" || bong == "Help!" || bong == "HELP!" || bong == "help." || bong == "Help." || bong == "HELP.")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.Title = "No >:(";

                Console.WriteLine("\n What?"); 

                Console.ReadKey(); 

                Console.WriteLine("\n No, try harder."); 

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...Maybe if you ask nicely."); 

                Console.ReadKey();         
            } else if (bong == "Karlson" || bong == "karlson" || bong == "KARLSON" || bong == "karlson?" || bong == "Karlson?" || bong == "KARLSON?" || bong == "whats karlson?" || bong == "Whats karlson?" || bong == "Whats Karlson?" || bong == "whats Karlson?" || bong == "what's karlson?" || bong == "What's karlson?" || bong == "What's Karlson?" || bong == "what's Karlson?")
            {
                Console.Title = "";

                Console.WriteLine("\n 'What?'");

                Console.ReadKey();

                Console.WriteLine("\n '" + bong + "'? I don't know what that is, sounds pretty cool though.'");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.WriteLine("\n ...");

                Console.ReadKey();

                Console.Title = "Karlson funny";

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("\n 'Oh, you don't know what Karlson is?itsthisgammeamworkingonjglsvhdhsfope;wljf;lksd;vnhsafoeajsdlkjslshv-' \nAnd so he went on to explain the entire lore of 'Karlson', but still no one was listening, \ncausing him to explain it again, and again, and again, and again, \nand ag- And so he went on to explain the entire reason why he went on to explain the entire lore of 'Karlson'. \nAn endless loop that will never end... Because it is endless...");

                Console.ReadKey();

                Console.WriteLine("\n Much like numbers. Numbers are endless. Don't believe me? Watch I'll show you. 1 2 3 4 5 6 7 8 9- \nAnd so he went on to show you the entire lore of 'NUMBERS', acquiring the same fate as our other Narrators. \nAn endless loop that will never end... Becuase it is endless...");

                Console.ReadKey();

                Console.WriteLine("\n Much like this ending. This ending is endless. Don't believe me? Watch I'll show you-");

                Console.Title = "This Ending Sucks Sorry";

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("\n ENDING 2: ENDLESS..."); 

                Console.ReadKey(); 

                Console.ForegroundColor = ConsoleColor.DarkGray; 
                Console.BackgroundColor = ConsoleColor.DarkGray; 

                Console.WriteLine("\nFight me");

                quizComplete = true;
            } else if (bong == "hint please" || bong == "Hint please" || bong == "hint pls" || bong == "Hint pls" || bong == "hint please." || bong == "Hint please." || bong == "hint pls." || bong == "Hint pls.")
            {
                Console.Title = "";

                Console.WriteLine("\n 'No...'");

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray; 

                Console.WriteLine("\n Wait did you actually think saying '" + bong + "' would work? You did? Okay here go :)"); 

                Console.ReadKey();

                Console.Title = "Here Go :)";

                Console.WriteLine("\n After answering the question with 'bong', go to the end of the route and highlight the gray box with\n your mouse, then hold CTRL + C to copy the word. Hold CRTL + V to paste the word as the new answer to the question.");

                Console.ReadKey();
            } else if (bong == "bonk" || bong == "Bonk" || bong == "BONK" || bong == "bonk!" || bong == "Bonk!" || bong == "BONK!")
            {
                Console.Title = "Not Quite Right";

                Console.WriteLine("\n 'Yes- Wait, nevermind...'"); 

                Console.ReadKey();
            } else if (bong == "fight me" || bong == "Fight me" || bong == "FIGHT ME" || bong == "fight me!" || bong == "Fight me!" || bong == "FIGHT ME!" || bong == "fight me." || bong == "Fight me." || bong == "FIGHT ME." || bong == "attack me" || bong == "Attack me" || bong == "ATTACK ME" || bong == "attack me!" || bong == "Attack me!" || bong == "ATTACK ME!" || bong == "attack me." || bong == "Attack me." || bong == "ATTACK ME.")
            {
                Console.Title = "The Worst Part Is When You Can't Explain It";

                Console.WriteLine("\n 'What?'");

                Console.ReadKey(); 

                Console.Title = "";

                Console.WriteLine("\n 'You want me to fight you?'");

                Console.ReadKey(); 

                Console.WriteLine("\n 'Alright I guess, just know...'");

                Console.ReadKey();

                Console.WriteLine("\n 'I've never lossed a fight before...'");   

                bool fightScene = true;

                while (fightScene == true)
                {
                  Console.ForegroundColor = ConsoleColor.Blue;
                                   
                  Console.ReadKey(); 

                  Console.Title = "Smells Like Violence";                 

                  Console.WriteLine("\n They go into their 'SIGNATURE FIGHTING STANCE', creating a glowing red aura around them.\n and as their hair grows longer and turns to an almost glowing, silver color,\n you hear branches cracking and see dark clouds roll in from the sky.\n What do you do?"); 

                  Console.ForegroundColor = ConsoleColor.White;

                  string action = Console.ReadLine(); 

                  if (action == "attack" || action == "Attack" || action == "ATTACK" || action == "attack!" || action == "Attack!" || action == "ATTACK!" || action == "attack." || action == "Attack." || action == "ATTACK.") 
                  {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Title = "";

                    Console.WriteLine("\n As you throw your clenched fist at them,\n they swiftly deflect and return the favor by placing their palm on your chest, causing you to implode.");

                    Console.ReadKey();

                    Console.ForegroundColor = ConsoleColor.DarkBlue; 

                    Console.Title = "L";

                    Console.WriteLine("\n ENDING 3: L...");

                    fightScene = false;  
                  } else if (action == "block" || action == "Block" || action == "BLOCK" || action == "block!" || action == "Block!" || action == "BLOCK!" || action == "block." || action == "Block." || action == "BLOCK.") 
                  {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Title = "";

                    Console.WriteLine("\n Instantly terrified of their pressence, you cover your face with your hands.\n Your brain thinks this is blocking, but it isn't, it's cowering.");

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\n 'Uh... What... What are you doing?'"); 

                    Console.ForegroundColor = ConsoleColor.Blue; 

                    Console.WriteLine("\n Their booming voice echoed throughout");

                    Console.ForegroundColor = ConsoleColor.White; 

                    Console.WriteLine("\n  'I thought you wanted to fight, not... Whatever this is.\n I'm sorry if my 'SIGNATURE FIGHTING STANCE' is too much for you.\n We can be done if you want.'");

                    Console.ReadKey();

                    bool coward = true;

                    while (coward == true)
                    {  
                      Console.ForegroundColor = ConsoleColor.DarkGray;

                      Console.Title = "Hmmmm...";

                      Console.WriteLine("\n Quit?\n YES/NO");

                      Console.ForegroundColor = ConsoleColor.White;

                      string answer = Console.ReadLine();

                      if (answer == "yes" || answer == "Yes" || answer == "YES") 
                      {
                        Console.Title = "";

                        Console.WriteLine("\n 'Uh... Okay?'");

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.Blue; 

                        Console.WriteLine("\n After running away while crying like a pethetic little baby child,\n you get strucked by 5 lightning bolts simultaneously.\n You are now dead. Good job.");

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        Console.Title = "PLBC";

                        Console.WriteLine("\n ENDING 4: PLBC..."); 

                        coward = false;
                        fightScene = false; 
                      } else if (answer == "no" || answer == "No" || answer == "NO") 
                      {
                        Console.Title = "";

                        Console.WriteLine("\n 'Oh good, for a second there I thought you were a PLBC.'");

                        coward = false;
                      } else 
                      {
                        Console.Title = "Wat";

                        Console.WriteLine("\n 'What?'");

                        Console.ReadKey();
                      }
                    }
                  } else if (action == "hint" || action == "Hint" || action == "HINT" || action == "hint!" || action == "Hint!" || action == "HINT!" || action == "hint." || action == "Hint." || action == "HINT." || action == "help" || action == "Help" || action == "HELP" || action == "help!" || action == "Help!" || action == "HELP!" || action == "help." || action == "Help." || action == "HELP.") 
                  {
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.Title  = "Imagine Needing Help With This Part";

                    Console.WriteLine(" 'ATTACK'\n 'BLOCK'\n 'WAIT'\n 'STANCE'");
                  } else if (action == "wait" || action == "Wait" || action == "WAIT" || action == "wait!" || action == "Wait!" || action == "WAIT!" || action == "wait." || action == "Wait." || action == "WAIT.") 
                  {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Title = "";

                    Console.WriteLine("\n You wait to see what happens next, but nothing happens. Just two REDACTED,\n staring at eachother, waiting... at eachother.\n Eventually it starts to rain, but only on you. Thanks to their red aura, it is acting as a sheild aggainst the rain.\n In fact, the aura is catapulting the rain at you, and hard. You feel a sharp pain at your arm, then at you leg.\n You want to look down but are too affraid of what they will do once you lose focus.\n So, you wait, and after about 6 hours, the rain finally clears, but still the sharp pain at your arm and leg.");  

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\n 'Temptation is killing me but so will they.'\n 'But what if I'm literally dying right now.'\n 'No... Don't be stupid. Worse case it's just a flesh wound.'\n 'Flesh wounds are bad.'\n 'So is dying.'\n 'I agree, which is why we should look down.'"); 

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("\n As the voices continue to chatter, you wonder if you should look down,\n and why you are hearing voices in your head.");

                    Console.ReadKey();

                    bool look = false; 

                    while (look == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.Title = "Hmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm...";

                        Console.WriteLine("\n Look down?\n YES/NO"); 

                        Console.ForegroundColor = ConsoleColor.White;

                        string maybe = Console.ReadLine(); 

                        if (maybe == "yes" || maybe == "Yes" || maybe == "YES" || maybe == "yes!" || maybe == "Yes!" || maybe == "YES!" || maybe == "yes." || maybe == "Yes." || maybe == "YES.")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.Title = "";

                            Console.WriteLine("\n (Sorry in advance) Looking down you see that your arm and leg are fine and suddenly the sharp pain is gone,\n but before you can look back, you hear their voice behind you saying: 'Nothing personal, REDACTED.'\n And just like that, your body collapses onto the ground.\n If only you didn't look down."); 

                            Console.ReadKey();

                            Console.ForegroundColor = ConsoleColor.DarkBlue;

                            Console.Title = "UNLUCKY";

                            Console.WriteLine("\n ENDING 5: UNLUCKY..."); 

                            look = true;
                            fightScene = false;
                        } else if (maybe == "no" || maybe == "No" || maybe == "NO" || maybe == "no!" || maybe == "No!" || maybe == "NO!" || maybe == "no." || maybe == "No." || maybe == "NO.") 
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.Title = "";

                            Console.WriteLine("\n Finally, you decide not to look down.\n You have more important things to worry about, like why their head turned into a fruit with a beak and how.\n Could it be a hallucination? Or maybe that's just one of the many perks of having a red aura?\n Intrigued, you move to get a better look only to hear sloshing at your feet.\n Turns out it was a hallucination, a hallucination from blood loss, and that sloshing? A puddle of your own blood.\n Before you could react your body was already shutting down and eventually, you were dead.\n If only you could've stopped the bleeding in time.\n If only you looked down."); 

                            Console.ReadKey();

                            Console.ForegroundColor = ConsoleColor.DarkBlue;

                            Console.Title = "SO CLOSE"; 

                            Console.WriteLine("\n ENDING 6: SO CLOSE..."); 

                            look = true; 
                            fightScene = false; 
                        } else 
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;

                            Console.Title = "Nuh Uh";

                            Console.WriteLine("\n Um... No."); 

                            Console.ReadKey();
                        }
                    } 
                  } else if (action == "stance" || action == "Stance" || action == "STANCE" || action == "stance!" || action == "Stance!" || action == "STANCE!" || action == "stance." || action == "Stance." || action == "STANCE.") 
                  {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.Title = "";

                    Console.WriteLine("\n As you enter your stance, they give a nod of approval, recognizing the house you trained under."); 

                    Console.ForegroundColor = ConsoleColor.White; 

                    Console.WriteLine("\n 'I should've known i would be fighting one of my own today, though, I've never seen you before.\n Must've been before my time. But it doesn't matter now, does it? You're fate has already been decided.'"); 

                    Console.ForegroundColor = ConsoleColor.Blue;

                    bool stance = true;

                    while (stance == true)
                    {
                     Console.ForegroundColor = ConsoleColor.Blue;

                     Console.WriteLine("\n Without hesitation, they thrust their palm foward with violent intent,\n and Just as their palm is about to hit you, time slows.\n What do you do?"); 

                     Console.ForegroundColor = ConsoleColor.White;

                     string choice1 = Console.ReadLine();

                     if (choice1 == "attack" || choice1 == "Attack" || choice1 == "ATTACK" || choice1 == "attack!" || choice1 == "Attack!" || choice1 == "ATTACK!" || choice1 == "attack." || choice1 == "Attack." || choice1 == "ATTACK.") 
                     {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("\n As the thought of attacking crosses your mind, their palm slaps you across the cheek..."); 

                        Console.ReadKey(); 

                        Console.WriteLine("\n ...Then you implode."); 

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkBlue; 

                        Console.Title = "WHAT DID YOU EXPECT?"; 

                        Console.WriteLine("\n ENDING 9: WHAT DID YOU EXPECT?");

                        stance = false;
                        fightScene = false;
                     } else if (choice1 == "block" || choice1 == "Block" || choice1 == "BLOCK" || choice1 == "block!" || choice1 == "Block!" || choice1 == "BLOCK!" || choice1 == "block." || choice1 == "Block." || choice1 == "BLOCK.") 
                     {
                        bool stance2 = true;

                        while (stance2 == true)
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;

                          Console.Title = "Nice Job";

                          Console.WriteLine("\n After time fixes and you block their attack, they GET READY to throw their other palm at you.\n What do you do?");

                          Console.ForegroundColor = ConsoleColor.White;

                          string choice2 = Console.ReadLine(); 

                          if (choice2 == "attack" || choice2 == "Attack" || choice2 == "ATTACK" || choice2 == "attack!" || choice2 == "Attack!" || choice2 == "ATTACK!" || choice2 == "attack." || choice2 == "Attack." || choice2 == "ATTACK.")
                          {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.Title = "";

                            Console.WriteLine("\n Having enough time, you were able to attack just as they did causing both palms to collide\n and creating a tear in reality that quickly consumed both of you.\n Now in the void, you both come to a natural agreement and decide not to fight eachother.\n Instead you wonder if the giant void worm will eat you or not."); 

                            Console.ForegroundColor = ConsoleColor.White; 

                            Console.WriteLine("\n 'Surely they will protect me from this giant void worm.'"); 

                            Console.ForegroundColor = ConsoleColor.Blue; 

                            Console.WriteLine("\n You thought, but once you turned your head you realised that they were gone. How selfish.");

                            Console.ReadKey();

                            Console.ForegroundColor = ConsoleColor.DarkBlue; 

                            Console.Title = "VOID FOOD"; 

                            Console.WriteLine("\n ENDING 8: VOID FOOD...");

                            stance2 = false;
                            stance = false;
                            fightScene = false;
                          } else if (choice2 == "block" || choice2 == "Block" || choice2 == "BLOCK" || choice2 == "block!" || choice2 == "Block!" || choice2 == "BLOCK!" || choice2 == "block." || choice2 == "Block." || choice2 == "BLOCK.") 
                          {
                            Console.ForegroundColor = ConsoleColor.Blue;

                            Console.Title = "";

                            Console.WriteLine("\n You block again and wait for the strike of their palm,\n but when it finally comes the strike feels softer than expected.\n You lower your gaurd to follow up with an attack only to realise that they grabbed you and are about to-"); 

                            Console.ReadKey(); 

                            Console.ForegroundColor = ConsoleColor.DarkBlue; 

                            Console.Title = "BONES"; 

                            Console.WriteLine("\n ENDING 7: BONES..."); 

                            stance2 = false;
                            stance = false;
                            fightScene = false;
                          } else if (choice2 == "wait" || choice2 == "Wait" || choice2 == "WAIT" || choice2 == "wait!" || choice2 == "Wait!" || choice2 == "WAIT!" || choice2 == "wait." || choice2 == "Wait." || choice2 == "WAIT.")
                          {
                            bool stance3 = true;

                            while (stance3 == true)
                            {
                              Console.ForegroundColor = ConsoleColor.Blue;

                              Console.Title = "Almost There";

                              Console.WriteLine("\n As you grit your teeth and clench your... Fists, you wait for their palm to fly towards you and then block,\n feeling their palm bounce off your gaurd.\n They're exposed to an attack. What do you do?"); 

                              Console.ForegroundColor = ConsoleColor.White;

                              string choice3 = Console.ReadLine();

                              if (choice3 == "attack" || choice3 == "Attack" || choice3 == "ATTACK" || choice3 == "attack." || choice3 == "Attack." || choice3 == "ATTACK")
                              { 
                                Console.ForegroundColor = ConsoleColor.Blue;

                                Console.Title = "";

                                Console.WriteLine("\n As your palm is placed on their chest,\n you look at their face expecting to see fear but instead a smile begins to grow and a tear begins to fall.\n Just before you ended it, they pulled you in closer and whispered in your ear:"); 

                                Console.ForegroundColor = ConsoleColor.White; 

                                Console.WriteLine("\n 'I could have told you everything.'"); 

                                Console.ForegroundColor = ConsoleColor.Blue;
                                //add shabingus text
                                Console.WriteLine("\n When they left the clouds faded away revealing a red sky painted with black stars and a giant eye replacing the sun.\n What you did was good. Trust us."); 

                                Console.ReadKey(); 

                                Console.ForegroundColor = ConsoleColor.DarkBlue; 

                                Console.Title = "GOD KILLER"; 

                                Console.WriteLine("\n ENDING 11: GOD KILLER...");

                                Console.ReadKey(); 

                                Console.ForegroundColor = ConsoleColor.DarkGray; 
                                Console.BackgroundColor = ConsoleColor.DarkGray; 

                                Console.WriteLine("\nTEST");

                                stance3 = false;
                                stance2 = false;
                                stance = false;
                                fightScene = false;
                              } else if (choice3 == "block" || choice3 == "Block" || choice3 == "BLOCK" || choice3 == "block." || choice3 == "Block." || choice3 == "BLOCK.")
                              {
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.Title = "PLBC";

                                Console.WriteLine("\n GOO GOO GAA GAA okay now do the right thing.");

                                Console.ReadKey();
                              } else if (choice3 == "wait" || choice3 == "Wait" || choice3 == "WAIT" || choice3 == "wait." || choice3 == "Wait." || choice3 == "WAIT.")
                              {
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.Title = "";

                                Console.WriteLine("\n '...'"); 

                                Console.ReadKey(); 

                                Console.WriteLine("\n 'What are you doing?'");

                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.Blue; 

                                Console.WriteLine("\n After standing there for several seconds you finally decide to smile."); 

                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("\n 'I don't understand, Why-'"); 

                                Console.ForegroundColor = ConsoleColor.Blue; 

                                Console.WriteLine("\n You pull them in closer and whisper in their ear:"); 

                                Console.ForegroundColor = ConsoleColor.White; 

                                Console.WriteLine("\n 'Tell me everything.'"); 

                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.ReadKey(); 

                                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.WriteLine("\n You weren't supposed to do that");

                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.White; 

                                Console.Title = "Stop"; 

                                Console.WriteLine("\n01100100 01110101 01100011 01101011"); 

                                stance3 = false;
                                stance2 = false;
                                stance = false;
                                fightScene = false;
                              } else if (choice3 == "hint" || choice3 == "Hint" || choice3 == "HINT" || choice3 == "hint." || choice3 == "Hint." || choice3 == "HINT." || choice3 == "help" || choice3 == "Help" || choice3 == "HELP" || choice3 == "help." || choice3 == "Help." || choice3 == "HELP.")
                              {
                                Console.ForegroundColor = ConsoleColor.DarkGray; 

                                Console.Title = "";

                                Console.WriteLine("\n 'ATTACK'\n 'BLOCK'\n 'WAIT'"); 

                                Console.ReadKey();
                              } else 
                              {
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                Console.Title = "Type 'HINT'/'HELP' If You're Stuck";

                                Console.WriteLine("\n That is not an action you can do.");

                                Console.ReadKey();
                              }
                            }
                          } else if (choice2 == "hint" || choice2 == "Hint" || choice2 == "HINT" || choice2 == "hint." || choice2 == "Hint." || choice2 == "HINT." || choice2 == "help" || choice2 == "Help" || choice2 == "HELP" || choice2 == "help." || choice2 == "Help." || choice2 == "HELP.")
                          {
                            Console.ForegroundColor = ConsoleColor.DarkGray; 

                            Console.Title = "";

                            Console.WriteLine("\n 'ATTACK'\n 'BLOCK'\n 'WAIT'");

                            Console.ReadKey();
                          } else 
                          {
                            Console.ForegroundColor = ConsoleColor.DarkGray;

                            Console.Title = "Type 'HINT'/'HELP' If You're Stuck";

                            Console.WriteLine("\n That is not an action you can do.");

                            Console.ReadKey();
                          }
                        }
                     } else if (choice1 == "wait" || choice1 == "Wait" || choice1 == "WAIT" || choice1 == "wait!" || choice1 == "Wait!" || choice1 == "WAIT!" || choice1 == "wait." || choice1 == "Wait." || choice1 == "WAIT.")
                     {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("\n After chosing to w-wait? You chose to wait?\n The palm of someone with a GLOWING RED AURA and GLOWING SILVER HAIR is about to hit you and you chose to wait?\n What... A-Are you a masochist? Who would chose this!?\n Okay well as time fixes itself THE PALM OF SOMEONE WITH A GLOWING RED AURA AND GLOWING SILVER HAIR strikes your chest\n causing you to... I don't know they kill you or something. I don't care anymore."); 

                        Console.ReadKey(); 

                        Console.ForegroundColor = ConsoleColor.DarkBlue; 

                        Console.Title = "WHY?"; 
                        
                        Console.WriteLine("\n ENDING 10: WHY?");

                        stance = false;
                        fightScene = false;
                     } else if (choice1 == "hint" || choice1 == "Hint" || choice1 == "HINT" || choice1 == "hint!" || choice1 == "Hint!" || choice1 == "HINT!" || choice1 == "hint." || choice1 == "Hint." || choice1 == "HINT." || choice1 == "help" || choice1 == "Help" || choice1 == "HELP" || choice1 == "help." || choice1 == "Help." || choice1 == "HELP.")
                     {
                        Console.ForegroundColor = ConsoleColor.DarkGray;  

                        Console.Title = ""; 

                        Console.WriteLine("\n 'ATTACK'\n 'BLOCK'\n 'WAIT'"); 

                        Console.ReadKey();
                     } else 
                     {
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.Title = "Type 'HINT'/'HELP' If You're Stuck";

                        Console.WriteLine("\n That is not an action you can do.");

                        Console.ReadKey();
                     }
                    }
                  }  else
                  {
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.Title = "Type 'Hint'/'Help' If You're Stuck";

                    Console.WriteLine("\n That is not an action you can do");
                  }
                }
            } else if (bong == "duck" || bong == "Duck" || bong == "DUCK" || bong == "duck!" || bong == "Duck!" || bong == "DUCK!" || bong == "duck." || bong == "Duck." || bong == "DUCK.")
            {
              Console.Title = "?";

              Console.WriteLine("\n 'HJONK!'"); 

              Console.ReadKey(); 

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n LMAO Get pranked nerd."); 

              Console.ReadKey();
            } else if (bong == "test" || bong == "Test" || bong == "TEST" || bong == "test." || bong == "Test." || bong == "TEST.") 
            {
              Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.Title = "I wish I would cry more";

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.Title = "";

              Console.WriteLine("\n Hello, and welcome to the TEST.\n This TEST will rely on audio so make sure you listen closely.\n Before we start make sure you are as comfortable as possible and in your best state of mind,\n thank you for your cooperation.\n We are about to start in...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey(); 

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n 3..."); 

              Console.ForegroundColor = ConsoleColor.Black; 

              Console.ReadKey(); 

              Console.ForegroundColor = ConsoleColor.Green; 

              Console.WriteLine("\n 2..."); 

              Console.ForegroundColor = ConsoleColor.Black; 

              Console.ReadKey(); 

              Console.ForegroundColor = ConsoleColor.Green; 

              Console.WriteLine("\n 1..."); 

              Console.ForegroundColor = ConsoleColor.Black; 

              Console.ReadKey(); 

              bool test1 = true; 

              while (test1 == true)
              {
                Console.ForegroundColor = ConsoleColor.Green; 

                Console.Title = "Listen";

                Console.WriteLine("\n Do you hear it?\n YES/NO"); 

                Console.ForegroundColor = ConsoleColor.White;

                string sound = Console.ReadLine();

                if (sound == "yes" || sound == "Yes" || sound == "YES" || sound == "yes." || sound == "Yes." || sound == "YES.")
                {
                  Console.Title = "";

                  Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                  Console.ForegroundColor = ConsoleColor.Black; 

                  Console.ReadKey(); 

                  Console.ForegroundColor = ConsoleColor.Green; 

                  Console.WriteLine("\n I don't appreciate liars.");
                  
                  Console.ForegroundColor = ConsoleColor.Black; 

                  Console.ReadKey();
                } else if (sound == "no" || sound == "No" || sound == "NO" || sound == "no." || sound == "No." || sound == "NO.")
                {
                  Console.ForegroundColor = ConsoleColor.Green; 

                  Console.Title = "38,000 HZ"; 

                  Console.WriteLine("\n Good. What is playing now is a frequency of about 38,000 HZ, a frequency too high to hear.\n This test is to see the effects of high frequencies and what they can do to the human brain.\n You will be given questions to answer, and results for your answers at the end.\n The frequencies will get higher as you complete the answers and will be displayed at the top left corner,\n pay attention to it.");

                  bool test2 = true;

                  int hamburger = 0;

                  int score = 0;

                  while (test2 == true)
                  {            
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Title = "38,000 HZ";

                    Console.WriteLine("\n Ready?\n YES/NO");

                    Console.ForegroundColor = ConsoleColor.White; 

                    string ready = Console.ReadLine(); 
                    
                    if (ready == "yes" || ready == "Yes" || ready == "YES" || ready == "yes." || ready == "Yes." || ready == "YES." || ready == "no" || ready == "No" || ready == "NO" || ready == "no." || ready == "No." || ready == "NO.") 
                    {                     
                      bool question1 = true;  

                      Console.ForegroundColor = ConsoleColor.Green; 

                      Console.WriteLine("\n Good."); 

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      while (question1 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "38,000 HZ";

                        Console.WriteLine("\n Question one:\n The Earth is round.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White; 

                        string answer1 = Console.ReadLine(); 

                        if (answer1 == "true" || answer1 == "True" || answer1 == "TRUE" || answer1 == "true." || answer1 == "True." || answer1 == "TRUE.")
                        {
                         score = score + 1; 

                          question1 = false;
                        } else if (answer1 == "false" || answer1 == "False" || answer1 == "FALSE" || answer1 == "false." || answer1 == "False." || answer1 == "FALSE.")
                        {
                          question1 =false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }  
                      }
                      bool question2 = true;

                      while (question2 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green; 

                        Console.Title = "40,000 HZ";

                        Console.WriteLine("\n Question two:\n All Spiders have eyes.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer2 = Console.ReadLine(); 

                        if (answer2 == "true" || answer2 == "True" || answer2 == "TRUE" || answer2 == "true." || answer2 == "True." || answer2 == "TRUE.")
                        {
                          question2 = false;
                        } else if (answer2 == "false" || answer2 == "False" || answer2 == "FALSE" || answer2 == "false." || answer2 == "False." || answer2 =="FALSE.")
                        {
                          score = score + 1;

                          question2 = false; 
                        } else 
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question3 = true; 

                      while (question3 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "44,000 HZ";

                        Console.WriteLine("\n Question three:\n If you hold any object in the air then let go, it will always fall down immediately.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer3 = Console.ReadLine();

                        if (answer3 == "true" || answer3 == "True" || answer3 == "TRUE" || answer3 == "true." || answer3 == "True." || answer3 == "TRUE.")
                        {
                          question3 = false;
                        } else if (answer3 == "false" || answer3 == "False" || answer3 == "FALSE" || answer3 == "false." || answer3 == "False." || answer3 == "FALSE.")
                        {
                          score = score + 1;

                          question3 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question4 = true; 

                      while (question4 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "50,000 HZ";

                        Console.WriteLine("\n Question four:\n M.O.M Stands for MEET OUR MAKER.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White; 

                        string answer4 = Console.ReadLine();

                        if (answer4 == "true" || answer4 == "True" || answer4 == "TRUE" || answer4 == "true." || answer4 == "True." || answer4 == "TRUE.")
                        {
                          question4 = false;
                        } else if (answer4 == "false" || answer4 == "False" || answer4 == "FALSE" || answer4 == "false." || answer4 == "False." || answer4 == "FALSE.")
                        {
                          score = score + 1;

                          question4 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question5 = true;

                      while (question5 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green; 

                        Console.Title = "58,000 HZ"; 

                        Console.WriteLine("\n Question five:\n Everything will die eventually.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer5 = Console.ReadLine(); 

                        if (answer5 == "true" || answer5 == "True" || answer5 == "TRUE" || answer5 == "true." || answer5 == "True." || answer5 == "TRUE.")
                        {
                          score = score + 1;

                          question5 = false;
                        } else if (answer5 == "false" || answer5 == "False" || answer5 =="FALSE" || answer5 == "false." || answer5 == "False." || answer5 == "FALSE.")
                        {
                          question5 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question6 = true;

                      while (question6 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "68,000 HZ";

                        Console.WriteLine("\n Question six:\n The Human hand has five fingers and one thumb.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer6 = Console.ReadLine();

                        if (answer6 == "true" || answer6 == "True" || answer6 == "TRUE" || answer6 == "true." || answer6 == "True." || answer6 == "TRUE.")
                        {
                          question6 = false;
                        } else if (answer6 == "false" || answer6 == "False" || answer6 == "FALSE" || answer6 == "false." || answer6 == "False." || answer6 == "FALSE.")
                        {
                          score = score + 1;

                          question6 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.Title = "999,999 HZ";

                      Console.WriteLine("\n I'm looking forward to it.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question7 = true;

                      while (question7 == true)
                      {
                        Console.Title = "80,000";

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n Question seven:\n Every one in 30 people Brakes a bone for the first time at the age of Fifteen.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer7 = Console.ReadLine();

                        if (answer7 == "true" || answer7 == "True" || answer7 == "TRUE" || answer7 == "true." || answer7 == "True." || answer7 =="TRUE.")
                        {
                          question7 = false;
                        } else if (answer7 == "false" || answer7 == "False" || answer7 == "FALSE" || answer7 == "false." || answer7 == "False." || answer7 == "FALSE.")
                        {
                          score = score + 1;

                          question7 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question8 = true;

                      while (question8 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "94,000 HZ";

                        Console.WriteLine("\n Question eight:\n Fear of the Unknown is the purest form of fear.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer8 = Console.ReadLine();

                        if (answer8 == "true" || answer8 == "True" || answer8 == "TRUE" || answer8 == "true." || answer8 == "True." || answer8 == "TRUE.")
                        {
                          score = score + 1;

                          question8 = false;
                        } else if (answer8 == "false" || answer8 == "False" || answer8 == "FALSE" || answer8 == "false." || answer8 == "False." || answer8 == "FALSE.")
                        {
                          question8 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question9 = true;

                      while (question9 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "120,000 HZ";

                        Console.WriteLine("\n Question nine:\n It is possible to smile without a jaw.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer9 = Console.ReadLine();

                        if (answer9 == "true" || answer9 == "True" || answer9 == "TRUE" || answer9 == "true." || answer9 == "True." || answer9 == "TRUE.")
                        {
                          score = score + 1;

                          question9 = false;
                        } else if (answer9 == "false" || answer9 == "False" || answer9 == "FALSE" || answer9 == "false." || answer9 == "False." || answer9 == "FALSE.")
                        {
                          question9 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question10 = true;

                      while (question10 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "138,000 HZ";

                        Console.WriteLine("\n Question ten:\n Grandpa eats nails.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer10 = Console.ReadLine();

                        if (answer10 == "true" || answer10 == "True" || answer10 == "TRUE" || answer10 == "true." || answer10 == "True." || answer10 == "TRUE.")
                        {
                          score = score + 1;

                          question10 = false;
                        } else if (answer10 == "false" || answer10 == "False" || answer10 == "FALSE" || answer10 == "false." || answer10 == "False." || answer10 == "FALSE.")
                        {
                          question10 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question11 = true;

                      while (question11 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "158,000 HZ";

                        Console.WriteLine("\n Question eleven:\n Everything will die soon.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer11 = Console.ReadLine();

                        if (answer11 == "true" || answer11 == "True" || answer11 == "TRUE" || answer11 == "true." || answer11 == "True." || answer11 == "TRUE.")
                        {
                          question11 = false;
                        } else if (answer11 == "false" || answer11 == "False" || answer11 == "FALSE" || answer11 == "false." || answer11 == "False." || answer11 == "FALSE.")
                        {
                          score = score + 1;

                          question11 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n If she doesn't answer...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question12 = true;

                      while (question12 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "180,000 HZ";

                        Console.WriteLine("\n Question twelve:\n She is Growing.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer12 = Console.ReadLine();

                        if (answer12 == "true" || answer12 == "True" || answer12 == "TRUE" || answer12 == "true." || answer12 == "True." || answer12 == "TRUE.")
                        {
                          score = score + 1;

                          question12 = false;
                        } else if (answer12 == "false" || answer12 == "False" || answer12 == "FALSE" || answer12 == "false." || answer12 == "False." || answer12 == "FALSE.")
                        {
                          question12 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n ...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      bool question13 = true;

                      while (question13 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "204,000 HZ";

                        Console.WriteLine("\n Question thirteen:\n M.O.M Stands for MASS OF MUSCLE.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer13 = Console.ReadLine();

                        if (answer13 == "true" || answer13 == "True" || answer13 == "TRUE" || answer13 == "true." || answer13 == "True." || answer13 == "TRUE.")
                        {
                          score = score + 1;

                          question13 = false;;
                        } else if (answer13 == "false" || answer13 == "False" || answer13 == "FALSE" || answer13 == "false." || answer13 == "False." || answer13 == "FALSE.")
                        {
                          question13 = false;
                        } else 
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Save us...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.DarkGray;

                      Console.WriteLine("\n ...");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n Creature of The Beyond.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question14 = true;

                      while (question14 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "230,000 HZ";;

                        Console.WriteLine("\n Question fourteen:\n Hallucinations are common in life.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer14 = Console.ReadLine();

                        if (answer14 == "true" || answer14 == "True" || answer14 == "TRUE" || answer14 == "true." || answer14 == "True." || answer14 == "TRUE.")
                        {
                          score = score + 1;

                          question14 = false;
                        } else if (answer14 == "false" || answer14 == "False" || answer14 == "FALSE" || answer14 == "false." || answer14 == "False." || answer14 == "FALSE.")
                        {
                          question14 = false;
                        } else 
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Save us...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n Made of Flesh and Muscle.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question15 = true;

                      while (question15 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "258,000 HZ";
                        
                        Console.WriteLine("\n Question fifteen:\n In a single day, the blood in your body travels about 12,000 miles.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer15 = Console.ReadLine();

                        if (answer15 == "true" || answer15 == "True" || answer15 == "TRUE" || answer15 == "true." || answer15 == "True." || answer15 == "TRUE.")
                        {
                          score = score + 1;

                          question15 = false;
                        } else if (answer15 == "false" || answer15 == "False" || answer15 == "FALSE" || answer15 == "false." || answer15 == "False." || answer15 == "FALSE.")
                        {
                          question15 = false;
                        } else 
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Save us...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n Hear us.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question16 = true;

                      while (question16 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "288,000 HZ";

                        Console.WriteLine("\n Question sixteen:\n The Beyond is impossible to reach.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer16 = Console.ReadLine();

                        if (answer16 == "true" || answer16 == "True" || answer16 == "TRUE" || answer16 == "true." || answer16 == "True." || answer16 == "TRUE.")
                        {
                          score = score + 1;

                          question16 = false;
                        } else if (answer16 == "false" || answer16 == "False" || answer16 == "FALSE" || answer16 == "false." || answer16 == "False." || answer16 == "FALSE.")
                        {
                          question16 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Save us...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n Come to us.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question17 = true;

                      while (question17 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "312,000 HZ";

                        Console.WriteLine("\n Question seventeen:\n Are you paying Attention?\n Yes or No?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer17 = Console.ReadLine();

                        if (answer17 == "yes" || answer17 == "Yes" || answer17 == "YES" || answer17 == "yes." || answer17 == "Yes." || answer17 == "YES.")
                        {
                          question17 = false;
                        } else if (answer17 == "no" || answer17 == "No" || answer17 == "NO" || answer17 == "no." || answer17 == "No." || answer17 == "NO.")
                        {
                          question17 = false;
                        } else 
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Save us...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n Answer us.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question18 = true;

                      while (question18 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "348,000 HZ";

                        Console.WriteLine("\n Question eighteen:\n The Frequency last question was '324,000 HZ'\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer18 = Console.ReadLine();

                        if (answer18 == "true" || answer18 == "True" || answer18 == "TRUE" || answer18 == "true." || answer18 == "True." || answer18 == "TRUE.")
                        {
                          question18 = false;
                        } else if (answer18 == "false" || answer18 == "False" || answer18 =="FALSE" || answer18 == "false." || answer18 == "False." || answer18 == "FALSE.")
                        {
                          score = score + 2;

                          question18 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Save us...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n Only one Question. One Question to answer.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      bool question19 = true;

                      while (question19 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "386,000 HZ";

                        Console.WriteLine("\n Question nineteen:\n There is no one Behind you.\n True or False?");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer19 = Console.ReadLine();

                        if (answer19 == "true" || answer19 == "True" || answer19 == "TRUE" || answer19 == "true." || answer19 == "True." || answer19 == "TRUE.")
                        {
                          question19 = false;
                        } else if (answer19 == "false" || answer19 == "False" || answer19 == "FALSE" || answer19 == "false." || answer19 == "False." || answer19 == "FALSE.")
                        {
                          score = score + 1;

                          question19 = false;
                        } else 
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n Please...");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Gray;

                      Console.WriteLine("\n What is the PH balance of Sprite?");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                      Console.ReadKey();

                      bool question20 = true;
                      
                      while (question20 == true)
                      {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.Title = "428,000 HZ";

                        Console.WriteLine("\n 'Question twenty:\n The PH Balance of Sprite is Around 3.3\n True or False?'");

                        Console.ForegroundColor = ConsoleColor.White;

                        string answer20 = Console.ReadLine();

                        if (answer20 == "true" || answer20 == "True" || answer20 == "TRUE" || answer20 == "true." || answer20 == "True." || answer20 == "TRUE.")
                        {
                          score = score + 1;

                          question20 = false;
                        } else if (answer20 == "false" || answer20 == "False" || answer20 == "FALSE" || answer20 == "false." || answer20 == "False." || answer20 == "FALSE.")
                        {
                          question20 = false;
                        } else
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;

                          Console.Title = "";

                          Console.WriteLine("\n YES! OHHHHHHHHHHHHHHHHHHHHHHHHHH SHE SAID IT! SHE ACTUALLY SAID IT! I CAN'T BELIEVE IT! OH MY WORD!\n YEEEEEEEESSSS!!!!!!! FINALLY!!!! NOW WE KNOW! WE FINALLY KNOW WHAT THE PH BALANCE IS! I AM SO HAPPY!\n YYYYYYYYYYYYYYYEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE-");

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      Console.ForegroundColor = ConsoleColor.Green;

                      Console.Title = "470,000 HZ";

                      Console.WriteLine("\n Thank you for participating in the TEST. We hope you enjoyed, and we hope you survive (The hallucinations are common).\n Your final score is...");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      if (score == 0 && hamburger == 0)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "504,000 HZ";

                        Console.WriteLine("\n " + score + "?" + "\n\n Oh... Oh no. That's embarrassing. Not a single one? Really? Were you trying to get the lowest score possible?\n If so then good job, you nailed it. If not then, well,\n I would say better luck next time but I don't think there should be a 'next time'.\n I think you should leave. Now. You disgust me.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.Title = "DISGUSTING";

                        Console.WriteLine("\n ENDING 12: DISGUSTING...");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.Title = "";

                        Console.WriteLine("\nDUEL ME!");

                       test1 = false; 
                       test2 = false;
                      } else if (score >= 1 && score < 6 && hamburger == 0)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "504,000 HZ";

                        Console.WriteLine("\n " + score + "!" + "\n\n A pretty bad score, but I've seen worse.\n Next time try to do better and who knows, maybe you'll get something.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\n ...");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\nDUEL ME!");

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("\n Answer the 'Ready?' question with this, it should help.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        test1 = false;
                        test2 = false;
                      } else if (score >= 6 && score < 11 && hamburger == 0)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "504,000 HZ";

                        Console.WriteLine("\n " + score + "!" + "\n\n An avrage score, but not good.\n Next time try to do better and who knows, maybe you'll get something.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\n ...");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\nDUEL ME!");

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("\n Answer the 'Ready?' question with this, it should help.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        test1 = false;
                        test2 = false; 
                      } else if (score >= 11 && score < 16 && hamburger == 0)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "504,000 HZ";

                        Console.WriteLine("\n " + score + "!" + "\n\n A not bad score, but you could do better.\n Next time try to do better and who knows, maybe you'll get something.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\n ...");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\nDUEL ME!");

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("\n Answer the 'Ready?' question with this, it should help.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        test1 = false;
                        test2 = false;
                      } else if (score >= 16 && score < 20 && hamburger == 0)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "504,000 HZ";

                        Console.WriteLine("\n " + score + "!" + "\n\n A good score, but not perfect.\n Next time try to do better and who knows, maybe you'll get something.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\n ...");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine("\nDUEL ME!");

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.WriteLine("\n Answer the 'Ready?' question with this, it should help.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        test1 = false;
                        test2 = false;
                      } else if (score == 20 && hamburger == 0)
                      {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "504,000 HZ";

                        Console.WriteLine("\n " + score + "!" + "\n\n HOLY SHIGAMAWHATZIT! A perfect score! Good job. I'm sure you tried really hard to get this, so, here you go.");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Title = "PERFECT";

                        Console.WriteLine("\n ENDING 13: PERFECT...");

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.Title = "";

                        Console.WriteLine("\nDUEL ME!");

                        test1 = false;
                        test2 = false;
                      } else 
                      {
                        Console.BackgroundColor = ConsoleColor.DarkRed;

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.Title = "";

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.Gray;;

                        Console.WriteLine("\n You cheated...");

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ReadKey();

                        Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.Title = "CHEATER";

                        Console.WriteLine("\n ENDING 14: CHEATER...");

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.BackgroundColor = ConsoleColor.DarkGray;

                        Console.Title = "";

                        Console.WriteLine("\nDUEL ME!");

                        test1 = false;
                        test2 = false;
                      }
                    } else if (ready == "hamburger" && hamburger == 0 || ready == "Hamburger" && hamburger == 0 || ready == "HAMBURGER" && hamburger == 0 || ready == "hamburger." && hamburger == 0 || ready == "Hamburger." && hamburger == 0 || ready == "HAMBURGER." && hamburger == 0)
                    {
                      score = score + 10;

                      hamburger = hamburger + 1;

                      Console.ForegroundColor = ConsoleColor.DarkGray;

                      Console.Title = ready;

                      Console.WriteLine("\n " + ready);

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    } else if (ready == "hamburgerer" && hamburger == 1 || ready == "Hamburgerer" && hamburger == 1 || ready == "HAMBURGERER" && hamburger == 1 || ready == "hamburgerer." && hamburger == 1 || ready == "Hamburgerer." && hamburger == 1 || ready == "HAMBURGERER." && hamburger == 1)
                    {
                      score = score + 10;

                      hamburger = hamburger + 1;

                      Console.ForegroundColor = ConsoleColor.DarkGray;

                      Console.Title = ready;

                      Console.WriteLine("\n " + ready);

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    } else 
                    {
                      Console.ForegroundColor = ConsoleColor.Gray; 

                      Console.Title = "";

                      Console.WriteLine("\n ..."); 

                      Console.ForegroundColor = ConsoleColor.Black; 

                      Console.ReadKey();
                    }
                  }                
                } else 
                {
                  Console.ForegroundColor = ConsoleColor.Gray; 

                  Console.Title = ""; 

                  Console.WriteLine("\n ..."); 

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }
              }
            } else if (bong == "duel me" || bong == "Duel me" || bong == "DUEL ME" || bong == "duel me." || bong == "Duel me." || bong == "DUEL ME." || bong == "duel me!" || bong == "Duel me!" || bong == "DUEL ME!")
            {
              //Place holder line(?) :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.Title = "I Just Have To Get Through This Last One...";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.White;
              
              Console.WriteLine("\n 'What?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'You want me to duel you?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Alright I guess, just know...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'I am Zotori Makamori. I have never lost a duel, and I tend to keep it that way...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;
              
              Console.WriteLine("\n They go into there 'SIGNATURE DUELING STANCE', creating a glowing blue aura around them.\n And as their eyes glow brighter and turns into an almost pure, white color,\n you hear cards flipping and see a circle of pillars erect around you from the ground.");          

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Hmm... It looks like the bare minimum would fit your pathetic presence.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n As Makamori smirks, two final pillars erect. One beneath your feet and the other beneath Makamori's,\n raising you both several feet above the ground. Then, two holographic screens appear, both displaying '0 POINTS'.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'I built this stadium myself. Impressive, hmm? I think you'll agree it adds a bit more life to the game.\n I hope I don't have to explain the rules to you. After all, you're the one who challenged me,\n But dueling someone who knows not the rules, well... Where's the honor in that?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Learn the rules?");

              bool rules = true;

              while (rules == true)
              {
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n YES/NO");

                Console.ForegroundColor = ConsoleColor.White;

                string RA = Console.ReadLine();

                if (RA == "yes" || RA == "Yes" || RA == "YES" || RA == "yes." || RA == "Yes." || RA == "YES.")
                {
                  Console.Title = "Learning :)";

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'Are you just here to waste my time? I know I just offered to show you the rules but\n I honestly thought you already knew them. I guess I gave you too much credit.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n As Makamori sighs, he waves a hand in the air and a voice starts to speak through the screens. It says:");

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine(" 'The rules are simple, both players draw a random card from their deck,\n those cards will be played for that round and that round only.\n On the first round, you (the pathetic one) will go first.\n Once the cards have been placed, and since you go first,\n you get to pick if your card acts AGGRESSIVE or DEFENSIVE.\n There is only one right and wrong answer.\n Choosing correctly will give you a point, but choosing incorrectly will give the other player a point.\n Pay attention to the rounds' matchup, it may help with figuring out the correct answer.\n After the round is done, both players discard the cards they've placed and draw another card from their decks,\n entering the next round and giving the turn to the other player.\n The game will continue untill all cards have been used, then, the player with the most points wins.\n Remember, there is always a way to defeat the opponents' card, no matter how strong it is.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'I hope that dull brain of yours understood that.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  rules = false;
                } else if (RA == "no" || RA == "No" || RA == "NO" || RA == "no." || RA == "No." || RA == "NO.")
                {
                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'Of course not. No one is dumb enough to challenge me without even knowing the rules... Obviously'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  rules = false;
                } else
                {
                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'Say yes or no.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }
              }

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'But enough of that...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              int PP = 0;

              int MP = 0;

              Console.Title = "Smells Like Card Violence";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'IT'S TIME TO DUEL!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Another hologram appears next to you, this time in the form of a dueling desk.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori places a card on his desk.\n Then a giant group of bears (all fitted with bandanas) appear.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'I play The ACQUISITIVE FL BEARS!\n A species known for playing it safe, digging underground tunnels under homes and intentionally causing\n sink holes to steal... things. I honestly don't know what they steal.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'What's wrong? Gave up already? You haven't drawn your card yet.");

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

              Console.ForegroundColor = ConsoleColor.White;

              string card1 = Console.ReadLine();

              Console.WriteLine("\n '" + card1 + "? PAH! I guess the bare minimum was too good for you.\n You couldn't have even played a D-tier card. How sad.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              bool AD1 = true;
              bool sad = false;

              while (AD1 == true)
              {
                Console.Title = "HMMMMMMmmmmmmmmmmm";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n AGGRESSIVE or DEFENSIVE?");

                Console.ForegroundColor = ConsoleColor.White;

                string D1 = Console.ReadLine();

                if (D1 == "aggressive" || D1 == "Aggressive" || D1 == "AGGRESSIVE" || D1 == "aggressive." || D1 == "Aggressive." || D1 == "AGGRESSIVE.")
                {
                  Console.Title = "ATTACK!";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n As the word '" + D1 + "' leaves your mouth, " + card1 + " darts forward with a red glint in its eyes.\n But before " + card1 + " even tried to attack, the FL BEARS had vanished, leaving a mound of dirt behind.\n Suddenly, " + card1 + " starts to hear muffled growling beneath their feat.\n Makamori cackles as if he's alread won.\n The ground starts to vibrate, the pebbles start to bounce like a startled rat, and " + card1 + " starts to sink.\n Before you could hold your breath and cross your fingers,\n " + card1 + " was gone, you had lost that round...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.White;
                  
                  Console.WriteLine("\n 'HAH! Wow that was bad, I mean WOW that was bad.\n You couldn't have gotten an easier card then that, I practically spelled it out for you.\n A species know for playing it safe, come on man, I'm starting to feal bad...'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'HEH! No I'm not.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  MP++;

                  AD1 = false;
                } else if (D1 == "defensive" || D1 == "Defensive" || D1 == "DEFENSIVE" || D1 == "defensive." || D1 == "Defensive." || D1 == "DEFENSIVE.")
                {
                  Console.Title = "DEFEND!";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n " + card1 + " holds its ground, staring into the eyes of the FL BEARS.\n The bears roar collectively, creating a lound boom of intimidation,\n but " + card1 + " doesn't even flinch, the cards are loyal and will do what you say.\n Eventually, one of the bears grew impatient and began to dig.\n You notice the other bears communicating with the impatient one,\n you figure they are trying to convince the impatient bear to stop digging,\n but their protests did nothing, the impatient bear continued and shortly after, the other bears joined.\n " + card1 + " waits, and so do you.\n " + card1 + " stays vigilant, and so do you.\n Focusing on the dirt beneath " + card1 + ",\n noticing the grass swaying from the wind,\n watching a bee land on a flower,\n seeing the ground behind " + card1 + " sink...- You gasp, then hold it.\n You want to yell. Tell " + card1 + " he's in danger. But you can't.\n You're body is frozen from shock. You can't even blink.\n You're forced to watch " + card1 + "'s demise. Forced to watch defeat.");

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine(" 'HA! I win-'");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" Makamori gets cut short as you see " + card1 + " punch the ground behind them,\n shooting a cloud of dirt into the air.\n When you look closer, you start to see a red mist behind the dirt cloud,\n then, a bear falls onto the ground with a wet squish.\n Another bear falls on top of the last, then two more, then, the rest.\n The FL BEARS are dead. You won the round...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'WHAT?! WHAT ARE YOU DOING, YOU STUPID BEARS?! GET UP! " + card1 + "'S NOT DEAD YET!'");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" Makamori takes a breath... then whispers:");

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine(" 'There were so many of you... And just one of them... Whatever... I don't care...'");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" Makamori wipes a tear away, then corects his posture.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  PP++;

                  AD1 = false;
                  sad = true;
                } else
                {
                  Console.Title = "Bruh";

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'That's not what you're suppose to say.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }
              }

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A voice emits from the Screens...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'The Score is (" + PP + " Your Points) to (" + MP + " Makamori's Points)'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              if (sad == true)
              {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'Please just give me a good card...'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();
              }

              Console.Title = "Smells Like Card Violence";
              
              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori draws a card, grins, then a lanky, mask wearing, hol(l)ographic creature whith an arched posture appears.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'I play the HOLLO BOY, a bug like creature weilding a large nail.\n This creature can infect it's enemy's, leading to a quick but painful death.\n Once infected, there is no escaping. Your turn...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

              Console.ForegroundColor = ConsoleColor.White;

              string card2 = Console.ReadLine();

              Console.WriteLine("\n 'Huh? " + card2 + "? Your deck doesn't make any sense at all!\n First you play " + card1 + ", an E-tier card, then you play " + card2 + ", an S-tier card.\n Do you just throw whatever card you want into your deck or do you know something I don't?\n Ehhh who am I kidding, of course you don't know what you're doing.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Random numberGen = new Random();

              int roll = 0;

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Finally it's my turn. Let's see...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              roll = numberGen.Next(1, 3);

              if (roll == 1)
              {
                Console.Title = "Makamori's Aggressive!";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'Aggressive!'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;
                
                Console.WriteLine("\n HOLLO BOY suddenly moves -as if activated by Makamori's words,\n and starts to drag his nail on the ground leaving behind a trail.\n Although clearly initiating the fight, HOLLO BOY is at walking pace, like a tiger stalking it's ablivious prey.\n A mask with no eyes, yet still staring " + card2 + " down,\n and " + card2 + " stares back at the abyss that is HOLLO BOY's eyes.\n He's getting closer. HOLLO BOY stick's out his empty hand with a twitch,\n then a thick, orange liquid starts to form inside.\n He hurls it at " + card2 + ", but " + card2 + " dodges,\n and as the liquid lands behind them, " + card2 + " hears a loud sizzle.\n HOLLO BOY continue's to create and throw more liquid at " + card2 + ", and " + card2 + " continue's to evade.\n Eventually HOLLO BOY stops, frozen, just like before the fight.\n You glance over to Makamori and see a toothy grin.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'There's something I forgot to mention...'");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(" He begins.");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" 'Those 'trails' HOLLO BOY has been making on the ground...'");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(" You look back at the arena to see " + card2 + " standing in a large circle drawn in the dirt by HOLLO BOY's nail.");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(" 'It's not just for show...'");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Suddenly the circle starts to glow orange, then the glow crawls to the center -Towards " + card2 + ".\n HOLLO BOY lifts his large weapon and points it at " + card2 + ",\n then a fountain of the thick, orange liquid bursts out along the outer rim of the circle,\n obscuring your view of " + card2 + ".\n The fountain continues for several seconds, shooting into the air and splashing onto the ground,\n until finally, it clears revealing " + card2 + ".\n A melted corpse with exposed insides. A miserable puddle on the ground.\n Looking back at HOLLO BOY, you see he is frozen, still pointing his nail at his victim.\n You lost this round...");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                MP++;
              } else if (roll == 2)
              {
                Console.Title = "Makamori's Defensive!";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'Defensive!'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n HOLLO BOY slowly approaches " + card2 + ", " + card2 + " does the same.\n As they get closer, HOLLO BOY stops, " + card2 + " does the same.\n Now they wait for the right moment to strike.\n A standoff between two beasts, knowing one mistake could lead to a quick death.\n HOLLO BOY twitches, then " + card2 + " strikes.\n HOLLO BOY swings his nail and impacts the strike effectively parrying " + card2 + "'s attack.\n " + card2 + " strikes again. HOLLO BOY parries again.\n Another strike from " + card2 + ". Another parry from HOLLO BOY.\n Eventually " + card2 + " stops, wheezing and struggling to stand. A disgusting smirk grows on Makamori's face.\n HOLLO BOY lifts his nail above his mask. " + card2 + " holds out his hand as if begging for mercy.\n But it didn't matter, even if HOLLO BOY could hear them, there was no reasoning with a feral animal.\n Accepting defeat, you close your eyes and wait...");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n A metal clang rings in your ears as you open your eyes.\n A parry from " + card2 + ". There it is. That one mistake.\n One final strike from " + card2 + ",\n cracking open HOLLO BOY's mask and causing him to colapse onto the ground.\n Orange liquid starts to ooze out of the mask, then drip on a small rock next to him, burning a hole into it.\n " + card2 + " turns to face Makamori, then, a disgusting smirk grows on " + card2 + "'s face.\n " + card2 + " won the round...");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                PP++;
              } else
              {
                Console.Title = "How Did You Get Here?";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n Hi :)");
              }

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A voice emits from the Screens...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ")'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "Smells Like Card Violence";

              Console.ForegroundColor = ConsoleColor.Magenta;

              //Pipe bomb michiveous :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.WriteLine("\n Makamori places his newly drawn card, then a large, human shaped figure appears. It seems to be made of bones.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Say hello to MR. BONES. A strange, human-like creature made of only... bones.\n It is said that no one has ever actually seen him move,\n but he does appear at different locations, mostly behind corners.\n If you stand near him you can hear the faint sounds of strong winds coming from inside him.\n But don't stand too close, like a ticking bomb, he's known for being very aggressive if he's around you for too long.\n There has been 23 recorded deaths caused by MR. BONES, but those are only the recorded ones.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

              Console.ForegroundColor = ConsoleColor.White;

              string card3 = Console.ReadLine();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'HMPH! I hope you know how to use " + card3 + ".'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              bool AD2 = true;

              while (AD2 == true)
              {
                Console.Title = "HMMMMMMmmmmmmmmmmm 2: The Sequal";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n AGGRESSIVE or DEFENSIVE?");

                Console.ForegroundColor = ConsoleColor.White;

                string D2 = Console.ReadLine();

                if (D2 == "aggressive" || D2 == "Aggressive" || D2 == "AGGRESSIVE" || D2 == "aggressive." || D2 == "Aggressive." || D2 == "AGGRESSIVE.")
                {
                  Console.Title = "AGGRESSIVE!";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n " + card3 + " hesitates but eventually rushes towards MR. BONES,\n though you can still see a hint of uncertainty expressed from " + card3 + ".\n As you look at MR. BONES, trying to understand " + card3 + " fears,\n you notice that MR. BONES has not moved, not even a little, 'still stuck in that straight, slender-like position,\n standing tall with his arms held out as if holding a large box and creating sounds of wind from inside his boney body.\n Certaintly not very intimidating.");

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n Is this it?");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" You ask yourself.");
                  
                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine(" Is this all MR. BONES can do? Standing so still he could be mistaken for a statue?\n Emitting strange sounds from his gaping maw like a demons' cry for help, trying to escape its boney shell of a body,\n clawing and scraping but to no succes, forever trapped in a dark, dry and claustrophobic husk.\n Is he even alive? ...Is he a statue? And why does Makamori look so sure of himself?\n come to think of it, when has he NOT looked so sure of himself?\n Is it all just a facade? An act to hide his true feelings? His sad, deppressed-");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" Suddenly you hear a loud pop, interrupting your mindless ramblings and giving a ring in your ears.\n Startled, you quickly jerk your head and see a shattered MR. BONES with bits and peices scattered across the ground\n and " + card3 + " casting a shadow over MR. BONES's remains.\n It turns out MR. BONES CAN do more than just Roleplay as a statue, he can also die.\n You won that round?");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n '%#*$ YOU! WHY DO I EVEN HAVE THAT CARD!? IT SUCKS! WHOEVER MADE THAT CARD IS A (Cool guy)!\n AND I HOPE HE (Has a nice life)!\n I HOPE THEIR LOVED ONES GETS (Ice cream)! AND *#&@$&^ (Enjoys the ice cream)!!!!!!!!!");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" Makamori takes a breath, holds it for several seconds... Then finally exhales.");

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine(" '...I don't remember puting that card in my deck, did you have something to do with that?\n Heh... I would be looking behind my shoulder from now on if I were you. Runt...'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  PP++;

                  AD2 = false;
                } else if (D2 == "defensive" || D2 == "Defensive" || D2 == "DEFENSIVE" || D2 == "defensive." || D2 == "Defensive." || D2 == "DEFENSIVE.")
                {
                  Console.Title = "DEFENSIVE!";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n As you seal your fate and begin to speak, you see a look of relief from " + card3 + ",\n who was also expressing a hint of fear, though that expression has slightly diminished now that your choice\n meant that " + card3 + " didn't have to rush head first into what " + card3 + " thought was\n 'DANGER OH GOD DANGER OH PLEASE I DON'T WANT TO GO THERE OH GOD PLEASE DON'T MAKE ME GO THERE'.\n All " + card3 + " has to do is wait for MR. BONES to make his move and when he did,\n " + card3 + " could react appropriately and win the round. Simple and easy.\n But that opportunity never came. MR. BONES is still. Frozen. Never moved an inch.\n Looking at " + card3 + " with his dead pair of eyes and producing a, now loud and unsettling, sound.\n A sound that reminded you of strong winds hitting against a window. Is it just a waiting game, now?\n A test of patience? " + card3 + " is never going to initiate the fight now that they have the excuse of being 'DEFENSIVE'.\n But can MR. BONES even move? He hasn't even shown any signs of life yet.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Trying to read more of the situation, you look for Makamori who seemed to have disappeared,\n then, you finally realise what this is. A sick prank, that's what this is.\n MR. BONES was never alive to begin with, just a statue.\n You bet he's not even made of bones, just stone or some other dull, boring material.\n How dare he! How dare Makamori make you look like a damn fool! You come to him looking for a nice,\n fair and fun duel and Makamori just spits in your face and leaves you with this stupid, ugly, down right repulsive\n statue-");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.BackgroundColor = ConsoleColor.DarkRed;

                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");
                  Console.WriteLine("OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD ");

                  Console.ForegroundColor = ConsoleColor.Black;
                  Console.BackgroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "'Like a ticking bomb...'";

                  Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Alive and aware, you look around with recovering vision and see " + card3 + " dead on the ground, no blood,\n no wounds, no signs of harm, but definately dead. Makamori is back, standing next to his holographic dueling desk\n and brushing dirt off of his suit. Your eyes conect with Makamori's for just a second,\n then Makamori gets startled as if he forgot you were there.");

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'I was going to tell you...'");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" Makamori began.");

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine(" 'But I thought it would be funnier if I didn't, and it looks like I was right.\n HA! The look on your face is priceless!'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Looking back at the Battlefield (" + card3 + "'s resting place), you see MR. BONES,\n still frozen, still in the exact same possition as before, only this time he's looking at you. You lost that round...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  MP++;

                  AD2 = false;
                } else 
                {
                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'Speak correctly.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }
              }
              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A voice emits from the Screens...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ").'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "Smells Like Card Violence";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori draws his card and places it on his Dueling Desk, revealing a transparent, floating saucer\n with four tentacles dangling below it, a pink brain that is barely visible inside it's transparent body\n and a pair of eyes that gives the creature an 'I don't care' vibe.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" Makamori squints at his card.");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine(" 'This is... Uh... FOREHEAD%+-= yeah I'm not saying all of that. FOREHEAD is a Jellyfish like creature\n from space able to swim in the air at incredible speeds and latch it's tentacles on it's Prey,\n injecting Venom that paralyzes, allowing FOREHEAD to consume it's Victims\n brain power while it's still alive, growing larger and eventually killing it.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

              Console.ForegroundColor = ConsoleColor.White;

              string card4 = Console.ReadLine();

              Console.WriteLine("\n '" + card4 + "? HA! That would be good if this was ELEVEN YEARS AGO! Seriously, how do you just keep getting worse?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Random numberGen2 = new Random();

              int roll2 = 0;

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Looks like it's my turn...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              bool luck = false;

              roll2 = numberGen2.Next(1, 3);

             if (roll2 == 1)
             {
              Console.Title = "Makamori's Attacking!";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'ATTACK, FOREHEAD!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;
            
              Console.WriteLine("\n FOREHEAD starts Zipping around like a Fly, becoming a blur with every movement.\n Occasionally pausing for a moment, tentacles flailing as FOREHEAD stops, before starting to dart around again.\n A routine that gave fear to " + card4 + " as they witnessed the sheer speed of the creature.\n How do you deal with such velocity? It's like trying to catch a bullet, if that bullet was a hulking\n mass of paralyzing venom. FOREHEAD continues to dart around and eventually pauses again.\n But this time it was different, the pause was longer, it was silent, it had intent. Suddenly FOREHEAD flings towards\n " + card4 + " violently, causing " + card4 + " to react almost instantly by jerking back and barely dodging\n the blur that flew pass, an action that caused " + card4 + " to loose their footing.\n " + card4 + " felt the force of FOREHEAD zoom pass them once more as " + card4 + "'s fall avoided the creature.\n Clearly luck was on " + card4 + "'s side. Don't let it go to waste. "  + card4 + " recovered themselves\n and scanned the arena, eventually finding FOREHEAD, who was already trying to take " + card4 + "'s life. But " + card4 + "\n somehow avoided death Once again.\n " + card4 + " felt a sudden surge of confidence. They felt invincible, like nothing could touch them.");

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine(" Don't waste it.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n " + card4 + " scanned the arena, found FOREHEAD, got ready and survived the attack.\n This time, when " + card4 + " got ready to scam death for the third time, this time,\n " + card4 + " didn't show any fear. This time they didn't have to search, " + card4 + " knew exactly\n where the creature was and this time, " + card4 + " had an idea.");

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine(" They felt invincible.");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n " + card4 + " loosened their grip and got ready for FOREHEAD's attack,\n and after several seconds of 'INTENSE STARING', FOREHEAD finally launched at\n " + card4 + " becoming a violent blur once more. You felt time slow to a crawl as " + card4 + " smoothly glides around\n FOREHEAD and grabs one of his tentacles causing the momentum to rip it off without " + card4 +  "'s intent.\n FOREHEAD let out a screech, a noise you didn't think possible coming from a Creature like that, it was like metal\n scraping on metal, the type of sound that you would hear even when it stopped. Suddenly you notice a trail of thick,\n yellow liquid and when you follow the trail with your eyes, you discover FOREHEAD, smashed and laying\n in a puddle of that thick, yellow liquid and an equally thick, pink liquid.\n It seems when FOREHEAD smashed into that (now broken) pillar, his brain popped inside his bell causing pink liquid\n to splatter around him and grow a puddle with that yellow liquid\n pouring out of his fresh wound in need of a new tentacle.\n Now he's just a colorful display of defeat. What a miserable end to this Creature. Luck won that round...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'HA! i'M NOT EVEN MAD! THAT WAS ALL JUST LUCK! YOU DIDN'T DO ANYTHING! HOW COULD I POSSIBLY BE MAD AT LUCK!?'");

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'Why are you shouting?'");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'SHUT UP! YOUR JUST A SCREEN! YOU DON'T GET TO TALK RIGHT NOW!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              luck = true;

              PP++;
             } else if (roll2 == 2)
             {
              Console.Title = "Makamori's Defending!";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'DEFEND, FOREHEAD!'");

              Console.ForegroundColor = ConsoleColor.Black;
              
              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n FOREHEAD began to bobble left to right in a mesmerizing pattern, tentacles slightly lagging behind.\n This was a dance - a dance you thought would suduce " + card4 + ", hypnotize them and lure them into death.\n But this was a childish thought, one constructed by someone who didn't have faith in their own card,\n a silly dance wouldn't kill " + card4 + ". " + card4 + " (your card) began to slowly\n walk towards FOREHEAD after they realised that FOREHEAD wouldn't stop his exaggerated dancing,\n forcing " + card4 + " to engage the fight. And once " + card4 + " finally got close to FOREHEAD-");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n FOREHEAD RIPPED " + card4 + "'S HEAD OFF AND NOW HE'S EATING IT OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD OH GOD-");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Nothing happened, FOREHEAD is still just as harmless as before. " + card4 + " got closer and now\n they're practically touching FOREHEAD and he doesn't seem to mind it. FOREHEAD's dance continues.\n You wonder if he even has thoughts in that absurdly bright pink brain of his. After several seconds of\n " + card4 + " walking around FOREHEAD, trying to understand him, " + card4 + " finally decides to attack,\n Pulling their fists back then holding it there, knowing that this one strike should end it,\n as they released their fists you still had no faith in your card-");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n You weren't sure what happened, all you could remember is seeing a Blur but not like from a hard-to-recall dream,\n you saw an actuall Blur, or maybe it was FOREHEAD? You heard somthing rip, it was wet and squishy,\n then you saw blood splat onto the ground, " + card4 + " folowed soon after, they're body was stiff\n and they're veins turned yellow, but " + card4 + " was missing something.\n You slowly gazed up towards FOREHEAD, but the first thing you saw was a spine, then tentacles, then a head-\n you stop in shock as you feel your heart skip a beat. The head began to bobble left to right in a mesmerizing pattern,\n spine slightly lagging behind. This was a dance - A dance that suduced " + card4 + ",\n hypnotized them and lured them into death. The blur was gone, all that was left was a reminder of faith.\n ...and Makamori's laughs. You lost that round...");

              MP++;
             } else
             {
              Console.WriteLine("Secret?");
             }
             Console.ForegroundColor = ConsoleColor.Magenta;

             Console.WriteLine("\n A voice emits from the Screens...");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             if (luck == true)
             {
              Console.Title = "...";

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n '...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n '...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'Can I talk now?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'YES!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";
             }

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ").'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Smells Like Card Violence";

             Console.ForegroundColor = ConsoleColor.Magenta;

             Console.WriteLine("\n Makamori takes a card, places it down on his desk then a short, bean-shaped creature appears\n with two stubby legs and two large, white, feathered wings extended on their back. Their rubber-like\n skin is painted dark Blue and a pink liquid pours down from their single large glass eye as if always crying.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'This one's called BEAN. A smol boi with complex emotions. Their large, disfigured grin paired with their\n pink tears makes it hard to understand what BEAN is feeling. On top of that, their body slightly\n twitches every now and then, as if whatever they're feeling is too much for them and they'll burst at any second,\n freeing themselves from their overwhelming form.'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

             Console.ForegroundColor = ConsoleColor.White;

             string card5 = Console.ReadLine();

             Console.WriteLine("\n '" + card5 + "? HMPH! Finally you play a good card...'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n  '...Ish.'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             bool AD3 = true;

             while (AD3 == true)
             {
              Console.Title = "HMMMMMMmmmmmmmmmmm 3: Third Time's The Charm";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n AGGRESSIVE or DEFENSIVE?");

             Console.ForegroundColor = ConsoleColor.White;

             string D3 = Console.ReadLine();

             if (D3 == "aggressive" || D3 == "Aggressive" || D3 == "AGGRESSIVE" || D3 == "aggressive." || D3 == "Aggressive." || D3 == "AGGRESSIVE!")
             {
              Console.Title = "ATTACK!";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n With eyes glued, " + card5 + " approaches the Mystery-Leaking BEAN with timed steps, eventually getting a reaction\n from BEAN as he twitches his head towards " + card5 + "'s moving feat, flinging some pink liquid just before\n he extends his wings and lifts himself several feat off of the ground, becoming airborne and continuing to\n to stare at " + card5 + ". You were stunned at the sight of the flying BEAN, looming over " + card5 + "\n like a god, it felt holy, but that thought didn't linger too long once you glanced at BEAN again. Now it felt\n more like a Demon, something that wasn't meant for the human eye to witness, not untill the afterlife,\n not untill you knew your place in the land of judgement. " + card5 + " attempted to jump and grab onto BEAN's\n leg then pull him down, but couldn't, BEAN didn't even move, as if taunting " + card5 + ", knowing there\n was nothing they could do. " + card5 + " tried again and was faced with the same result and after\n their third attempt they actually managed to grab onto BEAN's leg.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n You noticed BEAN's pupil shrink as he started kicking the air violently, doing all he could do to\n rid himself of " + card5 + ". The twitching got worse. BEAN's wings faultered and the twitching began\n to get worse and once they finally hit the ground " + card5 + " was no longer grabbing BEAN, yet the\n twitching only got worse and worse. You thought you would hear screaming from BEAN but he is eerily silent,\n the only sounds coming from him is his body flailing and hitting the hard dirt he's on top of.\n The twitching got worse. One of His wings started to break as you hear a snap muffled by the chaotic\n tantrum that is BEAN, the second one breaking soon after and now feathers and pink liquid fill the\n area around him. The twitching got worse. You notice BEAN's movement slightly change through the\n clouds of dirt surrounding him, before it was just twitching but now it's as if a ghost was hitting him,\n bending and stretching his body with every strike, This strange movement repeated more often then you would like.\n Now it felt like a show, displaying all the absurd things BEAN could do with his body with no consequences\n at all. But shows are supposed to entertain, and after glancing at Makamori you notice that\n even he seemed to be a little bit disturbed. Glancing back down at the arena you see " + card5 + "\n about to begin slowly approach BEAN one last time, but before " + card5 + " tried anything, they\n stopped and observed the giant, feathery, pink dirt cloud shrouding BEAN.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n That's when you realised that you didn't hear BEAN's tantrum anymore. The dirt cloud finally cleared\n revealing BEAN, still, his back facing " + card5 + ". Both wings seem untouched. The Twitching got worse.\n You hear glass breaking and water dripping, then it starts to get louder, harder, faster untill finally,\n it stops. BEAN whispers with an impossible tone:");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'Know your place, Scum.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n BEAN turns revealing his glass eye now shattered and replaced by an endless black abyss with one small,\n bright white eye in the center of it, staring at " + card5 + ", his disfigured grin still present.\n BEAN walks towards " + card5 + " and " + card5 + " gives no reaction. Confused, you look closer to\n see tears fall from " + card5 + "'s face, pink tears. Now inches away from " + card5 + ", BEAN extends\n his right wing and puts it on their shoulder, it clenches onto them and you hear bone breaking\n as a disfigured grin grows on " + card5 + "'s face. They colapse onto the ground and BEAN's eye\n tracks them perfectly. " + card5 + " twitches, then stops. You lost that round...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'I... Won? HA! I WON! ...Right?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              MP++;

              AD3 = false;
             } else if (D3 == "defensive" || D3 == "Defensive" || D3 == "DEFENSIVE" || D3 == "defensive." || D3 == "Defensive." || D3 == "DEFENSIVE!")
             {
              Console.Title = "DEFEND!";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n When your lips sealed, you were surprise to see BEAN react first, turning to you with a twitch,\n staring blankly with that huge, glass eye of his. You heard a disappointed sigh come from him,\n then he turned back to face " + card5 + ", realising that " + card5 + " hadn't attempted to move any\n closer while BEAN was turned away, BEAN sighed again, this time it was louder. BEAN used his\n little legs and began to move slowly towards " + card5 + ", who started to walk away from\n BEAN at equel pace. BEAN Twitched. Eventually BEAN used his wings to move faster,\n but this only made " + card5 + " move faster, again, matching the speed of BEAN until finally, " + card5 + "\n got blocked by a pillar that stopped him from moving back any more. Now, " + card5 + " had to fight.\n Once BEAN reached " + card5 + ", he attacked without hesitation but " + card5 + " dodged, slid under BEAN\n as he was still airborne, causing BEAN to bounce off the pillar instead. He Twitched, this time the\n Twitch was violent. BEAN recovered himself and attacked again, making sure to attack lower to the ground,\n but that only allowed " + card5 + " to jump over him instead. BEAN cackled then whispered:");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'I knew it was going to be like this...'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n BEAN continued to attack, but no matter what he did, he couldn't hit " + card5 + ". BEAN twitched.\n After several minutes of failure, suddenly, BEAN stopped attacking and instead dicided to stare back up at you.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkRed;

              Console.WriteLine("\n 'HAHA!'");

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'Why?'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n He said as he continued to attack just as fast as he stopped, still having no success. You gazed at the fight,\n wondering why " + card5 + " hasn't attacked yet. Is it to show that " + card5 + " is better then BEAN?\n A choice of Dominance to get under BEAN's skin? Seeing how loud the kettle can whistle before it explodes.\n Maybe " + card5 + " knows that there will be nothing after the fight, once the round is over BEAN and\n " + card5 + " will be gone, so they stall just for the sake of time, so they can feel the wind just a little longer.\n Your train of thought gets derailed as you hear BEAN's anger echoing throughout the arena,\n and notice that he is now standing still once again, Twitching more violently then before.\n His screams of anger slowly turns into a strained hiss until finally it stops allowing silence to take its place.\n The Twitching continues as you see " + card5 + " beginning to walk away from BEAN.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkRed;

              Console.WriteLine("\n 'STOP RUNNING AWAY!'");

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'Please...'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n BEAN begged, but " + card5 + " didn't stop, and something tells you that " + card5 + " isn't walking away because of fear.\n BEAN attacked again, becoming a screaching bullet of rage who's trajectory was uncalculated. And once " + card5 + "\n avoided the attack and BEAN hit another pillar, he gave up. The Twitching continued. BEAN\n stretched his wings and flew up to your pillar. Now inches away from eachother, only seperated by the\n small rail guards attached to the edges of the pillar, you struggled to maintain eye contact with the large,\n crying eye.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'This is all your fault...'");

              Console.ForegroundColor = ConsoleColor.DarkRed;

              Console.WriteLine("\n 'INSIGNIFICANT!'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n BEAN shouted while slowly inching closer to you.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'You just wanted to see me-'");

              Console.ForegroundColor = ConsoleColor.DarkRed;

              Console.WriteLine("\n 'SUFFER!! HATE!!!'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n whimpering, he continued to move closer, close enough for you to see the unevenness of his skin.\n The Twitching continued.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkBlue;

              Console.WriteLine("\n 'That's okay, I enjoy it, too, sometimes...'");

              Console.ForegroundColor = ConsoleColor.DarkRed;

              Console.WriteLine("\n 'STOP!!!! BREATHING!!!!!'");

              Console.ForegroundColor = ConsoleColor.Magenta;
                     //Ending is abrupt who cares
              Console.WriteLine("\n BEAN extends his right wing and moves it closer to you as if an arm reaching out. You gasp, then look to Makamori\n for help, but quickly frowned once you realised that Makamori looked more frightened then you,\n though it seemed he was afraid of something else. Suddenly you hear a loud buzz as you turn to see BEAN\n getting electrocuted by what looks to be an invisible protective barrier coming from the small guard rails,\n suspending BEAN into the air, his screams muffled by the sounds of high voltage piercing his wing,\n just before falling and hitting the ground with a small bounce. BEAN lays limp on the ground, still.\n The Twitching stopped, and so did his tears. You won that round.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "(:< Demon More Like Clown >:)";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori sighs then speaks under his breath:");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine(" 'Some Demon you were.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              PP++;

              AD3 = false;
             } else
             {
              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Use your words, Idiot.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();
             }
             }

             Console.Title = "Do You Ever Feel Like It's Not Enough?";

             Console.ForegroundColor = ConsoleColor.Magenta;

             Console.WriteLine("\n A voice emits from the Screens...");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Smells Like Card Violence";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ").'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'Looks like we're half way done.'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.Magenta;
             //john j just some guy
             Console.WriteLine("\n Makamori grabs a card, then a... guy... appears.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.Title = "Hi John :)";

             Console.WriteLine("\n 'This is, uh, John. He's an inventor. The card says that his first creation was a straw. Very cool.'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "";

             Console.ForegroundColor = ConsoleColor.Cyan;

             Console.WriteLine("\n 'Where am I? Who are you people?'");

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'You're in a game. You're not real. I'm the one who's gonna control your actions.'");

             Console.ForegroundColor = ConsoleColor.Cyan;

             Console.WriteLine("\n 'What? Why does this feel so familiar?'");

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'I used you before.'");

             Console.ForegroundColor = ConsoleColor.Magenta;

             Console.WriteLine("\n John stares blankly in awe.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Smells Like Card Violence";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

             Console.ForegroundColor = ConsoleColor.White;

             string card6 = Console.ReadLine();

             Console.ForegroundColor = ConsoleColor.Cyan;

             Console.WriteLine("\n 'Dear god! What is that thing?!");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'That's " + card6 + ". Trust me, they're not dangerous.'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.Cyan;

             Console.WriteLine("\n '" + card6 + "...'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.Magenta;

             Console.WriteLine("\n John stares off once again, remembering, realising.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Random numberGen3 = new Random();

             int roll3 = 0;

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n '...'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'Hmmm...'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.Cyan;

             Console.WriteLine("\n 'What are you doing?'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'Deciding your fate...'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.Cyan;

             Console.WriteLine("\n 'Oh, right, that's how this works.'");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             roll3 = numberGen3.Next(1, 3);

             if (roll3 == 1)
             {
              Console.Title = "AGGRESSIVE JOHN!";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'JOHN! BE AGGRESSIVE!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'O-okay? What do you expect me to do?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'I don't know, maybe kill " + card6 + ". Duh.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'How?!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Just make a giant mega ray of infinite death or something, I don't know.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'A what?!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n " + card6 + " begins approaching John.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'Oh, no.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n You find watching Makamori argue with John amusing and some what relieving, finally you're not the only\n one that is subject to Makamori's ego, but something about John doesn't feel right,\n why is he so life like? Why is he so... Sentient? All of the other cards has just been animals- no, creatures,\n something you wouldn't feel bad if you had to put it down, but John isn't a creature, he's human,\n as far as you know. You fear what mental stain this game may put on you.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makori and John's voice comes swelling back to you as you realise the progress " + card6 + " has made.");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine(" 'Why are you running away? I said be aggressive! I swear if you make me lose you'll never live again!'");

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine(" 'Seriously?! Look at it! A straw won't do anything against that!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n As " + card6 + " continues to inch closer, John holds out his hand and concentrates, creating a thin\n plastic straw in his palm. You hear John's skin rub against the plastic as he grips the straw\n tightly just before throwing it at " + card6 + ", but The straw bounces off of them and hits the\n ground with a disappointing rattle. " + card6 + " pauses and stares at the straw for a moment then\n begins to run at John, every step denting the ground and shouting this deep boom.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'They'reRunningAtMeWhatDoIDo?!'");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine(" 'GIANT MEGA RAY OF INFINITE DEATH!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n John's mind cycling through all of the ways he could 'lose' this round completly removes his\n ability to run allowing " + card6 + " to reach John, finally attacking him by swiping they're arm,\n and despite John's sad attempt to dodge, the attack connects and sends him tumbling several feet away.\n You feel a pain in your heart as if it was being squeezed. John gets up with struggle,\n ignoring Makamori's insults for getting hit. He's silent. His hair covering his face,\n John holds out his hand and concentrates, then a pebble size, glowing white orb starts to form in his hand.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'Please...'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" John whispers. You see the orb grow slightly and hear a humming of a soft melodic song, but it's not enough.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'Please...'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" He repeats. The orb grows once more, now about the size of his fist and the humming now joined\n by a choir, harmonizing with slight vibrato.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'Please!'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" Tears start to fall as the orb pulsates and glows brighter, the choir expressing the same\n dread that John is feeling, the humming now weak screaming. " + card6 + " begins approaching with caution,\n the light from the orb casting a large shadow behind them.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'PLEASE! I DON'T WANT TO DIE!'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" His cry rang in your head as the orb suddenly dims until it disappears completely, the song\n gone with it. It wasn't enough. John falls to his knees, once again ingoring Makmori's insults,\n or maybe his weeping was drowning them out. " + card6 + " walked up to John and pulled back\n their fist. You expected it to be swift, but it couldn't have been further from that,\n every hit forcing out a new excuse to dig your nails into your own skin.\n You felt terrible. You felt blood. John 'lost' that round...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'That was pathetic! You think some stupid song is gonna kill something like that?! You're worthless!'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori grabs John's card and rips it until he couldn't anymore.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              PP++;
             } else if (roll3 == 2)
             {
              Console.Title = "DEFENSIVE JOHN!";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'JOHN! BE DEFENSIVE!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A sigh of relief leaves John's throat as he starts to walk away from " + card6 + ", keeping steady\n vision on them. Although John's face lit up with alleviation when Makamori said to be defensive,\n there's still a hint of fear, and it doesn't seem to be coming from the sight of " + card6 + ".\n As " + card6 + " begins to move, John holds out his hand and has his palm face them,\n constructing a brick wall right infront of " + card6 + ", but they just walk around it.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Um, what the hell was that?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'That was supposed to stop them.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'THAT was supposed to stop " + card6 + "? That embarrassing wall?- Wait, why are you even trying to\n stop them? You know defensive means you still have to kill " + card6 + ", right? You can't just run away.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n John stayed silent, raising his hand again making another wall infront of " + card6 + ", they walk around\n it, this time with louder steps. Makamori squints in confusion.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'What is your goal here? Do you want " + card6 + " to run into the wall? Stub their toe, maybe?\n You think that's gonna win me the round?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n John holds out his now shaky hand and builds the third wall but, of course, " + card6 + " walks around it,\n pushing it over, too.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Hey, John, stop that! If you keep doing that I'll lose the round! Do you really want to make me lose?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n It's hard to tell if John can even hear Makamori at this point, or maybe he's chosing to ignore the\n voice of reason, convincing himself that there's another way. John creates a fourth wall and\n " + card6 + " breaks through it, now sprinting at John, their eyes focused onto him with an exact\n idea of what they'll do when they reach him.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'Stop, please!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Oh, you're begging now?! Seriously?! What is wrong with you? You've never acted like this before.\n Just do your job and stop whining!");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n But there was no whining, no tears, John didn't seem to be concerned for himself.\n A fifth wall is made but " + card6 + " runs through it, barely disrupted by the impact.\n Makamori continues to yell at John, but it's pointless, screaming at John wont\n change his mind, he'll only make more walls. Eventually, after breaking the sixth wall,\n " + card6 + " reaches John and bashes into him, sending him tumbling several feet away.\n\n There was no attempt to dodge.\n\n Makamori is yelling louder now, spitting more insult onto John, but he ignores them.\n John gets up and steadies himself, then he yells to " + card6 + ":");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'Why did you have to do that?!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n John holds out his hand.");

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine(" 'I didn't want this...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A large metal square platform begins to form on the ground inbetween John and " + card6 + ",\n each edge segmented. A glowing white orb stands in the center, humming a soothing melodic\n song with a choir hamronizing with it. " + card6 + " begins to move towards the orb.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();
              
              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Is this it? Are you finally doing it? Finally?!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n John struggles to hold out his hand, as if fighting the delusional part of himself that thinks\n there's still another way. " + card6 + " steps up onto the plate then pauses for a moment to\n stare at the orb, they seem mesmerised by it, their pupils dilating from the sight of it.\n " + card6 + " begins to move closer, each soft step hitting the cold metal floor makes the orb\n glow brighter and sing louder. " + card6 + " places their hand on it, then their other hand,\n then their whole body, the light begins to peirce through them.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Just kill them already!'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Smoke starts to cover the light as you hear loud sizzling. " + card6 + " tried to get off\n of the orb but their melted flesh glued them onto it. Suddenly, the plate closes into\n itself creating a large metal box with no way to see inside, trapping " + card6 + ",\n the song now muffled and distorted. John walks up to the box, then stares up at it, listening\n to the song mock him from inside, it was helpless, but somehow he was not defeated.\n The singing fades as you hear mechanisms move and click, the box opens but there's\n still a bit of smoke. John steps out of the way as he waits for the smoke to clear,\n still holding onto delusion. Finally, the smoke clears revealing the orb gone, and so is\n " + card6 + ". You look closer to see a small cat in the center sitting and staring at\n John with ignorant eyes, it's fur clean and glossy. John stares back, stunned, then pure bliss.\n Tears begin to fall as John whispers:");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Cyan;

              Console.WriteLine("\n 'I did it...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n The cat meows at John then walks to him, but before he could hold it, they both fade away leaving only silence.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "?";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n John won that round...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori rips John's card as he says:");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine(" 'Thank god that snoozefest is over. What a useless card.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              MP++;
             }

             Console.Title = "Smells Like Card Violence";

             Console.ForegroundColor = ConsoleColor.Magenta;

             Console.WriteLine("\n A voice emits from the Screens...");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ").");
             
             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.Magenta;
             //VALUE :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
             Console.WriteLine("\n Makamori places his newly drawn card summoning a ");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n 'This is ");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Type in anything you want");

             Console.ForegroundColor = ConsoleColor.DarkYellow;

             string card7 = Console.ReadLine();

             Console.Title = "" + card7 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n '" + card7 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "HHHhhmmmmmmmmmmmmmmmm 4: ";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n AGGRESSIVE or DEFENSIVE");

             Console.ForegroundColor = ConsoleColor.DarkYellow;

             Console.ReadLine();

             Console.Title = "" + card6 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n " + card6 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "" + card5 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n " + card5 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "" + card4 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n " + card4 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "" + card3 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n " + card3 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "" + card2 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n " + card2 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "" + card1 + ".";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n " + card1 + ".");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Do You Feel Attached To Them?";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Do you feel attached to them?");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Do You Feel Sympathy For Them?";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Do you feel sympathy for them?");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Your Cards, Fragments Of Your Imagination Plucked From Your Brain, For What?";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Your cards, fragments of your imagination plucked from your brain, for what?");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "So You Can Watch Them Kill?";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n So you can watch them kill?");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "So You Can Watch Them Die?";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n So you can watch them die?");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Your Ideas Should Have Value, But I'm Not Sure These Do";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Your ideas Should have value, but I'm not sure these do.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "I Need To Ask You Something...";

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n I need to ask you something...");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

             Console.Title = "I Could Do Better";

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "";

             Console.ForegroundColor = ConsoleColor.DarkGray;
             //BACKROOMS :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
             Console.WriteLine("\n You awake by the buzz of a dim light, you realise you've been laying on a hard wool rug for quite some time,\n there's even a small puddle of your spit that is about to reach your eye, thankfuly you get up before\n that happens, only to fall back down due to your weak legs and the sudden change of altitude.\n Finally, you look around and notice a place completly foreign to you; a maze of cement walls all covered\n with damaged wallpaper that gives off this smell of mold, sometimes there weren't even walls,\n just pillars and arches standing in random places as if failing to mimic human architecture.\n There were hardly any lights either, besides the one above your head, but you could see a bright one\n off in the distance, a stright line could get you to that light but the space between it and you\n is covered in absolute darkness, not to mention the distance and many steps you would have to take to get there.\n You could stay where you are and wait, after all, what if it's not worth leaving the light you have\n already grown so attached to. You've been strucked by a truly remarkable decision.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             bool lightWait = true;

             while (lightWait == true)
             {
              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n Walk To The Light Or Wait?");

              Console.ForegroundColor = ConsoleColor.DarkYellow;

              string remarkableDecision = Console.ReadLine();

             if (remarkableDecision == "walk to the light" || remarkableDecision == "Walk to the light" || remarkableDecision == "WALK TO THE LIGHT" || remarkableDecision == "walk to the light." || remarkableDecision == "Walk to the light." || remarkableDecision == "WALK TO THE LIGHT!")
             {
              //WALK TO THE LIGHT
              Console.Title = "";
              
              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n After hesitating for a second, you begin venturing into the darkness knowing you'll be leaving behind\n the dim light's company and it's sad buzz. They will be missed. It didn't take long for you\n to enter the light-allergic area, not even able to see your own hands, you can only\n grasp the sound of your feet creaking the floor and the sight of the bright light far infront of you.\n Looking back you can see the dim light fade until it dies out, there's no light to go back to now,\n you have to commit to your decision. The floors become quieter and the light grows brighter.\n Soon, the floors become silent, leaving you alone with your wondering thoughts. You wonder what\n this new light will give you, you wonder if it will be worth leaving the light you had before,\n you wonder if they'll see value in-");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Suddenly, something grabs your ankle causing you to fall to the ground, breaking your neck and killing you instantly.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.Title = "What If It Isn't Worth It?";
              
              lightWait = false;
             } else if (remarkableDecision == "wait" || remarkableDecision == "Wait" || remarkableDecision == "WAIT" || remarkableDecision == "wait." || remarkableDecision == "Wait." || remarkableDecision == "WAIT!")
             {
              //WAIT
              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n You decide not to risk it and instead lay cross legged on the hard wool rug so you can spend\n quality time with your dim light friend, but you don't really know what to say so you just sit\n there and stare up at the light, then your eyes started to hurt so you stopped doing that.\n Eventually, you ask the light it's favorite color, but it doesn't respond, you assume it's\n because you mumbled so you ask it again, still no response. You understand that the light doesn't\n want to be bothered so instead you sit and stare at the bright light in the distance,\n wondering if you should've gone, wondering if it's not too late to go, wondering if they would've seen value in-");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Suddenly, the bright light fades and the other lights go out soon after, leaving only your dim light.\n Maybe things would've been different if you went to the bright light, maybe things would've been better,\n but maybe things would've been worse. You're okay with the decision you made, you're okay with\n doing nothing, as long as the thought 'it would've been worse' doesn't leave your mind.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.Title = "What If It's Worse Then The One Before?";

              lightWait = false;
             } else
             {
              Console.Title = "'WALK TO THE LIGHT' or 'WAIT'";

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n That is not an option.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();
             }
             }
             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "";

             Console.ForegroundColor = ConsoleColor.DarkGray;
             //doors :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
             Console.WriteLine("\n Infront of you are two doors, the one on the right is blue with the letter D on it, and the one on the\n left is red with the letter A on it. The walls around you mimic these colors with the wall infront\n of you split half red and half blue. You walk closer to the doors and begin to hear whispering from\n the other side of both, it's a language you don't recognize. You take a step back then spin around,\n gazing at every inch of the room, you notice a security camera in one of the corners pointed at you\n with it's red light, but besides that and the two doors, the room is empty. You turn to face the\n doors again, take a step foward, and realise the whispering has stopped. It seems the only thing\n to do now is open one of the doors, but which one?");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "Doors";

             bool doors = true;

             while (doors == true)
             {
              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n Red Or Blue?");

              Console.ForegroundColor = ConsoleColor.DarkYellow;

              string RD = Console.ReadLine();

              if (RD == "red" || RD == "Red" || RD == "RED" || RD == "red." || RD == "Red." || RD == "RED!")
              {
                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n You walk to the red door, turn it's handle, then slowly open it. Hearing the door creak and pop,\n you soon became frightened from what could be on the other side, but, eventually,\n the door was open and it was revealed to you that on the other side of that red door was a sign, a sign that said:");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n They lost.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                doors = false;
              } else if (RD == "blue" || RD == "Blue" || RD == "BLUE" || RD == "blue." || RD == "Blue." || RD == "BLUE!")
              {
                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n You walk to the blue door, turn it's handle, then slowly open it. Hearing the door creak and pop,\n you soon became frightened from what could be on the other side, but, eventually,\n the door was open and it was revealed to you that on the other side of that blue door was a sign, a sign that said:");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n They won.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                doors = false;
              } else 
              {
                Console.Title = "'RED' or 'BLUE'";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n That is not an option.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();
              }
             }

             Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

             Console.Title = "No, I Need To Think More About this";

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.Title = "";

             Console.ForegroundColor = ConsoleColor.DarkGray;
             //PAINTING :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
             Console.WriteLine("\n A palette of paint, a bucket of brushes, and an empty white void. You're itching with motivation,\n you know today will be the day you start to work on a new piece, but you're also lacking in ideas,\n you always deal with this by waiting until there's something that pops up but you've already tried that,\n it's gotten to the point where you just feel lazy, so now you're doing something you hate:\n Forcing yourself to paint. Maybe it won't be so bad this time, maybe when you begin to paint\n ideas will start flowing, it's happened before. You grab a brush, dip it in paint,\n then glide it along the canvas. You had no intent with what you were making, simply painting\n a line and seeing if that gave you an idea.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n And it did.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.DarkGray;

             Console.WriteLine("\n Your mind begins to shape and form this line into a million different things until finally, you see it,\n you know what you're going to paint, it will be magnificent, you can't wait to finish it and\n show it to them, but you're afraid that if you rush it, it may not be as good as it could be.\n But what if it takes too long? What of they lose intrest? You already know what you want to paint,\n you just have to make it, how much worse could it possibly be if you rush it? You stand in silence and think.");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             bool painting = true;

             while (painting == true)
             {
               Console.ForegroundColor = ConsoleColor.White;

               Console.WriteLine("\n Take Time Or Rush Art?");

               Console.ForegroundColor = ConsoleColor.DarkYellow;

               string art = Console.ReadLine();

               if (art == "take time" || art  == "Take time" || art == "TAKE TIME" || art == "take time." || art == "Take time." || art == "TAKE TIME!")
               {
                //TAKE TIME
                Console.Title = "";
                
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n You decide it would be better if you took your time with it, ignoring your impatience and the\n voice telling you to: 'PAINT FASTER!', feeding your thoughts with the reward of finishing this piece,\n but you know you will be happier with the finished product if you took your time with it,\n you just have to keep reminding yourself that. You continue painting, treating every line with as\n much care as possible, taking several minutes to make sure the angle is right, then about three\n hours later the overall shape was done. Although it isn't as much progress as you would've hoped for,\n given how long it took for just the shape, it still fills you with excitement and gives you all sorts\n of ideas of what the finished piece would look like, all of the eyes that would see it,\n all of the reactions it would get. Maybe they'll see value in-");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n Suddenly the voice gets louder and so does the thought of rushing the piece. The answer you're looking\n for won't be given until it's finished so why should you have to wait so long when you could get it so\n quickly? It's YOUR art. You should be able to do it how YOU want to. Now it just feels like a\n chore you can't wait to be done with.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n ...");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n Of course, you don't really feel like this, you're just overreacting, trying to make it about yourself.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n You know you will be happier with the finished product if you took your time with it, you just have to keep\n reminding yourself that. You tried to continue painting but you noticed the quality was getting worse,\n so you forced yourself to take a break for the day.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.Title = "I Know It'll Be Worth It When It's Finished, Whenever That Is.";

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                painting = false;
               } else if (art == "rush art" || art == "Rush art" || art == "RUSH ART" || art == "rush art." || art == "Rush art." || art == "RUSH ART!")
               {
                //RUSH ART
                Console.Title = "";
                
                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n Tempted by the reward, you dicided it would be easier to rush it rather than spend months on a project\n that may not be remembered, so you continued painting, treating every line with little to no care at all,\n taking no time to see if the angle of a line is right or not, and already you can notice\n the progress you've made, the quality wasn't as good as you had hoped for but you didn't care,\n the only thing that mattered was the reward. But there was something that was bothering you,\n you felt a quiet dread lingering, as if there was a part of you saying to: 'PAINT SLOWER!',\n but why would you be thinking that? You were so close to getting the reward why stop now?\n You expected this dread to fade soon but it stayed, it stayed for as long as you painted.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n Finally you were done, the painting was finished. You didn't bother seeing if there was anything\n to be improved, you didn't care. After arranging the meeting, you were finally able to show it to them.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n They didn't know what the painting was suppose to be. You didn't care, or so you hoped.\n You thought that as long as they were looking at something that you made all of that time\n making it would be worth it, but it wasn't. There was no reward. The dread continued to linger.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n And it never went away.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                painting = false;
               } else
               {
                Console.Title = "'TAKE TIME' or 'RUSH ART'";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n That is not an option.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();
               }
             }
             Console.Title = "";
             //end :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n ...");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();
             
             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n I Give Up");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n I Can't Let My Insecurities Hold Me Back");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n I'm Struggling To Finish This");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n I Need To Ask You Something...");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

             Console.ForegroundColor = ConsoleColor.Black;

             Console.ReadKey();

             bool seeingValue = true;

             while (seeingValue == true)
             {
              Console.Title = "Do You See Value In This?";

             Console.ForegroundColor = ConsoleColor.White;

             Console.WriteLine("\n Do You See Value In This?");

             Console.ForegroundColor = ConsoleColor.DarkYellow;

             string value = Console.ReadLine();

             if (value == "yes" || value == "Yes" || value == "YES" || value == "yes." || value == "Yes." || value == "YES!")
             {
              //YES
              Console.Title = "";

              Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "Smells Like Card Violence";

              Console.ForegroundColor = ConsoleColor.Magenta;
              //DUEL ME PART 2 :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.WriteLine("\n Makamori places his newly drawn card summoning a collection of sticky notes all formed together\n to make the shape of a human, with their right side being yellow and the left being blue.\n The pieces of paper that is their hands have primarily lines drawn showing fingers but their face has more\n complex shapes; eyes, a mouth, horns, but its as if those elements are being redrawn every second.\n The shape of the eyes or the shape of the mouth would change and every time it did it was like someone\n completely new was erasing and drawing over it.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'This is SHABiNGUS. A being formed of paper, obviously, that is constantly in a neutral state as to not anger\n themselves. One of them already knows what the outcome of the round will be, the other one is here to experience it.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Yellow;

              Console.WriteLine("\n Hi MY NAME\n iS SHABiNGUS.");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" As SHABiNGUS spoke more sticky notes appeared infront of them, acting as subtitles.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'We know.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n '...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n '...It's your turn.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n Type in anything you want and it will become the card you play this turn.");

              Console.ForegroundColor = ConsoleColor.White;

              string C7 = Console.ReadLine();

              Console.WriteLine("\n '" + C7 + "?! You must be joking! I've never seen anyone use that useless-'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Yellow;

              Console.WriteLine("\n Hi MY NAME\n iS SHABiNGUS.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Uh... Yeah. Whatever.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Anyways, my point is your card sucks.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              bool AD4 = true;

              while (AD4 == true)
              {
                //SHABINGUS :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
                Console.Title = "HHHhhmmmmmmm 4: Well That Was Weird";

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n AGGRESSIVE or DEFENSIVE?");

                Console.ForegroundColor = ConsoleColor.White;

                string D4 = Console.ReadLine();

                if (D4 == "aggressive" || D4 == "Aggressive" || D4 == "AGGRESSIVE" || D4 == "aggressive." || D4 == "Aggressive." || D4 == "AGGRESSIVE!")
                {
                  //AGGRESSIVE
                  Console.Title = "AGGRESS-";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Before you could finish, SHABiNGUS began gliding towards " + C7 + ", their paper body ruffling as they did,\n but something strange happened when they moved, SHABiNGUS's right side began to move first than\n their left side lagged behind as if being dragged. Not knowing what SHABiNGUS was capable of,\n " + C7 + " stepped one foot back in preparation to fight, they clenched their fists and held their\n head up waiting for SHABiNGUS to get close enough. SHABiNGUS didn't have any special stance, though,\n they were exposed, they were defensless. You thought maybe the round would be over soon,\n SHABiNGUS was getting closer, all " + C7 + " had to do was strike once and it would be over,\n after all they're made of paper, how could you lose?. But something seemed off, why would there be such a\n weak card in Makamori's deck? With how big his talk is you'd think he would get a\n better card, not one made of paper. Maybe there's something you haven't seen yet,\n you remind yourself not to make any assumptions even if it did seem obvious. SHABiNGUS stops abruptly,\n just a few feet away from " + C7 + ", then speaks with more paper:");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi LOOK\n AT THiS.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n A dozen more yellow and blue sticky notes appear infront of them acting as an empty screen waitng\n to have an animation projected on it...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n ...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n Before you continue anymore, please play 'ANIMATION_B'. This will give you important (notthatimportant) context.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n The animation shows a figure with a stick hitting another defenseless figure. You wonder what it\n could mean, what it's trying to say, maybe it's not saying anything at all, maybe it's just\n showing you what SHABiNGUS is thinking, showing you that they think this is a simple game.\n 'JUST HiT THE GUY WiTH A STiCK AND THEN WiN BY HiTTiNG THE GUY WiTH A STiCK.'\n But of course, it's never that simple.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n The papers start to fly around eachother making a sphere of blu and yellow, whistling\n and cracking until finally the sphere closes into itself with a big, loud and colorful bang.\n You shut your eyes as an instinctual reaction from the devastating noise and when you opened them\n you saw a stick made of paper laying on the ground. SHABiNGUS picks up his stick and begins\n walking slowly to " + C7 + ", each papery step bending slightly from hitting the ground,\n their arms swaying so exaggerated you're surprised they don't lose balance. " + C7 + " doesn't\n even bother going into any kind of stance, " + C7 + " knows that the only thing SHABiNGUS is capable of is Losing.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi iM\n GOiNG TO\n HiT YOU\n WiTH A\n STiCK NOW.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n As SHABiNGUS continued to walk through their subtitles they eventually reached " + C7 + ".\n All three just stared at eachother, SHABiNGUS was waiting for " + C7 + " to react with fear,\n instead " + C7 + " laughed spraying saliva on their faces. 'What were they going to do?' " + C7 + " thought.\n 'Hit me with a stick made of paper? What's that gonna do? Give me a paper cut? HAHAHAHA!\n It's so funny that I'm continuing to laugh!' " + C7 + " continued to laugh, continued to spray\n saliva on them, you noticed the saliva was damaging SHABiNGUS's paper body. Were they really\n this fragile? Was this was all SHABiNGUS had to offer? No that can't be right there\n has to be something else it can't be this easy! You just have to wait, something will show, something\n that will lose you the round you're sure of it. SHABiNGUS raised his stick above their\n head and " + C7 + " laughed even harder.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n As SHABiNGUS swung his stick onto " + C7 + "'s head, his arm broke from the impact, then\n his stick fell and hit her leg ripping it off and causing them to fall to the ground face first,\n the fall broke their neck but they were still alive looking up at " + C7 + ". They watched as " + C7 + "\n picked up the stick and held it above their head, getting ready to hit the defensless figures.\n There was a silence until finally she spoke:");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n i DONT UNDERSTAND.\n WHY DiDNT THAT WORK?");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n They lost.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n You expected to hear Makamori whine, but instead you saw an expression of annoyance on his face\n as if impatiently waiting for the next round.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  AD4 = false;
                  PP++;
                } else if (D4 == "defensive" || D4 == "Defensive" || D4 == "DEFENSIVE" || D4 == "defensive." || D4 == "Defensive." || D4 == "DEFENSIVE!")
                {
                  //DEFENSIVE
                  Console.Title = "DEFEN-";

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Before you could finish, SHABiNGUS began to walk towards " + C7 + ", or tried to, at least.\n They didn't even make it five steps before they tripped and fell to the ground with as much speed\n paper can maintain while falling. SHABiNGUS got themselves up with his arm and shook their head,\n they tried to walk again this time slower and safer. " + C7 + " didn't bother to get closer to SHABiNGUS,\n they found amusement in waiting several minutes for SHABiNGUS to reach them, so you waited in awkward\n silence until SHABiNGUS fell again, this time somehow softer than before, and again, after they\n got themselves up with her arm, they shook their head.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi STOP\n THAT PLEASE.");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" SHABiNGUS shielded his frustrations with a fake, patient tone.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n iT WASN'T MY FAULT.\n iT WAS YOURS.");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" SHABiNGUS responded with the same strategy.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi iM\n NOT THE\n ONE THAT\n MADE US\n FALL DOWN.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n YES YOU ARE.\n YOU MADE US FALL DOWN.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi i\n DiD NOT.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n YES YOU DiD.\n WHY ARE YOU LYiNG TO ME?");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi i\n AM NOT\n PLAYER YOU\n SAW HER\n TRiP RiGHT?");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  bool abuse = true;

                  while (abuse == true)
                  {
                    Console.Title = "Abuse";

                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.WriteLine("\n Who did you see trip?\n SHABiNGUS or SHABiNGUS?");

                    Console.ForegroundColor = ConsoleColor.White;

                    string abuseAnswer = Console.ReadLine();

                    if (abuseAnswer == "shabingus" || abuseAnswer == "Shabingus" || abuseAnswer == "SHABINGUS" || abuseAnswer == "SHABiNGUS" || abuseAnswer == "shabingus." || abuseAnswer == "Shabingus." || abuseAnswer == "SHABINGUS!" || abuseAnswer == "SHABiNGUS.")
                    {
                      Console.Title = "";

                      abuse = false;
                    } else 
                    {
                      Console.Title = "";

                      Console.ForegroundColor = ConsoleColor.DarkGray;

                      Console.WriteLine("\n That is not an option.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                  }
                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi SEE\n i TOLD\n YOU YOU\n WERE THE\n ONE THAT\n MADE US\n FALL TO\n THE GROUND.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n The arguing continued to get worse, somehow you feel like it's your fault, maybe if you would've\n chose differently you could've stopped them from arguing, maybe if you'd just pay attention you\n would've known whose fault it was. Maybe all of this could've been avoided, all of this guilt you feel\n would've been gone if you would've just chosen correctly. Maybe your ignorance made the situation worse,\n maybe it's hopeless now.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Suddenly a dozen more yellow and blue sticky notes appear in front of SHABiNGUS acting as a blank\n screen waiting to have an animation projected on it...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n ...");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n Before you continue anymore, please play 'ANIMATION_D'. This will give you important (notthatimportant) context.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n They've decided. After all this time their struggles can fade away.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n i DONT WANT THiS ANYMORE.\n iM NOT HAViNG FUN.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi THiS\n HAS NOT\n BEEN FUN\n FOR A\n LONG TiME.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n YOU KNOW WHAT i WANT.\n iTS FOR THE BEST.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi iTS\n SiLLY HOW\n WE CHOSE\n TO SOAK\n iN OUR\n MiSERY RATHER\n THAN TRYiNG\n TO HELP\n THE SiTUATiON.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n iTS NOT SiLLY.\n iTS JUST EASiER TO iGNORE THE SiTUATiON THAN TO ACT.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Hi YOURE\n RiGHT WE\n SHOULD HAVE\n DONE THiS\n A LONG\n TiME AGO.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Suddenly, SHABiNGUS holds out their arms as if reaching to their sides, their body's begin splitting\n into two, the process was slow and painful, you could tell they were having second thoughts,\n but it was necessary for them to be happy. Finally, they were apart standing about a foot\n away from eachother gazing at their new, fully formed body's.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Cyan;

                  Console.WriteLine("\n Can I go?");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" She hesitated to ask, having disbelief of her new future that was only thought to be a foolish dream.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Yellow;

                  Console.WriteLine("\n Yes.");

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine(" He reassured. Both of them lacking the subtitles they had before.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n She smiled at him and he smiled back, no longer will their lives be held back by this abstract concept,\n they were finally free. Both left in opposite directions.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n They won.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.Magenta;

                  Console.WriteLine("\n Makamori had no clever line to put you down, the tears choking your breath wouldn't let him.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  AD4 = false;
                  MP++;
                } else
                {
                  Console.Title = "";

                  Console.ForegroundColor = ConsoleColor.White;

                  Console.WriteLine("\n 'What? Just say it right.'");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }
              }
              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A voice emits from the Screens...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "Smells Like Card Violence";
              
              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ").'");

              Console.ForegroundColor = ConsoleColor.Black;
              
              Console.ReadKey();
              // CLASSY-FIED :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.WriteLine("n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.Title = "";

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n Hello and welcome back to CLASSY-FIED, the show where we look at the most classy of creatures.\n Today we are joined by a special guest: The Narrator!");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "CLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAP";

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Hey thanks for having me, it is such an honor to be here.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n I know.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n ...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "....................................................................................................................................................................................................................................................................................................................................................................................";

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n ...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n ...Uh-");

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine(" So, Narrator, tell us about yourself why don't you.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Well, as you all may know, I narrate the 'Duel me!' route.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n The duel me route?! Wow. Tell us more about that.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Sure! It's a route where two people duel eachother with cards and-");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n Cards?! Ha! You know that stuff's for children, right?");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Not really. You don't have to be younger to enjoy that kind of stuff.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n Maybe not physically younger, if you know what I mean.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA";

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();
              
              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n So, why are you here today, Narrator?");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n I'm here to Narrate over a fight I had encountered earliar for everyone tuning in to\n CLASSY-FIED tonight, this fight was a battle between two very Classy creatures, but I can't seem to remember their names...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;
              //prevent the player from typing OHSIE for their card
              Console.WriteLine("\n Type in anything Classy you want and it will become the card you play this turn.");

              Console.ForegroundColor = ConsoleColor.White;

              string card8 = Console.ReadLine();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Oh, right.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n !!! OSHIE VS " + card8 + " !!!");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Green;

              Console.WriteLine("\n " + card8 + " is such a dumb name.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n ikr");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "Smells Like Card Violence";

              Console.ForegroundColor = ConsoleColor.Magenta;
              // OSHIE :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.WriteLine("\n Makamori places his card revealing a small armless creature wearing a hat and a bow tie. They are sat on\n the ground bopping their head up and down as if repeating a tune in their head. Their skin begins\n to change color aswell: First green, then yellow, red, to purple, blue and finally back to green,\n repeating itself. You noticed the color's rhythm is synced up with their head movements.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Uh, yeah, forgot they could do that. Anyways, this is OSHIE, a very Classy little guy just enjoying life\n and having a good time, nothing seems to bother them... I honestly kind of hate it.'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n Makamori glares at OSHIE, then whispers:");

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine(" 'How do you do it?'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Did you...'");

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine(" He stops, noticing " + card8 + ".");

              Random numberGen4 = new Random();

              int roll4;

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n 'Oh, cool, I'll just, uhhh...'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              roll4 = numberGen4.Next(1, 3);

              roll4 = 2;

              if (roll4 == 1)
              {
                Console.Title = "AGGRESSIVE!";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'OSHIE, BE AGGRESSIVE!'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "aggressive";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...I guess.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n OSHIE continues to sit, seemingly oblivious to what is happening, they continue to stare blankly at the air,\n their skin continues to change color still syncing with the silent song they're listening to. They seem so happy.\n They don't care what is happening around them, it doesn't matter to them, it doesn't have to matter.\n Makamori hasn't stopped looking at OSHIE since he's summoned them. To him OSHIE is a puzzle,\n one that he can't solve.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'You make it look so easy.'");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(" He whispers under his breath.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n " + card8 + " begins to walk towards OSHIE, there is no caution in their steps. Still, OSHIE does not react.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'I've been so miserable and I don't know how to change that.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.BackgroundColor = ConsoleColor.Green;

                Console.WriteLine("\n Eventually, " + card8 + " reaches -Oh?");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.BackgroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\n What is happening?");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine("\n Why does my voice sound funny?");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n Sorry, it seems we're having some technical issues, we'll be right back after this quick break.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Cyan;
                
                Console.WriteLine("\n PUBLIC LIABILITY? BROKE? CHINLESS? HI, I'M GUY MCPERSON, AND I'M HERE TO HELP YOU WITH, AT MOST, ONE OF\n THOSE THINGS! INTRODUCING THE 'PILL'! THE NEW PRODUCT FROM YOURS TRULY THAT YOU SHOULD DIE FOR. ARE YOU RELIGIOUS?\n WITH THE 'PILL' YOU WON'T HAVE TO WORRY ABOUT WHAT YOUR FAMILY THINKS ABOUT YOU. FEELING THEIR UNAVOIDABLE\n GAZE? JUST ONE BITE FROM THIS GOLF BALL SIZED SNACK WILL GIVE YOU THE CONFIDANCE TO LEAVE YOUR HOUSE\n WITHOUT THE FEAR OF HEAT STROKE OR HYPOTHERMIA. DON'T BELIEVE ME? HAVE A LOOK AT WHAT VALUED CUSTOMER HAS TO SAY.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\n 'y'know, i never really liked [Guy Mcperson], he was always going off about heat strokes and hypothermia\n and the unavoidable gaze of god as if those were a common, life threatening danger that we should all\n be aware of. one time i saw him outside my home just staring at me through a window-'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n 'Do you know why [Guy Mcperson] was there?'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\n 'he was waiting for me to go outside - to talk to me, but i just got done with a long day of work and\n i was too tired for any more social interaction, so i just went to bed and thought little of it.\n the next day i realised he was still outside my house, still staring through that same window. finally,\n i went outside to talk to him, but he didn't say anything, he just gave me this weird white rock-'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n 'A white rock?'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\n 'yes. he gave me a weirdly spherical white rock than ran away before i could mutter anything.\n that was the last time i saw [Guy Mcperson].'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("\n 'Do you still have the rock?'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "i just feel safer around it.";

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("\n 'i do. it's in a drawer somewhere in my house, though, i don't know why, i just feel safer around it.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("\n IF YOU WANT THE 'PILL' FOR YOURSELF THAN ORDER NOW AT WWW.THEREISNOTMUCHTIMELEFT.COM.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n Welcome back to CLASSY-FIED!");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "CLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAPCLAP";

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n Now, unfortunately, The Narrator had some unexpected injuries, which means it's the end of our show.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "AAAAAAAWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW";

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n I know, I know, but all good things have to come to an end, eventually. I would like to take the last few minutes\n I have to say how much I love you guys. Seriously, you all mean so much to me, I love you, I love you, I love you.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'WHOOOOOOOO! I LOVE YOU, TOO!'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n SHUT UP! SHUT THE FUCK UP! I WASN'T TALKING ABOUT YOU!");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n You won that round...");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                PP++;
              } else if (roll4 == 2)
              {
                Console.Title = "DEFENSIVE!";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'OSHIE, BE DEFENSIVE!'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "defensive";

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...I guess.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n OSHIE continues to sit, seemingly oblivious to what is happening, they continue to stare blankly at the air,\n their skin continues to change color still syncing with the silent song they're listening to. They seem so happy.\n They don't care what is happening around them, it doesn't matter to them. Makamori hasn't stopped\n looking at OSHIE since he's summoned them. To him OSHIE is a puzzle, one that feels impossible to solve.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'You make it look so easy.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;
                
                Console.WriteLine("\n " + card8 + " begins to walk towards OSHIE, there is no caution in their steps. Still, OSHIE does not react.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'I've been so miserable and I just don't know how to change that.'");

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(" Makamori whispers under his breath.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Eventually, " + card8 + " reaches OSHIE, but just as you were about to win, OSHIE stops and turns to Makamori.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Green;

                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\n 'Yo, dawg, you don't think I've been miserable too?'");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(" OSHIE spoke with a surprisingly deep voice.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'Oh?!'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\n Yeah, like, I just don't show it or anything though 'cause like, I don't wanna ruin the vibe, y'know?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'Yeah, but I don't see how that's supposed to help me change what I'm feeling.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine("\n It doesn't. It actually kinda sucks, honestly. But I know these feelings don't last, they just stick\n out more than the good ones 'cause if we see something bad we try to fix it, but sometimes we can't,\n I think sometimes we just gotta wait 'till they leave, y'know?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'This feeling has been with me for so long. I don't think waiting is going to do anything for me.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Have you tried talking to someone?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'PFFT! Of course not! That would make them think I'm weak.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Blue;

                Console.WriteLine("\n But you're talking to me right now.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'Well, that's different.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Green;

                Console.WriteLine("\n How though?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'You're just a card, you aren't part of my life.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Yellow;

                Console.WriteLine("\n ...So you're afraid if you tell someone in your life how you feel they'll leave?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine("\n You do know how goofy that sounds, right?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n 'I know. It's just scary. I don't know how they will react, if they'll worry. I don't want them to worry.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.BackgroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n I don't think them worrying is a bad thing, wouldn't that be just, like, them loving you?");

                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...Yeah'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n '...You're right.'");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Makamori takes a deep breath, then releases.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n Wow. I gotta say, that was one of the worst things we've ever had on this show. That Makamori guy kinda sucks.\n He was just making up excuses so he didn't have to talk to anyone, as if he wanted people to think\n he was sad but not want help from anyone.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n I think he couldn't express himself that well. He was parroting these things that depressed people say,\n because he was, but those words weren't his, it wasn't how he actually felt. Emotions are complex,\n and for some it may feel imposible for them to put into words how they feel, so they stay silent,\n or they repeat things they hear from others.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n OR maybe they can't put into words how they feel because they are not actually sad. You know depression\n isn't real, right? It's just a word people use to get attention.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Um, depression is very real. I can't believe you would say something like that. It it very disrestpectful.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n Wow. Calm down. I didn't know we brought a PLBC on this show!");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "HAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHAHA";

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n Okay, I really don't appreciate how passive aggressive you're being right now. This is why you lost your route.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\n SAY THAT TO MY FACE AGAIN! SAY IT-");

                Console.ForegroundColor = ConsoleColor.DarkGray;

                Console.WriteLine(" I'm sorry. It seems we are having some technical difficulties. Please check back later.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n You lost that round.");

                Console.ForegroundColor = ConsoleColor.Black;

                Console.ReadKey();

                MP++;
              }

              Console.Title = "I Hate Who I Am But I Love The Idea Of What I Could Be";

              Console.ForegroundColor = ConsoleColor.Magenta;

              Console.WriteLine("\n A voice emits from the Screens...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.Title = "Smells Like Card Violence";

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n 'The Score is (" + PP + ") to (" + MP + ").'");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.DarkGray;
              //Possible JELLOEAD theme where they constantly switch their character in the middle of a route, as if frantically trying to figure out who they are/who they think they should be || fear of death || CONFUSION/AMBIVILANCE :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.WriteLine("\n This is the end of the 'DUEL ME!' route for now, but there is one more thing to see.\n Answer the question with 'borf' to see it");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              seeingValue = false;
             } else if (value == "no" || value == "No" || value == "NO" || value == "no." || value == "No." || value == "NO!")
             {
              //NO
              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n I See...");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n Maybe It Doesn't Matter What I Spend My Time In");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n As Long As I Find Value In What I'm Doing");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n Thank You");

              seeingValue = false;
              quizComplete = true;
             } else
             {
              Console.Title = "";

              Console.ForegroundColor = ConsoleColor.White;

              Console.WriteLine("\n Yes Or No");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();
             }
             }
            } else if (bong == "borf")
            {//one by one. IF BORF IS EQUEL TO OR LESS THAN HALF HEALTH, THEY GAIN A SECOND ATTACK THAT THEY USE EVERY TEN TURNS[THERE SHOULD BE AN INDICATOR NEXT TO BORF'S HP SHOWING HOW MANY TURNS ARE LEFT UNTIL THEIR SPECIAL ATTACK], THE ATTACK DOES 1 to 20 +40 DAMAGE IF THE PLAYER IS NOT BLOCKING AND -1 TO 10 +40 DAMAGE IF THE PLAYER IS BLOCKING. ALTERNATIVELY, HAVE BORF'S SPECIAL ATTACK TAKE LONGER TO COME OUT, BUT DOES 500(?) DAMAGE, MOST LIKELY KILLING THE PLAYER, THE GOAL WOULD BE TO KILL BORF BEFORE THE SPECIAL ATTACK COMES OUT, THIS SHOULD HELP WITH HOW LONG THE FIGHT TAKES; IF IT TAKES TOO LONG THAN YOU WILL NOT BE ABLE TO WIN -THE FIGHT HAS TO BE SHORT. :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              Console.Title = "";
              //BORF'S HEALTH
              int BH = 1000;
              //PLAYER'S HEALTH
              int PH = 150;
              //GOBLIN'S HEALTH
              int GH = 0;
              //MANA
              int mana = 0;
              //DETERMINES IF THE FIGHT SHOULD CONTINUE OR NOT (IF THE PLAYER/BORF IS DEAD)
              bool borfFight = true;
              //BOOL FOR THE WHILE LOOP THAT ALLOWS THE PLAYER'S TURN TO FUNCTION
              bool battle = true;
              //IF THE PLAYER DOES NOT TAKE DAMAGE, THEY WILL GAIN A BUFF TO ATTACK/HEALING. THIS SHOULD BE ABLE TO STACK "INFINITLEY"
              bool noHit = false;
              //BOOL THAT PREVENTS THE PLAYER FROM GETTING A RANDOM EVENT ON THE FIRST ROUND
              bool preventEvent = true;
              //GIVES BOTH THE PLAYER AND BORF AN ATTACK BUFF
              bool rain = false;
              //CHANCE TO DODGE ANY ATTACK EVEN IF THE PLAYER IS NOT DEFENDING, GRANTING THE NO-HIT BUFF
              bool dodge = false;
              //GIVES THE PLAYER A PERMANENT ATTACK BUFF
              bool heavenBuff = false;
              //IF GOBLIN = TRUE THAN GOBLIN IS ALIVE
              bool goblin = false;
              //IF GOBLIN ARRIVE = TRUE THAN THE PLAYER CAN CHOOSE WHO THEY ATTACK
              bool goblinArrive = false;
              //ATTACK CURSE
              bool attackCurse = false;
              //HEAL CURSE
              bool healCurse = false;
              //DEFEND CURSE
              bool defendCurse = false;

              //PLAYER'S POISON
              int poisonP = 0;
              //BORF'S POISON
              int poisonB = 0;
              //HOW MANY ROUNDS THE PLAYER WILL BE CURSED
              int curseCounter = 0;
              //70 ROUNDS. DON'T LET THE PLAYER KNOW HOW MANY ROUNDS IS LEFT, BUT YOU CAN ADD LINES OF DIALOUGE THAT LET THE PLAYER KNOW IF THEY'RE HALF WAY THROUGH OR MORE. :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
              int roundCounter = 0;

              Console.ForegroundColor = ConsoleColor.DarkGray;

              Console.WriteLine("\n A large gray sun burns above. You can feel it getting hotter with every second.");

              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();

              while (borfFight == true)
              { 
                Random eventGen = new Random();
                int eventRoll = eventGen.Next(1, 101);

                bool storm = false;
                bool rat = false;
                bool light = false;
                bool GC = false;
                bool curse = false;
                bool defend = false;

                battle = true;
                //STORM
                if (eventRoll >= 1 && eventRoll <= 2 && preventEvent == false)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkMagenta;

                  Console.WriteLine("\n A Storm appraoches...");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  storm = true;
                }
                //RAT
                else if (eventRoll >= 3 && eventRoll <= 4 && preventEvent == false)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkGreen;

                  Console.WriteLine("\n You hear squeaking...");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  rat = true;
                }
                //HEAVEN
                else if (eventRoll >= 5 && eventRoll <= 6 && preventEvent == false)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  if (PH > 150)
                  {
                    Console.ForegroundColor = ConsoleColor.Black;
                  }
                  else
                  {
                    Console.ForegroundColor = ConsoleColor.White;
                  }

                  Console.WriteLine("\n Rays of light shine from the Heavens...");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  light = true;
                }
                //GOBLIN
                else if (eventRoll >= 7 && eventRoll <= 8 && preventEvent == false && goblinArrive == false)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Green;

                  Console.WriteLine("\n A Goblin is approaching from the east!");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  goblin = true;
                  GH = 50;
                }
                //CURSE
                else if (eventRoll >= 9 && eventRoll <= 10 && preventEvent == false && curseCounter < 1)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkRed;

                  Console.WriteLine("\n You feel WEAK.");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  curse = true;
                }
                
                while (battle == true)
                { 
                  //CHANGES THE TITLE IF THE PLAYER HAS HEALED PAST MAX HP
                  if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                  {                  
                    Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                  {
                     Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                  }
                  else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                  }
                  else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }
                  else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP > 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }

                  //CHANGES STARTING TEXT DEPENDING ON WHAT BUFFS THE PLAYER HAS
                  if (noHit == false && PH <= 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("\n What do you choose?");
                  } else if (noHit == true && PH <= 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Blue;
                    
                    Console.WriteLine("\n Your turn...");
                  } else if (noHit == false && PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("\n It's time...");
                  } else if (noHit == true && PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("\n Oh god...");
                  }

                  if (attackCurse == false && healCurse == false && defendCurse == false)
                  {                 
                    Console.WriteLine("\n -- [ATTACK] -- [HEAL] -- [DEFEND] --");
                  }
                  else if (attackCurse == true)
                  {
                    Console.WriteLine("\n -- [HEAL] -- [DEFEND] --");
                  }
                  else if (healCurse == true)
                  {
                    Console.WriteLine("\n -- [ATTACK] -- [DEFEND] --");
                  }
                  else if (defendCurse == true)
                  {
                    Console.WriteLine("\n -- [ATTACK] -- [HEAL] --");
                  }
                  //CHANGES PLAYERS TEXT COLOR DEPENDING ON WHAT BUFFS THEY HAVE (THE PLAYER'S FOREGROUND COLOR SHOULD BE DIFFERENT THAN THE NARATOR'S)
                  if (PH <= 150)
                  {
                    Console.ForegroundColor = ConsoleColor.White;
                  } else if (PH > 150)
                  {
                    Console.ForegroundColor = ConsoleColor.Black;
                  }

                  string BD1 = Console.ReadLine();
                  //ATTACK
                  if (BD1 == "attack" && attackCurse == false || BD1 == "Attack" && attackCurse == false || BD1 == "ATTACK" && attackCurse == false || BD1 == "attack." && attackCurse == false || BD1 == "Attack." && attackCurse == false || BD1 == "ATTACK!" && attackCurse == false)
                  {
                    if (goblinArrive == true)
                    {
                      bool AD1 = true;

                      while (AD1 == true)
                      {
                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        if (noHit == true)
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (noHit == false)
                        {
                          Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        
                        Console.WriteLine("\n Who do you wish to attack?");

                        Console.WriteLine("\n -- [BORF] -- [GOBLIN] --");

                        if (PH > 150)
                        {
                          Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else if (PH <= 150)
                        {
                          Console.ForegroundColor = ConsoleColor.White;
                        }

                        string BD2 = Console.ReadLine();
                        //HERE helq mr :)))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
                        if (BD2 == "goblin" || BD2 == "Goblin" || BD2 == "GOBLIN" || BD2 == "goblin." || BD2 == "Goblin." || BD2 == "GOBLIN!")
                        {
                          Random playerAttackGenG = new Random();
                          int playerAttackRollG = 0;

                          if (noHit == true && PH <= 150)
                          {
                            playerAttackRollG = playerAttackGenG.Next(1, 21);

                            playerAttackRollG = playerAttackRollG + 20;

                            if (rain == true)
                            {
                              playerAttackRollG = playerAttackRollG + 10;
                            }

                            if (heavenBuff == true)
                            {
                              playerAttackRollG = playerAttackRollG + 20;
                            }
                          }
                          else if (noHit == false && PH <= 150)
                          {
                            playerAttackRollG = playerAttackGenG.Next(1, 21);

                            if (rain == true)
                            {
                              playerAttackRollG = playerAttackRollG + 10;
                            }

                            if (heavenBuff == true)
                            {
                              playerAttackRollG = playerAttackRollG + 20;
                            }
                          }
                          else if (noHit == true && PH > 150)
                          {
                            playerAttackRollG = playerAttackGenG.Next(1, 21);

                            playerAttackRollG = playerAttackRollG + 60;

                            if (rain == true)
                            {
                              playerAttackRollG = playerAttackRollG + 10;
                            }

                            if (heavenBuff == true)
                            {
                              playerAttackRollG = playerAttackRollG + 20;
                            }
                          }
                          else if (noHit == false && PH > 150)
                          {
                            playerAttackRollG = playerAttackGenG.Next(1, 21);

                            playerAttackRollG = playerAttackRollG + 40;

                            if (rain == true)
                            {
                              playerAttackRollG = playerAttackRollG + 10;
                            }

                            if (heavenBuff == true)
                            {
                              playerAttackRollG = playerAttackRollG + 20;
                            }
                          }
                          //PLAYER GOBLIN CRIT
                          if (playerAttackRollG == 20 && noHit == false && PH <= 150 && rain == false && heavenBuff == false || playerAttackRollG == 40 && noHit == true && PH <= 150 && rain == false && heavenBuff == false || playerAttackRollG == 60 && noHit == false && PH > 150 && rain == false && heavenBuff == false || playerAttackRollG == 80 && noHit == true && PH > 150 && rain == false && heavenBuff == false || playerAttackRollG == 30 && noHit == false && PH <= 150 && rain == true && heavenBuff == false || playerAttackRollG == 50 && noHit == true && PH <= 150 && rain == true && heavenBuff == false || playerAttackRollG == 70 && noHit == false && PH > 150 && rain == true && heavenBuff == false || playerAttackRollG == 90 && noHit == true && PH > 150 && rain == true && heavenBuff == false || playerAttackRollG == 40 && noHit == false && PH <= 150 && rain == false && heavenBuff == true || playerAttackRollG == 60 && noHit == true && PH <= 150 && rain == false && heavenBuff == true || playerAttackRollG == 80 && noHit == false && PH > 150 && rain == false && heavenBuff == true || playerAttackRollG == 100 && noHit == true && PH > 150 && rain == false && heavenBuff == true || playerAttackRollG == 50 && noHit == false && PH <= 150 && rain == true && heavenBuff == true || playerAttackRollG == 70 && noHit == true && PH <= 150 && rain == true && heavenBuff == true || playerAttackRollG == 90 && noHit == false && PH > 150 && rain == true && heavenBuff == true || playerAttackRollG == 110 && noHit == true && PH > 150 && rain == true && heavenBuff == true)
                          {
                            Random playerCritGenG = new Random();
                            int playerCritRollG = 0;

                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                            Console.WriteLine("\n CRITICAL (GOBLIN) HIT!");

                            playerCritRollG = playerCritGenG.Next(1, 21);

                            int playerCritDamageG = playerCritRollG + playerAttackRollG;

                            if (rain == true)
                            {
                              playerCritDamageG = playerCritDamageG + 20;
                            }

                            if (heavenBuff == true)
                            {
                              playerCritDamageG = playerCritDamageG + 50;
                            }

                            if (noHit == true)
                            {
                             Console.ForegroundColor = ConsoleColor.Blue;

                             Console.WriteLine("\n You roll and deal " + playerCritDamageG + " critical (Goblin) damage!");

                             noHit = false;
                            }
                            //THE YELLOW COLOR WITH THE WHITE BACKGROUND IS HARD (IMPOSSIBLE) TO READ, SO KEEP DARKYELLOW FOR THE FOREGROUND COLOR IF THE PLAYER HAS THE HEALTHY BOY ATTACK BONUStm
                            else if (PH > 150 && noHit == false)
                            {
                              Console.ForegroundColor = ConsoleColor.DarkYellow;

                              Console.WriteLine("\n You roll and deal " + playerCritDamageG + " critical (Goblin) damage!");
                            }
                            else if (PH <= 150 && noHit == false)
                            {
                              Console.ForegroundColor = ConsoleColor.Yellow;

                              Console.WriteLine("\n You roll and deal " + playerCritDamageG + " critical (Goblin) damage!");
                            }

                            GH = GH - playerCritDamageG;
                          }
                          //NORMAL PLAYER ATTACK GOBLIN
                          else if (playerAttackRollG != 20 && noHit == false && PH <= 150 && rain == false && heavenBuff == false || playerAttackRollG != 40 && noHit == true && PH <= 150 && rain == false && heavenBuff == false || playerAttackRollG != 60 && noHit == false && PH > 150 && rain == false && heavenBuff == false || playerAttackRollG != 80 && noHit == true && PH > 150 && rain == false && heavenBuff == false || playerAttackRollG != 30 && noHit == false && PH <= 150 && rain == true && heavenBuff == false || playerAttackRollG != 50 && noHit == true && PH <= 150 && rain == true && heavenBuff == false || playerAttackRollG != 70 && noHit == false && PH > 150 && rain == true && heavenBuff == false || playerAttackRollG != 90 && noHit == true && PH > 150 && rain == true && heavenBuff == false || playerAttackRollG != 40 && noHit == false && PH <= 150 && rain == false && heavenBuff == true || playerAttackRollG != 60 && noHit == true && PH <= 150 && rain == false && heavenBuff == true || playerAttackRollG != 80 && noHit == false && PH > 150 && rain == false && heavenBuff == true || playerAttackRollG != 100 && noHit == true && PH > 150 && rain == false && heavenBuff == true || playerAttackRollG != 50 && noHit == false && PH <= 150 && rain == true && heavenBuff == true || playerAttackRollG != 70 && noHit == true && PH <= 150 && rain == true && heavenBuff == true || playerAttackRollG != 90 && noHit == false && PH > 150 && rain == true && heavenBuff == true || playerAttackRollG != 110 && noHit == true && PH > 150 && rain == true && heavenBuff == true)
                          {
                            if (noHit == true)
                            {
                              Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else
                            {
                              Console.ForegroundColor = ConsoleColor.Magenta;
                            }

                            Console.WriteLine("\n You roll and deal " + playerAttackRollG + " (Goblin) damage.");

                            GH = GH - playerAttackRollG;
                          }

                          if (GH < 1)
                          {
                            if (PH > 150)
                            {
                              Console.BackgroundColor = ConsoleColor.Black;
                            }

                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.ReadKey();

                            if (PH > 150)
                            {
                              Console.BackgroundColor = ConsoleColor.White;
                            }

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("\n The Goblin is dead because of you.");

                            goblinArrive = false;
                          }

                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.Black;
                          }

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();

                          noHit = false;
                          battle = false;
                          AD1 = false;
                        }
                        else if (BD2 == "borf" || BD2 == "Borf" || BD2 == "BORF" || BD2 == "borf." || BD2 == "Borf." || BD2 == "BORF!")
                        {
                          AD1 = false;
                        }
                        else
                        {
                          Console.BackgroundColor = ConsoleColor.Black;

                          Console.ForegroundColor = ConsoleColor.DarkGray;

                          Console.WriteLine("\n That is not an option.");

                          Console.BackgroundColor = ConsoleColor.Black;

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();
                        }
                      }
                    }

                    if (battle == true)
                    {
                      Random attackGenP = new Random();
                      int attackRollP = 0;
                      //DETERMINES HOW MUCH DAMAGE THE PLAYER SHOULD DEAL DEPENDING ON WHAT BUFFS THEY HAVE
                      if (noHit == true && PH <= 150)
                      {
                        attackRollP = attackGenP.Next(1, 21);
                      
                        attackRollP = attackRollP + 20;

                        if (rain == true)
                        {
                          attackRollP = attackRollP + 10;
                        }

                        if (heavenBuff == true)
                        {
                          attackRollP = attackRollP + 20;
                        }
                      } else if (noHit == false && PH <= 150)
                      {
                        attackRollP = attackGenP.Next(1, 21);

                        if (rain == true)
                        {
                          attackRollP = attackRollP + 10;
                        }

                        if (heavenBuff == true)
                        {
                          attackRollP = attackRollP + 20;
                        }
                      } else if (noHit == true && PH > 150)
                      {
                        attackRollP = attackGenP.Next(1, 21);

                        attackRollP = attackRollP + 60;

                        if (rain == true)
                        {
                          attackRollP = attackRollP + 10;
                        }

                        if (heavenBuff == true)
                        {
                          attackRollP = attackRollP + 20;
                        }
                      } else if (noHit == false && PH > 150)
                      {
                        attackRollP = attackGenP.Next(1, 21);

                        attackRollP = attackRollP + 40;

                        if (rain == true)
                        {
                          attackRollP = attackRollP + 10;
                        }

                        if (heavenBuff == true)
                        {
                          attackRollP = attackRollP + 20;
                        }
                      }
                      //CRIT IF STATEMENT                                                                                                                                                                                                                                                                                                                                                            //rain == true && heavenBuff == false                                                                                                                                                                                                                                                                                                                                   //rain == false && heavenBuff == true                                                                                                                                                                                                                                                                                                                                    //rain == true && heavenBuff == true
                      if (attackRollP == 20 && noHit == false && PH <= 150 && rain == false && heavenBuff == false || attackRollP == 40 && noHit == true && PH <= 150 && rain == false && heavenBuff == false || attackRollP == 60 && noHit == false && PH > 150 && rain == false && heavenBuff == false || attackRollP == 80 && noHit == true && PH > 150 && rain == false && heavenBuff == false || attackRollP == 30 && noHit == false && PH <= 150 && rain == true && heavenBuff == false || attackRollP == 50 && noHit == true && PH <= 150 && rain == true && heavenBuff == false || attackRollP == 70 && noHit == false && PH > 150 && rain == true && heavenBuff == false || attackRollP == 90 && noHit == true && PH > 150 && rain == true && heavenBuff == false || attackRollP == 40 && noHit == false && PH <= 150 && rain == false && heavenBuff == true || attackRollP == 60 && noHit == true && PH <= 150 && rain == false && heavenBuff == true || attackRollP == 80 && noHit == false && PH > 150 && rain == false && heavenBuff == true || attackRollP == 100 && noHit == true && PH > 150 && rain == false && heavenBuff == true || attackRollP == 50 && noHit == false && PH <= 150 && rain == true && heavenBuff == true || attackRollP == 70 && noHit == true && PH <= 150 && rain == true && heavenBuff == true || attackRollP == 90 && noHit == false && PH > 150 && rain == true && heavenBuff == true || attackRollP == 110 && noHit == true && PH > 150 && rain == true && heavenBuff == true)
                      {
                        Random critGenP = new Random();
                        int critRollP = 0;

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("\n CRITITCAL HIT!");

                        critRollP = critGenP.Next(1,21);

                        int critDamageP = critRollP + attackRollP;

                        //RAIN BONUS CRIT DAMAGE
                        if (rain == true)
                        {
                          critDamageP = critDamageP + 20;
                        }

                        //HEAVENBUFF BONUS CRIT DAMAGE
                        if (heavenBuff == true)
                        {
                          critDamageP = critDamageP + 50;
                        }
                      
                        //CHANGES COLOR DEPENDING ON PLAYER'S BUFFS
                        if (noHit == true)
                        {
                        Console.ForegroundColor = ConsoleColor.Blue;

                          Console.WriteLine("\n You roll and deal " + critDamageP + " critical damage!");

                          noHit = false;
                        }
                        //THE YELLOW COLOR WITH THE WHITE BACKGROUND IS HARD (IMPOSSIBLE) TO READ, SO KEEP DARKYELLOW FOR THE FOREGROUND COLOR IF THE PLAYER HAS THE HEALTHY BOY ATTACK BONUStm
                        else if (PH > 150 && noHit == false)
                        {
                          Console.ForegroundColor = ConsoleColor.DarkYellow;

                          Console.WriteLine("\n You roll and deal " + critDamageP + " critical damage!");
                        }
                        else if (PH <= 150 && noHit == false)
                        {
                          Console.ForegroundColor = ConsoleColor.Yellow;

                          Console.WriteLine("\n You roll and deal " + critDamageP + " critical damage!");
                        }

                        BH = BH - critDamageP;

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }

                        if (poisonP > 0)
                        {
                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }                      
                      
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();

                          poisonB = poisonB + 5;

                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }
                          else
                          {
                            Console.BackgroundColor = ConsoleColor.Black;
                          }

                          Console.ForegroundColor = ConsoleColor.DarkGreen;

                          Console.WriteLine("\n You infect borf.");
                        }
                      }
                      //NON-CRIT ATTACK                                                                                                                                                                                                                                                                                                                                                                   //rain == true && heavenBuff == false                                                                                                                                                                                                                                                                                                                                   //rain == false && heavenBuff == true                                                                                                                                                                                                                                                                                                                                    //rain == true && heavenBuff == true
                      else if (attackRollP != 20 && noHit == false && PH <= 150 && rain == false && heavenBuff == false || attackRollP != 40 && noHit == true && PH <= 150 && rain == false && heavenBuff == false || attackRollP != 60 && noHit == false && PH > 150 && rain == false && heavenBuff == false || attackRollP != 80 && noHit == true && PH > 150 && rain == false && heavenBuff == false || attackRollP != 30 && noHit == false && PH <= 150 && rain == true && heavenBuff == false || attackRollP != 50 && noHit == true && PH <= 150 && rain == true && heavenBuff == false || attackRollP != 70 && noHit == false && PH > 150 && rain == true && heavenBuff == false || attackRollP != 90 && noHit == true && PH > 150 && rain == true && heavenBuff == false || attackRollP != 40 && noHit == false && PH <= 150 && rain == false && heavenBuff == true || attackRollP != 60 && noHit == true && PH <= 150 && rain == false && heavenBuff == true || attackRollP != 80 && noHit == false && PH > 150 && rain == false && heavenBuff == true || attackRollP != 100 && noHit == true && PH > 150 && rain == false && heavenBuff == true || attackRollP != 50 && noHit == false && PH <= 150 && rain == true && heavenBuff == true || attackRollP != 70 && noHit == true && PH <= 150 && rain == true && heavenBuff == true || attackRollP != 90 && noHit == false && PH > 150 && rain == true && heavenBuff == true || attackRollP != 110 && noHit == true && PH > 150 && rain == true && heavenBuff == true)
                      { 
                        if(noHit == false)
                        {
                          Console.ForegroundColor = ConsoleColor.Magenta;

                          Console.WriteLine("\n You roll and deal " + attackRollP + " damage.");
                        } else if (noHit == true)
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;

                          Console.WriteLine("\n You roll and deal " + attackRollP + " damage.");

                          noHit = false;
                        }

                        BH = BH - attackRollP;

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }

                        if (poisonP > 0)
                        {
                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }                      
                        
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();

                          poisonB = poisonB + 5;

                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }
                          else
                          {
                            Console.BackgroundColor = ConsoleColor.Black;
                          }

                          Console.ForegroundColor = ConsoleColor.DarkGreen;

                          Console.WriteLine("\n You infect borf.");
                        }
                      }

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      Console.BackgroundColor = ConsoleColor.Black;

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      battle = false;
                      noHit = false;
                    }
                  }
                  //HEAL 
                  else if (BD1 == "heal" && healCurse == false || BD1 == "Heal" && healCurse == false || BD1 == "HEAL" && healCurse == false || BD1 == "heal." && healCurse == false || BD1 == "Heal." && healCurse == false || BD1 == "HEAL!" && healCurse == false)
                  { 
                    //IF STATEMENT THAT CHECKS IF YOU HAVE ENOUGH MANA TO HEAL
                    if (mana >= 5)
                    {                 
                      Random healGenP = new Random();
                      int healRollP = 0;

                      healRollP = healGenP.Next(1,21);
                      //DETERMINES IF YOUR HEAL SHOULD BE BUFFED OR NOT
                      if (noHit == false)
                      {                  
                        healRollP = healRollP + 30;
                      } else if (noHit == true)
                      {
                        healRollP = healRollP + 60;
                      }
                      //CRIT HEAL
                      if (healRollP == 50 && noHit == false || healRollP == 80 && noHit == true)
                      {
                        Random medGenP = new Random();
                        int medRollP = 0;

                        medRollP = medGenP.Next(1,21);

                        //DETERMINES IF YOUR CRIT HEAL SHOULD BE BUFFED OR NOT
                        if (noHit == true)
                        {
                          medRollP = medRollP + 20;
                        }

                        int critHealP = healRollP + medRollP;
                        
                        PH = PH + critHealP;
                        //CHANGES COLOR IF PLAYER'S HEALTH IS MORE THAN MAX
                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine("\n CRITICAL HEAL!");

                        if (noHit == false)
                        {
                          Console.ForegroundColor = ConsoleColor.Green;

                          Console.WriteLine("\n You roll and heal " + critHealP + " HP!");
                        } else if (noHit == true)
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;

                          Console.WriteLine("\n You roll and heal " + critHealP + " HP!");

                          noHit = false;
                        }
                      } 
                      //NORMAL HEAL
                      else if (healRollP != 50 && noHit == false || healRollP != 80 && noHit == true)
                      {
                        PH = PH + healRollP;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        } else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        if (noHit == false)
                        {
                          Console.ForegroundColor = ConsoleColor.Magenta;

                          Console.WriteLine("\n You roll and heal " + healRollP + " health.");
                        } else if (noHit == true)
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;

                          Console.WriteLine("\n You roll and heal " + healRollP + " health.");

                          noHit = false;
                        }
                      }

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      if (poisonP > 0)
                      {
                        poisonP = 0;

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }

                        Console.BackgroundColor = ConsoleColor.Black;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        if(PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n You rid yourself of poison.");
                      }

                      Console.BackgroundColor = ConsoleColor.Black;

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
 
                      mana = mana - 5;
                    } else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;

                      Console.ForegroundColor = ConsoleColor.DarkGray;

                      Console.WriteLine("\n You need at least 5 Mana to heal.");

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                  }
                  //DEFEND
                  else if (BD1 == "defend" && defendCurse == false || BD1 == "Defend" && defendCurse == false || BD1 == "DEFEND" && defendCurse == false || BD1 == "defend." && defendCurse == false || BD1 == "Defend." && defendCurse == false || BD1 == "DEFEND!" && defendCurse == false)
                  {
                    defend = true;
                    //CHANGES COLOR DEPENDING ON WHAT BUFFS THE PLAYER HAS
                    if (noHit == false)
                    {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                    } else if (noHit == true)
                    {
                      Console.ForegroundColor = ConsoleColor.Blue;
                    }

                    Console.WriteLine("\n You choose to defend.");

                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    battle = false;
                  } else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.WriteLine("\n That is not an option.");

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();
                  }
                }
                //BORF'S TURN :))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))

                //IF STATEMENT THAT CHECK IF THE PLAYER OR BORF IS ALIVE
                if (PH >= 1 && BH >= 1)
                { 
                  GC = false;

                  if (goblinArrive == true)
                  {
                    Random borfPickGen = new Random();
                    int borfPickRoll = 0;

                    borfPickRoll = borfPickGen.Next(1, 4);
                    //BORF ATTACK GOBLIN
                    if (borfPickRoll == 1)
                    {
                      Random borfAttackGenG = new Random();
                      int borfAttackRollG = 0;

                      borfAttackRollG = borfAttackGenG.Next(1, 21);

                      borfAttackRollG = borfAttackRollG + 10;

                      if (rain == true)
                      {
                        borfAttackRollG = borfAttackRollG + 10;
                      }
                      //NORMAL BORF ATTACK GOBLIN
                      if (borfAttackRollG != 30 && rain == false || borfAttackRollG != 40 && rain == true)
                      {
                        GH = GH - borfAttackRollG;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.WriteLine("\n BORF chooses to attack the Goblin, casting BOUNCE and dealing " + borfAttackRollG + " (goblin) damage.");
                      }
                      //BORF CRIT ATTACK GOBLIN
                      else if (borfAttackRollG == 30 && rain == false || borfAttackRollG == 40 && rain == true)
                      {
                        Random borfCritGenG = new Random();
                        int borfCritRollG = 0;

                        borfCritRollG = borfCritGenG.Next(1, 21);

                        borfCritRollG = borfCritRollG + 10;

                        int borfCritDamageG = borfAttackRollG + borfCritRollG;

                        if (rain == true)
                        {
                          borfCritDamageG = borfCritDamageG + 10;
                        }

                        GH = GH - borfCritDamageG;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else 
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("\n CRITICAL HIT!");

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\n BORF chooses to attack the Goblin, casting SPINNING BACK KICK and dealing " + borfCritDamageG + " (goblin) damage!");
                      }

                      if (GH < 1)
                      {
                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n BORF killed the Goblin.");

                        goblinArrive = false;
                      }

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      GC = true;
                    }
                  }

                  //ALLOWS THE GOBLIN TO WORK.......................
                  if (GC == false)
                  {                 
                    //BORF'S ATTACK ROLL
                    Random numberGenB = new Random();
                    int attackRollB = 0;
 
                    //PLAYER DODGE ROLL BORF
                    Random dodgeGen1 = new Random();
                    int dodgeRoll1 = 0;
            
                    dodgeRoll1 = dodgeGen1.Next(1, 21);

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("\n " + dodgeRoll1 + "");

                    if (dodgeRoll1 != 20 && dodge == false || dodgeRoll1 < 17 && dodge == true)
                    {   
                      //DETERMINS HOW MUCH DAMAGE BORF SHOULD DEAL DEPENDING ON IF THE PLAYER DEFENDED OR NOT
                      if (defend == true)
                      {                   
                        attackRollB = numberGenB.Next(0, 12);
                        //ALLOWS BORF TO DEAL -1 DAMAGE, MAKING THE PLAYER PARRY AND MAKING IT EASIER TO GET THE NO-HIT BUFF
                        attackRollB = attackRollB - 1;
                      } else
                      {
                        attackRollB = numberGenB.Next(1, 21);

                        attackRollB = attackRollB + 10;

                        if (rain == true)
                        {
                          attackRollB = attackRollB + 10;
                        }
                      }

                      //BLOCKED
                      if (attackRollB == 0 && defend == true)
                      {
                        noHit = true;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        } else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        Console.WriteLine("\n BLOCKED!");

                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.WriteLine("\n BORF casts BOUNCE and deals 0 damage!"); 

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                      } 
                      //NORMAL ATTACK                                                                                                                                 //rain == true(NO NEED TO SPECIFY IF RAIN IS TRUE OR FALSE IF THE PLAYER IS DEFENDING)
                      else if (attackRollB >= 1 && attackRollB != 10 && defend == true || attackRollB >= 1 && attackRollB != 30 && defend == false && rain == false || attackRollB >= 1 && attackRollB != 40 && defend == false && rain == true)
                      { 
                        if (noHit == false)
                        {                              
                          Console.ForegroundColor = ConsoleColor.Magenta;
                        } else if (noHit == true)
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;
                        }

                        PH = PH - attackRollB;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        } else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.WriteLine("\n BORF casts BOUNCE and deals " + attackRollB + " damage.");

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                      }
                      //CRIT ATTACK                                                                                           //rain == true(NO NEED TO SPECIFY IF RAIN IS TRUE OR FALSE IF THE PLAYER IS DEFENDING)
                      else if (attackRollB == 10 && defend == true || attackRollB == 30 && defend == false && rain == false || attackRollB == 40 && defend == false && rain == true)
                      {
                        Random critGenB = new Random();
                        int critRollB = 0;

                        if (defend == true)
                        {
                          critRollB = critGenB.Next(1, 6);

                          critRollB = critRollB + 5;
                        } else if (defend == false)
                        {
                          critRollB = critGenB.Next(1,21);

                          critRollB = critRollB + 10;

                          if (rain == true)
                          {
                            critRollB = critRollB + 10;
                          }
                        }

                        int critDamageB = attackRollB + critRollB;

                        PH = PH - critDamageB;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        } else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("\n CRITICAL HIT!");

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\n BORF casts SPINNING BACK KICK and deals " + critDamageB + " critical damage!");
                     
                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                      }
                      //PARRY(ALLOW CRITICAL PARRYING????)(NO NEED TO SPECIFY IF RAIN IS TRUE OR FALSE IF THE PLAYER IS DEFENDING)
                      else if (attackRollB < 0 && defend == true)
                      {
                        Random parryGenB = new Random();
                        int parryRollB = 0;         
                    
                        if (PH <= 150 && noHit == false)
                        {
                          parryRollB = parryGenB.Next(1, 6);

                          if (rain == true)
                          {
                            parryRollB = parryRollB + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollB = parryRollB + 10;
                          }
                        } else if (PH > 150 && noHit == false)
                        {
                          parryRollB = parryGenB.Next(1, 6);

                          parryRollB = parryRollB + 15;

                          if (rain == true)
                          {
                            parryRollB = parryRollB + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollB = parryRollB + 10;
                          }
                        } else if (PH <= 150 && noHit == true)
                        {
                          parryRollB = parryGenB.Next(1, 6);

                          parryRollB = parryRollB + 5;

                          if (rain == true)
                          {
                            parryRollB = parryRollB + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollB = parryRollB + 10;
                          }
                        } else if (PH > 150 && noHit == true)
                        {
                          parryRollB = parryGenB.Next(1, 6);

                          parryRollB = parryRollB + 20;
  
                          if (rain == true)
                          {
                            parryRollB = parryRollB + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollB = parryRollB + 10;
                          }
                        }

                        noHit = true;

                        BH = BH - parryRollB;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        } else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.WriteLine("\n PARRIED!");

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine("\n BORF takes " + parryRollB + " damage!");

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }

                        if (poisonP > 0)
                        {
                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }                      
                    
                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();

                          poisonB = poisonB + 5;

                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }
                          else
                          {
                            Console.BackgroundColor = ConsoleColor.Black;
                          }

                          Console.ForegroundColor = ConsoleColor.DarkGreen;

                          Console.WriteLine("\n You infect borf.");
                        }
                      }

                      Console.BackgroundColor = ConsoleColor.Black;

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                    else
                    {
                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else 
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.DarkBlue;

                      Console.WriteLine("\n DODGED!");
          
                      Console.ForegroundColor = ConsoleColor.Blue;
                    
                      Console.WriteLine("\n Borf casts bounce and deals 0 damage!");

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();

                      noHit = true;
                    }
                  }
                }

                //GOBLIN
                if (goblinArrive == true && BH > 0 && PH > 0)
                {
                  goblinArrive = true;
                  
                  //DETERMINES WHO THE GOBLIN ATTACKS
                  Random goblinPickGen = new Random();
                  int goblinPickRoll = 0;

                  goblinPickRoll = goblinPickGen.Next(1, 4);
                  //GOBLIN ATTACKS PLAYER
                  if (goblinPickRoll >= 1 && goblinPickRoll <= 2)
                  {
                    //GOBLIN DETERMINES IF THE PLAYER DODGES GOBLIN OR NOT
                    Random dodgeGen2 = new Random();
                    int dodgeRoll2 = 0;

                    dodgeRoll2 = dodgeGen2.Next(1, 21);

                    if (dodgeRoll2 != 20 && dodge == false || dodgeRoll2 < 17 && dodge == true)
                    {
                      Random goblinAttackGenP = new Random();
                      int goblinAttackRollP = 0;

                      if(defend == false)
                      {
                        goblinAttackRollP = goblinAttackGenP.Next(1, 21);

                        goblinAttackRollP = goblinAttackRollP + 10;

                        if (rain == true)
                        {
                          goblinAttackRollP = goblinAttackRollP + 10;
                        }
                      }
                      else if (defend == true)
                      {
                        goblinAttackRollP = goblinAttackGenP.Next(0, 12);

                        goblinAttackRollP = goblinAttackRollP - 1;
                      }
                   
                      //NORMAL GOBLIN ATTACK PLAYER                                                                                                                                       //rain == true
                      if (goblinAttackRollP != 30 && defend == false && rain == false || goblinAttackRollP != 10 && goblinAttackRollP != 0 && goblinAttackRollP != -1 && defend == true || goblinAttackRollP != 40 && defend == false && rain == true)
                      {
                        PH = PH - goblinAttackRollP;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n The Goblin attacks you dealing " + goblinAttackRollP + " damage.");

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();
                      }
                      //GOBLIN CRIT ATTACK PLAYER                                                                                         //rain == true
                      else if (goblinAttackRollP == 30 && defend == false && rain == false || goblinAttackRollP == 10 && defend == true || goblinAttackRollP == 40 && defend == false && rain == true)
                      {
                        Random goblinCritGenP = new Random();
                        int goblinCritRollP = 0;

                        if (defend == false)
                        {
                          goblinCritRollP = goblinCritGenP.Next(1, 21);

                          goblinCritRollP = goblinCritRollP + 10;

                          if (rain == true)
                          {
                            goblinCritRollP = goblinCritRollP + 10;
                          }
                        }
                        else if (defend == true)
                        {
                          goblinCritRollP = goblinCritGenP.Next(1, 6);

                          goblinCritRollP = goblinCritRollP + 5;
                        }

                        int goblinCritDamageP = goblinAttackRollP + goblinCritRollP;

                        PH = PH - goblinCritDamageP;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else if (PH <= 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        Console.WriteLine("\n CRITICAL HIT!");

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n The Goblin attacks you dealing " + goblinCritDamageP + " critical damage!");

                        if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                        {                  
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }
                        else if (PH > 150 && poisonP > 0 && poisonB > 0)
                        {
                          Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                        }

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();
                      }
                      //GOBLIN PLAYER BLOCKED
                      else if (goblinAttackRollP == 0 && defend == true)
                      {
                        noHit = true;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        Console.WriteLine("\n BLOCKED!");

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n The Gobin chooses to attack you, dealing 0 damage!");

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();
                      }
                      //GOBLIN PLAYER PARRY
                      else if (goblinAttackRollP == -1 && defend == true)
                      {
                        noHit = true;

                        Random parryGenG = new Random();
                        int parryRollG = 0;

                        if (PH <= 150 && noHit == false)
                        {
                          parryRollG = parryGenG.Next(1, 6);

                          if (rain == true)
                          {
                            parryRollG = parryRollG + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollG = parryRollG + 10;
                          }
                        } else if (PH > 150 && noHit == false)
                        {
                          parryRollG = parryGenG.Next(1, 6);

                          parryRollG = parryRollG + 15;

                          if (rain == true)
                          {
                            parryRollG = parryRollG + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollG = parryRollG + 10;
                          }
                        } else if (PH <= 150 && noHit == true)
                        {
                          parryRollG = parryGenG.Next(1, 6);

                          parryRollG = parryRollG + 5;

                          if (rain == true)
                          {
                            parryRollG = parryRollG + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollG = parryRollG + 10;
                          }
                        } else if (PH > 150 && noHit == true)
                        {
                          parryRollG = parryGenG.Next(1, 6);

                          parryRollG = parryRollG + 20;
  
                          if (rain == true)
                          {
                            parryRollG = parryRollG + 5;
                          }

                          if (heavenBuff == true)
                          {
                            parryRollG = parryRollG + 10;
                          }
                        }

                        GH = GH - parryRollG;

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.White;
                        }
                        else
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine("\n PARRIED!");

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\n You parry the Goblin, dealing " + parryRollG + " (goblin) damage!");

                        if (GH < 1)
                        {
                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.Black;
                          }

                          Console.ForegroundColor = ConsoleColor.Black;

                          Console.ReadKey();

                          if (PH > 150)
                          {
                            Console.BackgroundColor = ConsoleColor.White;
                          }
                          else
                          {
                            Console.BackgroundColor = ConsoleColor.Black;
                          }

                          Console.ForegroundColor = ConsoleColor.Green;

                          Console.WriteLine("\n The Goblin is dead because of you.");

                          goblinArrive = false;
                        }

                        if (PH > 150)
                        {
                          Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.ReadKey();
                      }
                    }
                    //GOBLIN PLAYER DODGE
                    else
                    {
                      noHit = true;

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else 
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.DarkBlue;

                      Console.WriteLine("\n DODGED!");
                      
                      Console.ForegroundColor = ConsoleColor.Green;
                      
                      Console.WriteLine("\n The Goblin chooses to attack you, dealing 0 damage!");

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                  }
                  //GOBLIN ATTACK BORF
                  else if (goblinPickRoll == 3)
                  {
                    Random goblinAttackGenB = new Random();
                    int goblinAttackRollB = 0;

                    goblinAttackRollB = goblinAttackGenB.Next(1, 21);

                    if (rain == true)
                    {
                      goblinAttackRollB = goblinAttackRollB + 10;
                    }
                    //NORMAL GOBLIN ATTACK BORF
                    if (goblinAttackRollB != 20 && rain == false || goblinAttackRollB != 30 && rain == true)
                    {
                      BH = BH - goblinAttackRollB;

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Green;

                      Console.WriteLine("\n The Goblin chooses to attack BORF, dealing " + goblinAttackRollB + " damage.");

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                    //GOBLIN CRIT ATTACK BORF
                    else if (goblinAttackRollB == 20 && rain == false || goblinAttackRollB == 30 && rain == true)
                    {
                      Random goblinCritGenB = new Random();
                      int goblinCritRollB = 0;

                      goblinCritRollB = goblinCritGenB.Next(1, 21);

                      int goblinCritDamageB = goblinAttackRollB + goblinCritRollB;

                      if (rain == true)
                      {
                        goblinCritDamageB = goblinCritDamageB + 20;
                      }

                      BH = BH - goblinCritDamageB;

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.DarkYellow;

                      Console.WriteLine("\n CRITICAL HIT!");

                      Console.ForegroundColor = ConsoleColor.Green;

                      Console.WriteLine("\n The Goblin chooses to attack BORF, dealing " + goblinCritDamageB + " damage!");

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                  }
                }

                //STORM
                if (storm == true && BH > 0 && PH > 0)
                {
                  Random stromGen = new Random();
                  int stormRoll = stromGen.Next(1, 101);
                  //RAIN
                  if (stormRoll >= 1 && stormRoll < 46 && rain == false)
                  {
                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;

                    Console.WriteLine("\n It begins to rain...");

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    rain = true;
                  }
                  //HAIL
                  else if (stormRoll >= 46 && stormRoll < 91 && rain == false || stormRoll >= 1 && stormRoll < 91 && rain == true)
                  {
                    Random hailGen = new Random();
                    int hailRoll = 0;

                    hailRoll = hailGen.Next(1, 21);

                    hailRoll = hailRoll + 10;
                    
                    if (rain == true)
                    {
                      hailRoll = hailRoll + 10;
                    }

                    PH = PH - hailRoll;
                    BH = BH - hailRoll;
                    if (goblinArrive == true)
                    {
                      GH = GH - hailRoll;
                    }

                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;


                    if (goblinArrive == false)
                    {
                      Console.WriteLine("\n Hail begins to fall dealing " + hailRoll + " damage to both you and BORF.");
                    }
                    else if (goblinArrive == true)
                    {
                      Console.WriteLine("\n Hail begins to fall dealing " + hailRoll + " damage to you, BORF and the Goblin.");
                    }

                    if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                    {                  
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();                   
                  }
                  //LIGHTNING
                  else if (stormRoll >= 91)
                  {
                    //DECIDES WHO GETS HIT BY LIGHTNING
                    Random lightningGen = new Random();
                    int lightningRoll = 0;
                    
                    if(goblinArrive == false)
                    {
                      lightningRoll = lightningGen.Next(1, 3);
                    }
                    else if (goblinArrive == true)
                    {
                      lightningRoll = lightningGen.Next(1, 4);
                    }

                    //DECIDES HOW MUCH DAMAGE IS DEALT BY LIGHTNING
                    Random lightningDamageGen = new Random();
                    int lightningDamageRoll = 0;

                    lightningDamageRoll = lightningDamageGen.Next(0, 51);

                    lightningDamageRoll = lightningDamageRoll + 50;

                    if (rain == true)
                    {
                      lightningDamageRoll = lightningDamageRoll + 50;
                    }


                    if (lightningRoll == 1)
                    {
                      Console.ForegroundColor = ConsoleColor.DarkMagenta;

                      PH = PH - lightningDamageRoll;

                      if(PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.WriteLine("\n You get hit by lightning and take " + lightningDamageRoll + " damage!");

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                    else if (lightningRoll == 2)
                    {
                      if(PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.DarkMagenta;

                      Console.WriteLine("\n BORF gets hit by lightning and takes " + lightningDamageRoll + " damage!");

                      BH = BH - lightningDamageRoll;

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                    else if (lightningRoll == 3)
                    {
                      if(PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.White;
                      }
                      else
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.DarkMagenta;

                      Console.WriteLine("\n The Goblin gets hit by lightning and takes " + lightningDamageRoll + " damage!");

                      GH = GH - lightningDamageRoll;

                      if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                      {                  
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }
                      else if (PH > 150 && poisonP > 0 && poisonB > 0)
                      {
                        Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                      }

                      if (PH > 150)
                      {
                        Console.BackgroundColor = ConsoleColor.Black;
                      }

                      Console.ForegroundColor = ConsoleColor.Black;

                      Console.ReadKey();
                    }
                  }
                  storm = false;
                }
                //RAT
                else if (rat == true && BH > 0 && PH > 0)
                {
                  poisonP = poisonP + 5;

                  if(PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkGreen;

                  Console.WriteLine("\n A Rat sinks it's teath in your leg, poisoning you.");

                  if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                  {                  
                    Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                  {
                    Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                  }
                  else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                  }
                  else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }
                  else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }
                  else if (PH > 150 && poisonP > 0 && poisonB > 0)
                  {
                    Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                  }

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey(); 
                }
                //HEAVEN
                else if (light == true && BH > 0 && PH > 0)
                {
                  Random blessGen = new Random();
                  int blessRoll = 0;

                  blessRoll = blessGen.Next(1, 101);

                  if (blessRoll >= 1 && blessRoll <= 45 && heavenBuff == false && dodge == false || blessRoll >= 1 && blessRoll <= 90 && heavenBuff == false && dodge == true)
                  {
                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    if (PH > 150)
                    {
                      Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else 
                    {
                      Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("\n The heavens bless you with strength.");

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    heavenBuff = true;
                  }
                  else if (blessRoll >= 46 && blessRoll <= 90 && heavenBuff == false && dodge == false || blessRoll >= 1 && blessRoll <= 90 && heavenBuff == true && dodge == false)
                  {
                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    if (PH > 150)
                    {
                      Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else 
                    {
                      Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("\n The heavens bless you with haste.");

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    dodge = true;
                  }
                  else if (blessRoll >= 91 && heavenBuff == false && dodge == false || blessRoll > 0 && heavenBuff == true && dodge == true)
                  {
                    Random heavenHealGen = new Random();
                    int heavenHealRoll = 0;

                    heavenHealRoll = heavenHealGen.Next(0, 51);

                    heavenHealRoll = heavenHealRoll + 100;

                    PH = PH + heavenHealRoll;

                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    if (PH > 150)
                    {
                      Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else 
                    {
                      Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine("\n The heavens bless you with " + heavenHealRoll + " health!");

                    if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                    {                  
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();
                  }
                }
                //CURSE
                else if (curse == true && BH > 0 && PH > 0)
                {
                  Random cursePickGen = new Random();
                  int cursePickRoll = 0;

                  cursePickRoll = cursePickGen.Next(1, 6);

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else 
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkRed;

                  Console.WriteLine("\n Something's missing.");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  if (cursePickRoll >= 1 && cursePickRoll <= 2)
                  {
                    attackCurse = true;
                    curseCounter = 6;
                  }
                  else if (cursePickRoll >= 3 && cursePickRoll <= 4)
                  {
                    healCurse = true;
                    curseCounter = 6;
                  }
                  else if (cursePickRoll == 5)
                  {
                    defendCurse = true;
                    curseCounter = 6;
                  }
                }

                //POISON PLAYER
                if (poisonP > 0 && BH > 0 || poisonB > 0 && PH > 0)
                {
                  //PLAYER POISON DAMAGE
                  Random poisonGenP = new Random();
                  int poisonRollP = 0;

                  poisonRollP = poisonGenP.Next(1, 6);

                  poisonRollP = poisonRollP + poisonP;

                  //BORF POISON DAMAGE
                  Random poisonGenB = new Random();
                  int poisonRollB = 0;

                  poisonRollB = poisonGenB.Next(1, 6);

                  poisonRollB = poisonRollB + poisonB;

                  if (poisonP > 0 && poisonB <= 0)
                  {
                    PH = PH - poisonRollP;

                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("\n You take " + poisonRollP + " poison damage.");

                    if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                    {                  
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    poisonP = poisonP - 1;
                  }
                  //POISON BORF
                  else if (poisonP <= 0 && poisonB > 0)
                  {
                    BH = BH - poisonRollB;

                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("\n BORF takes " + poisonRollB + " poison damage.");

                    if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                    {                  
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    poisonB = poisonB - 1;
                  }
                  //POISON PLAYER AND BORF
                  else if (poisonP > 0 && poisonB > 0)
                  {
                    PH = PH - poisonRollP;

                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("\n You take " + poisonRollP + " poison damage.");

                    if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                    {                  
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    BH = BH - poisonRollB;

                    if(PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine("\n Then BORF takes " + poisonRollB + " poison damage.");

                    if (PH > 150)
                    {
                      Console.BackgroundColor = ConsoleColor.Black;
                    }
                
                    if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                    {                  
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    else if (PH > 150 && poisonP > 0 && poisonB > 0)
                    {
                      Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                    }
                    
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.ReadKey();

                    poisonP = poisonP - 1;
                    poisonB = poisonB - 1;
                  }
                }

                //GOBLIN ARRIVE (KEEP THIS AFTER THE GOBLIN CODE)
                if(goblin == true && BH > 0 && PH > 0)
                {
                  goblin = false; 
                  goblinArrive = true;

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Green;

                  Console.WriteLine("\n The Goblin has arrived.");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }
                else if (goblin == true && BH < 1 || goblin == true && PH < 1)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Green;

                  Console.WriteLine("\n The Goblin was too late.");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }

                if (PH <= 150 && poisonP <= 0 && poisonB <= 0)
                {                  
                  Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF [" + BH + "]";
                }
                else if (PH > 150 && poisonP <= 0 && poisonB <= 0)
                {
                  Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                }
                else if (PH <= 150 && poisonP > 0 && poisonB <= 0)
                {
                  Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF [" + BH + "]";
                }
                else if (PH <= 150 && poisonP <= 0 && poisonB > 0)
                {
                  Console.Title = "PLAYER [" + PH + "] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                }
                else if (PH <= 150 && poisonP > 0 && poisonB > 0)
                {
                  Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + "] [" + mana + "]  -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                }
                else if (PH > 150 && poisonP > 0 && poisonB <= 0)
                {
                  Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF [" + BH + "]";
                }
                else if (PH > 150 && poisonP <= 0 && poisonB > 0)
                {
                Console.Title = "PLAYER [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                }
                else if (PH > 150 && poisonP > 0 && poisonB > 0)
                {
                  Console.Title = "PLAYER (!!!POISONED X" + poisonP + "!!!) [" + PH + " HEALTHY BOY ATTACK BONUStm] [" + mana + "] -- BORF (!!!POISONED X" + poisonB + "!!!) [" + BH + "]";
                }

                if (mana <= 9)
                {
                  mana++;
                }

                if (curseCounter > 0)
                {
                  curseCounter = curseCounter - 1;
                }
                
                if (curseCounter < 1 && attackCurse == true && BH > 0 && PH > 0 || curseCounter < 1 && healCurse == true && BH > 0 && PH > 0 || curseCounter < 1 && defendCurse == true && BH > 0 && PH > 0)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.White;
                  }
                  else
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkRed;

                  Console.WriteLine("\n You regain what was once lost.");

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  attackCurse = false;
                  healCurse = false;
                  defendCurse = false;
                }

                if (preventEvent == true)
                {
                  preventEvent = false;
                }

                roundCounter = roundCounter + 1;

                if (roundCounter == 20)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n The heat is unbearable.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }

                if (roundCounter == 40)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n It's hard to breathe.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }

                if (roundCounter == 60)
                {
                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n The sun grows larger.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();
                }

                if (roundCounter > 70)
                {
                  Console.Title = "";

                  if (PH > 150)
                  {
                    Console.BackgroundColor = ConsoleColor.Black;
                  }

                  Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  Console.ForegroundColor = ConsoleColor.DarkGray;

                  Console.WriteLine("\n With a wheeze, you look up to the colossal sun, watching as it collapses into itself.");

                  Console.ForegroundColor = ConsoleColor.Black;

                  Console.ReadKey();

                  PH = 0;
                }

                //END(DO NOT PLACE ANYTHING THAT WILL DEAL DAMAGE AFTER THIS IF STATEMENT)!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if (PH <= 0 || BH <= 0)
                {
                  borfFight = false;
                }
              }
              if (BH <= 0)
              {
                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n You win!");
              } else if (PH <= 0)
              {
                Console.Title = "";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n You lose!");
              }
              else if (BH <= 0 && BH <= 0 && GH > 0)
              {
                Console.Title = "?";

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("\n The Goblin wins?");
              }
              
              Console.ForegroundColor = ConsoleColor.Black;

              Console.ReadKey();
            } else
            {
              Console.Title = "";

              Console.WriteLine("\n 'No...'");

              Console.ReadKey();
            }      
            }

            Console.ReadKey();

            

        }


    } 
}

