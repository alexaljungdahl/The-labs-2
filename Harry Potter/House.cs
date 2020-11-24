using System;
using System.Collections.Generic;
using System.Text;

namespace Harry_Potter
{
    abstract class House
    {
        public string Name { get; set; }
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }
        public List<Wizard> Members = null;


        public bool IsVowel(char charac)
        {
            string allVowels = "aouiyeåäöAOUIYEÅÄÖ";
            bool theVowel = false;

            foreach (char vow in allVowels)
            {

                if (vow == charac)
                {
                    theVowel = true;

                    break;

                }
            }
            return theVowel;
        }

        public bool IsConsonant(char charac)
        {
            string allConsonants = "bcdfghjklmnpqrstvzxBCDFGHJKLMNPQRSTVZX";
            bool theConsonants = false;

            foreach (char vow in allConsonants)
            {

                if (vow == charac)
                {
                    theConsonants = true;

                    break;

                }
            }
            return theConsonants;
        }

        public virtual bool CountingLetters(string changePassword)
        {
            int count = 0;
            bool rightAmount = true;

            foreach (char letter in changePassword)
            {
                count++;

                if(count >= 5)
                {
                    rightAmount = true;
                }
                else
                {
                    rightAmount = false;
                }
            }
            return rightAmount;
        }

        public virtual bool CheckPassword(string passwordChange)
        {

            char lastCharacter = passwordChange[passwordChange.Length - 1];
            bool passwordCorrect = true;

            if (IsVowel(passwordChange[0]) == true && CountingLetters(passwordChange) == true && IsConsonant(lastCharacter) == true)
            {
                passwordCorrect = true;
            }
            else
            {
                passwordCorrect = false;
            }

            return passwordCorrect;

        }

        public bool SetPassword (string passwordOld, string passwordNew)
        {
            bool passwordChanged = true;
            if (passwordOld == Password && CheckPassword(passwordNew) == true)
            {
                Password = passwordNew;
                passwordChanged = true;

            }
            else
            {
                passwordChanged = false;
            }
            return passwordChanged;
        }

    }
}
