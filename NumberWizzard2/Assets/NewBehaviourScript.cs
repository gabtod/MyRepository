using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    int myNumber = 50;
	// Use this for initialization
	void Start () {

        StartGame();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            myNumber++;
            print(myNumber);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myNumber--;
            print(myNumber);
        }
		

    }

    void StartGame()
    {
        print("To increase the number with 1, press the Up arrow, to decrease the number press the down arrow!");
    }
}
