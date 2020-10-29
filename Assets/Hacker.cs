// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    // Game Config
    const string menuHint = "Type 'menu' to return to main menu";
    string[] level1Password = { "patty", "pickles", "lettuce", "tomatoes", "cheese", "ketchup", "mustard", "onions" };
    string[] level2Password = { "handsome", "clarinet", "tentacles", "misery", "cashier" };
    string[] level3Password = { "money", "dollar", "greedy", "payday" };

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

        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");

        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }

        else
        {
            Terminal.WriteLine("Please choose a valid option...");
            Terminal.WriteLine(menuHint);
        }

    }

    void CheckUserGuess(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong, you filthy animal!");
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Raviolli raviolli show me the Formioulli!");
                Terminal.WriteLine(@"
   ,-.
 _(*_*)_
(_  o  _)
  / o \
 (_/ \_) 
                ");
                break;
            case 2:
                Terminal.WriteLine("Logging into Squidward's Onlyfans account...");
                Terminal.WriteLine(@"
        .--'''''''''--.
     .'      .---.      '.
    /    .-----------.    \
   /        .-----.        \
   |       .-.   .-.       |
   |      /   \ /   \      |
    \    | .-. | .-. |    /
     '-._| | | | | | |_.-'
         | '-' | '-' |
          \___/ \___/
       _.-'  /   \  `-._
     .' _.--|     |--._ '.
     ' _...-|     |-..._ '
            |     |
            '.___.'
                ");
                break;
            case 3:
                Terminal.WriteLine("Entering Mr. Crab's bank pin..."); ;
                Terminal.WriteLine(@"
   _      _
  (<      >)
   `O,99,O`
  //-\__/-\\ 
                ");
                break;
            default:
                Debug.LogError("Invalid level reached");
                break;
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();

        SetRandomPassword();

        Terminal.WriteLine("Enter the secret code: ");
        Terminal.WriteLine("Hint: " + password.Anagram());
        Terminal.WriteLine("");
        Terminal.WriteLine(menuHint);
    }

    void SetRandomPassword()
    {
        switch (level)
        {
            case 1:
                password = level1Password[Random.Range(0, level1Password.Length)];
                break;
            case 2:
                password = level2Password[Random.Range(0, level2Password.Length)];
                break;
            case 3:
                password = level3Password[Random.Range(0, level3Password.Length)];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

}
