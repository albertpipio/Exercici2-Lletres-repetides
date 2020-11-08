using System;
using System.Collections.Generic;

namespace Ex2_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1

            char [] name = new char [6] {'a', 'l', 'b', 'e', 'r', 't'};

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //Fi Fase 1

            //Fase 2

            List<char> listName = new List<char>();

            for (int i = 0; i < name.Length; i++)
            {
                listName.Add(name[i]);
            }

            foreach (var nameExercise in listName)
            {
                switch (nameExercise)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    
                        Console.WriteLine("Vocal");
                        break;

                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    
                        Console.WriteLine("Els noms de persones no contenen números!");
                        break;

                    default:
                    Console.WriteLine("Consonant");
                    break;
                }
            }

            //Fi Fase 2

            //Fase 3

            var nameDictionary = new Dictionary<char, int>(); 

            foreach (var letter in listName)
            {
                if(!nameDictionary.ContainsKey(letter))
                nameDictionary.Add(letter, 1);

                else
                {
                    nameDictionary[letter]++;
                }
            }

            foreach (var letter in nameDictionary)
            {
                Console.WriteLine(letter);
            }

            //Fi Fase 3

            //Fase 4

            char [] surname = new char [5] {'p', 'i', 'p', 'i', 'ó'};

            List<char> surnameList = new List<char>();

            List<char> fullName = new List<char>();

            for (int i = 0; i <surname.Length; i++)
            {
                surnameList.Add(surname[i]);
            }

            fullName.AddRange(listName);
            fullName.AddRange(" ");
            fullName.AddRange(surnameList);

            foreach (var letter in fullName)
            {
                Console.Write(letter);
            }
        }
    }
}