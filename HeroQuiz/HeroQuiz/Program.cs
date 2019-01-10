using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HeroQuiz
{
    class Program
    {
        static void Main()
        {
            string input1, input2;
            char reDo = 'n';
            DisplayInstructions();
            Hero userName = new Hero(); //we insantiated an object
            input1 = ReadLine();
            Clear();
            userName.Nzame = input1; //input user name into the name field of our constructor from the other class
            Write(userName); //display the object we instantited and active the to string override from the previous constructor 
            ReadKey();
            Welcome();// where the program begins
            Clear();
            
            do
            {
                Ask(); //do while loop look where it will display the message first and run our Ask() first 
                WriteLine("Would you like to retake the Hero Test? (Y/N)");
                input2 = ReadLine();
                reDo = Convert.ToChar(input2); //here is where we ask the user to look back to the the Ask() method
                Clear();
            }
            while ((reDo == 'y') || (reDo == 'Y'));
            DisplayResults(); //shows our answers
            ReadKey();
        }
        static void DisplayInstructions() // the first input we ask the user for
        {
            WriteLine("What is your name:");
        }
        static void Welcome() //begins the quiz after enter
        {
            WriteLine("Welcome to the Hero Test.");
            WriteLine("______________________Press Enter to Continue______________________");
            WriteLine("\n");
            ReadKey();
            Clear();
        }
        public static void Ask()
        {
            
            WriteLine("Question 1: You find a woman getting robbed in an alleyway what do you do? ");
            WriteLine();
            WriteLine("A. Punch the woman and help the robber");
            WriteLine("B. Knockout the robber and save the woman");
            WriteLine("C. Call the Police");
            WriteLine("D. Do nothing");
            WriteLine();
            int[] a = new int[6];
            string QuizAnswer = ReadLine();
            
            switch (QuizAnswer) // this is  where the switch statement begins 
            {
                case "A":
                case "a":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit                               
                            a[i] -= 20;
                        Clear();
                        break;
                    }
                case "B":
                case "b":
                    {

                        for (int i = 0; i < a.Length; i++)
                            a[i] += 5;
                        Clear();
                        break;
                    }
                case "C":
                case "c":
                    {

                        for (int i = 0; i < a.Length; i++)
                            a[i] += 2;
                        Clear();
                        break;
                    }
                case "D":
                case "d":

                    {
                        for (int i = 0; i < a.Length; i++)
                            a[i] += 0;
                        Clear();
                        break;
                    }

                    
            }

            WriteLine("Question 2: You find a convenience store empty and unlocked what would you?");
            WriteLine();
            WriteLine("A. Notify the police or store owner");
            WriteLine("B. Rob the store");
            WriteLine("C. Go to a different store ");
            WriteLine("D. Lock the store yourself so no one can get inside");
            WriteLine();
            QuizAnswer = ReadLine();
            switch (QuizAnswer) // this is  where the switch statement begins 
            {

                case "A":
                case "a":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit 
                            a[i] += 5;
                        Clear();
                        break;
                    }
                case "B":
                case "b":

                    {
                        for (int i = 0; i < a.Length; i++)
                            a[i] -= 5;
                        Clear();
                        break;
                    }
                case "C":
                case "c":
                    {
                        for (int i = 0; i < a.Length; i++)
                            a[i] += 0;
                        Clear();
                        break;
                    }
                case "D":
                case "d":
                    {
                        for (int i = 0; i < a.Length; i++)
                            a[i] += 2;
                        Clear();
                        break;
                    }
               
            }
            WriteLine("Question 3: If you had superpower what would be the first thing you would do?");
            WriteLine();
            WriteLine("A. Kill someone or rob a bank");
            WriteLine("B. Use them to save people ");
            WriteLine("C. Forget you have them ");
            WriteLine("D. Use it them for your own gain");
            WriteLine();
            QuizAnswer = ReadLine();
            switch (QuizAnswer) // this is  where the switch statement begins 
            {
                case "A":
                case "a":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit 
                            a[i] -= 10;
                        Clear();
                        break;
                    }
                case "B":
                case "b":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 10;
                        Clear();
                        break;
                    }
                case "C":
                case "c":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 2;
                        Clear();
                        break;
                    }
                case "D":
                case "d":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 5;
                        Clear();
                        break;
                    }
                    
            }
                    WriteLine("Question 4: You see a stranger drop a 20 dollar bill on the ground what do you do?");
            WriteLine();
            WriteLine("A. Take it and walk away");
            WriteLine("B. Pretend you don't see it");
            WriteLine("C. Take it and try to give it back to the owner ");
            WriteLine("D. Take it and give to homeless person");
            WriteLine();
            QuizAnswer = ReadLine();

            switch (QuizAnswer) // this is  where the switch statement begins 
            {
                case "A":
                case "a":

                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] -= 5;
                        Clear();
                        break;
                    }
                case "B":
                case "b":

                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 2;
                        Clear();
                        break;
                    }
                case "C":
                case "c":

                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 7;
                        Clear();
                        break;
                    }
                case "D":
                case "d":

                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 5;
                        Clear();
                        break;
                    }
                  
            }
                    WriteLine("Question 5: There’s an earthquake and you see that a building is about to collapse what do you do?");
            WriteLine();
            WriteLine("A. Run inside and try to help people evacuate while risking your life");
            WriteLine("B. Run inside and tell them not to worry there is no earthquake");
            WriteLine("C. Buy a sledgehammer or dynamite and try to make the building collapse faster");
            WriteLine("D. Look the other way");
            WriteLine();
            QuizAnswer = ReadLine();
            switch (QuizAnswer) // this is  where the switch statement begins 
            {
                case "A":
                case "a":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 20;
                        Clear();
                        break;
                    }
                case "B":
                case "b":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] -= 7;
                        Clear();
                        break;
                    }
                case "C":
                case "c":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] -= 20;
                        Clear();
                        break;
                    }
                case "D":
                case "d":
                    {
                        for (int i = 0; i < a.Length; i++)//runs the for loop and tests if our i is within our array limit
                            a[i] += 0;
                        Clear();
                        break;
                    }
                    
            }
                    WriteLine("Question 6: A cat is stuck in a tree what do you do?");
            WriteLine();
            WriteLine("A. You help the cat down");
            WriteLine("B. You light the tree on fire");
            WriteLine("C. You don't notice the cat stuck in the tree");
            WriteLine("D. Walk away");
            WriteLine();
            QuizAnswer = ReadLine();
            switch (QuizAnswer) // this is  where the switch statement begins 
            {
                case "A":
                case "a":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 5;
                        Clear();
                        break;
                    }
                case "B":
                case "b":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] -= 20;
                        
                        break;
                    }
                case "C":
                case "c":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 0;
                        Clear();
                        break;
                    }
                case "D":
                case "d":
                    {
                        for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit
                            a[i] += 0;
                        Clear();
                        break;
                    }
                   
            }
                    for (int i = 0; i < a.Length; i++) //runs the for loop and tests if our i is within our array limit 
            {
                Global.sum = +a[i]; //we store our array values into the sum fuctions here it adds every value in the array into the sum 
            }
        }
        public static class Global
        {
            public static int sum = 0;
        }
        public static void DisplayResults() //where we display our results based on if the sum is larger 
        {
            if (Global.sum < 10)
            {
                BackgroundColor = ConsoleColor.Red;
                Clear();
                ForegroundColor = ConsoleColor.White;
                WriteLine("Test Result: {0}  You're a Villian.", Global.sum);
            }
            else if (Global.sum > 9)
            {
                BackgroundColor = ConsoleColor.Blue;
                Clear();
                ForegroundColor = ConsoleColor.White;
                WriteLine("Test Result: {0}  You're a Hero!", Global.sum);
            }
            
        }
    }
}


