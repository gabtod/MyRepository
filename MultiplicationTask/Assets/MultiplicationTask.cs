using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MultiplicationTask : MonoBehaviour {

    public Text myText;
    public InputField UserInput;
    public Button myButton;
    int ans;
    int num1;
    int num2;

    System.Random random = new System.Random();
    // Use this for initialization
    void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    void StartGame()
    {
        Button button = myButton.GetComponent<Button>();
        button.onClick.AddListener(onClick);
        UserInput.text = "What is the answer?";
        RandomMethod();
    }

    void RandomMethod()

    {
        UserInput.text = "";
        num1 = random.Next(1, 10);
        num2 = random.Next(1, 10);
        ans = num1 * num2;
        myText.text = "The answer of " + num1 + " x " + num2 + " is? ";
        onClick();
    }

    public void onClick()
    {
        if (System.Convert.ToInt32(UserInput.text) == ans)
        {
            myText.text = "You are correct, the answer is " + ans
                + "\n\n Let's see if you know the answer of the next question!";
            RandomMethod();
        }
        else
        {
            UserInput.text = "Try Again";

        }
    }

    public void QuitUnity()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
