using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01
{
    /// <summary>
    /// A basic questionnaire game
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string welcomeMessage = @"Welcome to C# questionnaire! Answer all questions and see how many marks will you get!";
            string proceedMessage = @"Press any key to continue..";
            string correctAnswerMessage = @"Brilliant! You got the right answer!";
            string wrongAnswerMessage = @"You are wrong! Next question please..";
            string[] userAnswer = new string[5];
            string[] question = new string[5];
            int correctAnswerCounter = 0;

            string[] answerChoice1 = new string[4];

            question[0] = @"Which of these statements represent a variable?";
            answerChoice1[0] = @"private void string;";
            answerChoice1[1] = @"private static int y = 10.0;";
            answerChoice1[2] = @"private bool hasAnswered = true;";
            answerChoice1[3] = @"private void Something(int a, int b){}";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(welcomeMessage);
            Console.ResetColor();

            Console.WriteLine(proceedMessage);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question[0]);
            Console.ResetColor();
            Console.WriteLine($"A: {answerChoice1[0]}");
            Console.WriteLine($"B: {answerChoice1[1]}");
            Console.WriteLine($"C: {answerChoice1[2]}");
            Console.WriteLine($"D: {answerChoice1[3]}");

            Console.Write("Please type your answer:");
            userAnswer[0] = Console.ReadLine();
            Console.WriteLine("");
            
            if(userAnswer[0] == "c" || userAnswer[0] == "C")
            {
                correctAnswerCounter += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(correctAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(wrongAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }

            question[1] = @"Which of these functions does not return anything?";
            string[] answerChoice2 = new string[4];
            answerChoice2[0] = "private void DoSomething(){}";
            answerChoice2[1] = "private string StoreData(){}";
            answerChoice2[2] = "private bool ReturnData(){}";
            answerChoice2[3] = "private static string void StoreData(int x, int y){}";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question[1]);
            Console.ResetColor(); 
            Console.WriteLine($"A: {answerChoice2[0]}");
            Console.WriteLine($"B: {answerChoice2[1]}");
            Console.WriteLine($"C: {answerChoice2[2]}");
            Console.WriteLine($"D: {answerChoice2[3]}");

            Console.Write("Please type your answer:");
            userAnswer[1] = Console.ReadLine();
            Console.WriteLine("");

            if (userAnswer[1] == "A" || userAnswer[1] == "a")
            {
                correctAnswerCounter += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(correctAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(wrongAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }

            question[2] = @"Which of these datatypes can output a text?";
            string[] answerChoice3 = new string[4];

            answerChoice3[0] = @"int";
            answerChoice3[1] = @"bool";
            answerChoice3[2] = @"char";
            answerChoice3[3] = @"string";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question[2]);
            Console.ResetColor(); 
            Console.WriteLine($"A: {answerChoice3[0]}");
            Console.WriteLine($"B: {answerChoice3[1]}");
            Console.WriteLine($"C: {answerChoice3[2]}");
            Console.WriteLine($"D: {answerChoice3[3]}");

            Console.Write("Please type your answer:");
            userAnswer[2] = Console.ReadLine();
            Console.WriteLine("");

            if (userAnswer[2] == "D" || userAnswer[2] == "d")
            {
                correctAnswerCounter += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(correctAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(wrongAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }

            question[3] = @"Which of these syntax represent a function?";
            string[] answerChoice4 = new string[4];
            answerChoice4[0] = @"public void DoSomething {get; set;}";
            answerChoice4[1] = @"private int count = 1;";
            answerChoice4[2] = @"private string WriteMessage();";
            answerChoice4[3] = @"private string[] Datas = new string[4];";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question[3]);
            Console.ResetColor(); 
            Console.WriteLine($"A: {answerChoice4[0]}");
            Console.WriteLine($"B: {answerChoice4[1]}");
            Console.WriteLine($"C: {answerChoice4[2]}");
            Console.WriteLine($"D: {answerChoice4[3]}");

            Console.Write("Please type your answer:");
            userAnswer[3] = Console.ReadLine();
            Console.WriteLine("");

            if (userAnswer[3] == "C" || userAnswer[3] == "c")
            {
                correctAnswerCounter += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(correctAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(wrongAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }

            question[4] = @"Which of these are the right syntax for writing for loop?";
            string[] answerChoice5 = new string[4];
            answerChoice5[0] = @"for(int i == 0; i < 10; i++){ }";
            answerChoice5[1] = @"for(int i = 0; i < 10; i++){ }";
            answerChoice5[2] = @"foreach(int i = 0; i < 10; i++){ }";
            answerChoice5[3] = @"for(int i > 0; i = 10; i++){ }";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(question[4]);
            Console.ResetColor(); 
            Console.WriteLine($"A: {answerChoice5[0]}");
            Console.WriteLine($"B: {answerChoice5[1]}");
            Console.WriteLine($"C: {answerChoice5[2]}");
            Console.WriteLine($"D: {answerChoice5[3]}");

            Console.Write("Please type your answer:");
            userAnswer[4] = Console.ReadLine();
            Console.WriteLine("");

            if (userAnswer[4] == "B" || userAnswer[4] == "b")
            {
                correctAnswerCounter += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(correctAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(wrongAnswerMessage);
                Console.ResetColor();
                Console.WriteLine(proceedMessage);
                Console.ReadLine();
            }

            if(correctAnswerCounter > 3)
            {
                Console.Write(@"Congratulations! You have scored ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{correctAnswerCounter} out of 5");
                Console.ReadLine();
            }
            else
            {
                Console.Write($"Too bad! You have scored ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{correctAnswerCounter} out of 5.");
                Console.WriteLine("Try again later");
                Console.ReadLine();
            }

        }
    }
}
