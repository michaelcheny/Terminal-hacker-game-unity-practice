using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu(string greeting = "Plankton")
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello Master " + greeting);
        Terminal.WriteLine("");
        Terminal.WriteLine("What would you like to do today?");
        Terminal.WriteLine("");
        Terminal.WriteLine("1. Hack the Krabby Patty formula.");
        Terminal.WriteLine("2. Hack lewd photos of Squidward.");
        Terminal.WriteLine("3. Hack into Mr. Crab's bank account.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "1")
        {
            ContinueOption1();
        }
        else if (input == "2")
        {
            ContinueOption2();
        }
        else if (input == "3")
        {
            ContinueOption3();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid option...");
        }
    }

    void ContinueOption1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Raviolli raviolli show me the Formioulli!");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter 'menu' to return to menu");
    }

    void ContinueOption2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Logging into Squidward's Onlyfans account...");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter 'menu' to return to menu");
    }

    void ContinueOption3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Entering Mr. Crab's bank pin...");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter 'menu' to return to menu");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
