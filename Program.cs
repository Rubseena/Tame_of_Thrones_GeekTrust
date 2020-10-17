using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//Coded by Rubseena N U
namespace greektrust_TameofThrones
{

    //Derived Class named as Program(Inheritance)
    class Program : CipherFunction
    {
        public void ReadFromFile(string filePath)
        {

            KingdomSelection objkingdom = new KingdomSelection();
            PropertyClass objProperty = new PropertyClass();
            
            string filename = Path.GetFullPath(filePath);

            try
            {
                List<string> result = new List<string>();
                string secretMessage = string.Empty, nameOfKingdom, nameOfEmblem, encryptedValue;
                nameOfKingdom = nameOfEmblem = encryptedValue = string.Empty;
                bool containsAllKeyWords;
                string[] inputLines = File.ReadAllLines(filename);
                foreach (string line in inputLines)
                {
                    string[] strKingdom = line.Split(new char[0]);
                    nameOfKingdom = strKingdom[0];
                    secretMessage = strKingdom[1];
                    nameOfEmblem = objkingdom.Animal(nameOfKingdom);
                    encryptedValue = Encypher(nameOfEmblem, nameOfEmblem.Length).ToUpper();
                    if ((containsAllKeyWords = encryptedValue.All(secretMessage.Contains)) == true)
                    {
                        result.Add(nameOfKingdom);
                    }
                }
                Console.WriteLine("Output :\n");
                if (result.Count >= 3)
                {
                    Console.Write("SPACE ");
                    foreach (string resultSet in result)
                    {
                        Console.Write(resultSet + " ");
                    }
                }
                else
                {
                    Console.Write("NONE");
                }
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"D:\GreekTrustInterview\Tame_of_Thrones_1\Tame_of_Thrones_1\File\input1.txt";
            Program objProgram = new Program();
            objProgram.ReadFromFile(filePath);

        }
    }
}
