using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Computershare_Code_Test
{
    class GameQuestion
    {
        InputChecker iChecker = new InputChecker();
        int MagicNumber;
        public bool Answered;
        public string FinalAnswer;
        public GameQuestion(List<string> list, bool answered, int magicNum, string finalAnswer)
        {
            MagicNumber = magicNum;
            Answered = answered;
            FinalAnswer = finalAnswer;
        }

        public string TakeListOfInputsOutputOne(List<string> list)
        {
            int numCount = 0;

            //foreach(var input in list)
            //for(int i = 0; i < list.Count; i++)
            while(MagicNumber != 1)
            {
                numCount += 1;
                MagicNumber -= 1;
                //Console.WriteLine("NUMCOUNT: " + numCount);
                //Console.WriteLine("MAGIC NUMBER: " + MagicNumber);

                if(list.Count == numCount)
                {
                    numCount = 0;
                    //Console.WriteLine("Looping through going back to 0");
                }
            }

            FinalAnswer = list[numCount];
           // Console.WriteLine("WHEEEEEEEEE " + FinalAnswer);

            return FinalAnswer;
        }

    }
}
