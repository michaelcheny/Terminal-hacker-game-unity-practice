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

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        string greeting = "Hello doodoohead";
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Hello Master Plankton");
        Terminal.WriteLine("");
        Terminal.WriteLine("What would you like to do today?");
        Terminal.WriteLine("");
        Terminal.WriteLine("1. Hack the Krabby Patty formula.");
        Terminal.WriteLine("2. Hack lewd photos of Squidward.");
        Terminal.WriteLine("3. Hack into Mr. Crab's bank account.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection: ");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
