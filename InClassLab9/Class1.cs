using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab9
{
    public class classInfo
    {
        public static void SudentClassInfo(string ClassStudents)
        {
            int studentInfo = int.Parse(ClassStudents);
            List<string> studentName = new List<string> { "Andrea", "Anthony", "Brian", "Camille", "Clayton", "Damacious", "Daniel", "David", "Evan", "Heather", "Jacky", "Jonathan", "Katie", "Luke", "Maurico", "Rudy", "SeanO", "Steve", "Ty" };
            List<string> homeTown = new List<string> { "Detroit", "Detroit MI", "Detroit, MI", "Detroit, MI", "Detroit, MI", "Detroit, MI", "Oak Park, MI", "Detroit, MI", "Detroit, MI", "Detroit, MI", "Detroit, MI", "Brighton, MI", "WoodHaven, MI", "Detroit, MI", "Detroit, MI", "Detroit, MI", "Clarkston, MI", "Perrysburg, OH", "Birch Run, MI",};
            List<string> favoriteFood = new List<string> { "Food", "Pizza", "Pizza", "Pizza", "Chicken Alfredo", "Pizza", "Spaghetti", "Pizza", "Pizza", "Pizza", "Sushi", "Korean", "Lasagna", "Pizza", "Pizza", "Pizza", "Pasta Salad", "Lettuce",};
            List<string> favoriteColor = new List<string> { "Red", "Grey", "Pink", "Forest Green", "Indiago", "Seafoam Green", "Green", "Green", "Purple", "Yellow", "Orange", "Purple", "Purple", "Green", "Orange", "Black", "Red", "White", "Orange" };
 
            
            Console.WriteLine(studentName[studentInfo-1]); //This information was left since it was easier also forgot ot switch over.

            Console.WriteLine("Would you like to know their Hometown or their Favorite Food or their favorite Color");
            for (int a = 0; a == 0;)
            {
                string factChoice = Console.ReadLine().ToLower(); //factchoice for outputing the facts
                if (factChoice == "hometown")
                {
                    Console.WriteLine(homeTown[studentInfo-1]);
                    break;
                }
                else if (factChoice == "favorite food")
                {
                    Console.WriteLine(favoriteFood[studentInfo-1]);
                    break;
                }
                else if (factChoice == "favorite color")
                {
                    Console.WriteLine(favoriteColor[studentInfo-1]);
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose between 'Hometown' or 'Favorite Food' or 'Favorite Color'");
                }
            }
        }
    }
}
