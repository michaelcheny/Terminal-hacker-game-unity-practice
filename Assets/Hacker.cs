using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Game State
    int level;
    string password;
    enum Screen { MainMenu, Password, Win }

    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu(string greeting = "Plankton")
    {
        currentScreen = Screen.MainMenu;
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
        if (input == "menu") // main menu always accessible
        {
            currentScreen = Screen.MainMenu;
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckUserGuess(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "toe nails";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "clarinet";
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = "money";
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid option...");
        }

    }

    void CheckUserGuess(string input)
    {
        // input == password ? Terminal.WriteLine("Correct!") : Terminal.WriteLine("Wrong, you filthy animal!");
        if (input == password)
        {
            Terminal.WriteLine("Correct!");
        }
        else
        {
            Terminal.WriteLine("Wrong, you filthy animal!");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("You have chosen level: " + level);
        Terminal.WriteLine("");

        if (level == 1)
        {
            Terminal.WriteLine("Raviolli raviolli show me the Formioulli!");
        }
        else if (level == 2)
        {
            Terminal.WriteLine("Logging into Squidward's Onlyfans account...");
        }
        else if (level == 3)
        {
            Terminal.WriteLine("Entering Mr. Crab's bank pin...");
        }
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter 'menu' to return to menu");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
