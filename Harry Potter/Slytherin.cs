using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    class Slytherin : House
    {
        public Slytherin ()
        {
            Name = "Slytherin";
            HouseGhost = "Blodige baronen";
            Mascot = "Orm";
            Password = "Pure-Blood P";

        }
        public override bool CountingLetters(string changePassword)
        {
            int count = 0;
            bool rightAmountSlytherin = true;

            foreach (char letter in changePassword)
            {
                count++;

                if (count >= 8)
                {
                    rightAmountSlytherin = true;
                }
                else
                {
                    rightAmountSlytherin = false;
                }
            }
            return rightAmountSlytherin;
        }

        public override bool CheckPassword(string passwordChange)
        {

            char lastCharacter = passwordChange[passwordChange.Length - 1];
            bool passwordCorrect = true;

            if (IsConsonant(passwordChange[0]) == true && CountingLetters(passwordChange) == true && IsConsonant(lastCharacter) == true)
            {
                passwordCorrect = true;
            }
            else
            {
                passwordCorrect = false;
            }

            return passwordCorrect;

        }


    }
}
