using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour {

    int min = 0;
    int max = 0;
    int guess = 0;

    // Use this for initialization
    void Start () {

        StartGame();   
     }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed!");
            min = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed!");
            max = guess;
            NextGuess();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter pressed");
            print("I won!");
            StartGame();
        }
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        // guess = 500;
        print("Welcome to Number Wizard!");
        print("Pick a number from 1 to 1000");

        NextGuess();
    }

    void NextGuess ()
    {
        guess = (min + max) / 2;
        print("Is the number lower, higher or equal to " + guess + " ?");
        print("UP Arrow: your number is higher, DOWN Arrow: your number is lower, ENTER: it is equal!");

    }
}
