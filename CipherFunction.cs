using System;
using System.Collections.Generic;
using System.Text;

namespace greektrust_TameofThrones
{

    //Coded by Rubseena N U
    //BaseClass to Inherit
    public class CipherFunction
    {
        //Defining key as emblemlength
        //Private  and Static Constructor
        private static char Cypher(char cipherChar, int emblemLength)
        {
            if (!char.IsLetter(cipherChar))
                return cipherChar;
            //is this condition true ? yes : no
            char letterPosition = char.IsUpper(cipherChar) ? 'A' : 'a';
            return (char)((((cipherChar + emblemLength) - letterPosition) % 26) + letterPosition);
        }

        public static string Encypher(string secretMessageInput, int emblemLength)
        {
            string encryptResult = string.Empty;
            foreach (char ch in secretMessageInput)
            {
                encryptResult = encryptResult + Cypher(ch, emblemLength);
            }

            return encryptResult;
        }
    }
}
