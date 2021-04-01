using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    class Day2 : BaseDay, IDay
    {
        private List<PasswordItem> programInput;

        public Day2()
        {
            base.FetchRawInput(2);
        }

        public void SetProgramInput()
        {
            programInput = new List<PasswordItem>();
            foreach (string s in rawInput)
            {
                PasswordItem passwordItem = new PasswordItem();
                passwordItem.min = int.Parse(s.Substring(0, s.IndexOf('-')));
                passwordItem.max = int.Parse(s.Substring(s.IndexOf('-') + 1, (s.IndexOf(':') - 2) - (s.IndexOf('-') + 1)));
                passwordItem.compareChar = s[s.IndexOf(':') - 1];
                passwordItem.password = s.Substring(s.IndexOf(':') + 2);
                programInput.Add(passwordItem);
            }
        }

        public int RunPart1()
        {
            int validPasswords = 0;
            foreach(PasswordItem passwordItem in  programInput)
            {
                int count = passwordItem.password.Count(c => c == passwordItem.compareChar);
                
                if(count >= passwordItem.min && count <= passwordItem.max)
                {
                    validPasswords++;
                }
            }
            return validPasswords;
        }

        public int RunPart2()
        {
            int validPasswords = 0;
            foreach (PasswordItem passwordItem in programInput)
            {
                if (passwordItem.password[passwordItem.min - 1] == passwordItem.compareChar ^ passwordItem.password[passwordItem.max - 1] == passwordItem.compareChar)
                {
                    validPasswords++;
                }
            }
            return validPasswords;
        }
    }

    class PasswordItem
    {
        public int min;
        public int max;
        public char compareChar;
        public string password;
    }
}
