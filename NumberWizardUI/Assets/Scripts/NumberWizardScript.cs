using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NumberWizardScript : MonoBehaviour {

    
    public Text myText;

    int min = 0;
    int max = 0;
    int guess = 0;
    int maxGuesses = 5;
    

    // Use this for initialization
    void Start () {

        StartGame(); 
        
     }
	
	// Update is called once per frame
	void Update () {

        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
           
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            
            StartGame();
        }*/
        
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        // guess = 500;
        NextGuess();
    }

    void NextGuess ()
    {
        if (maxGuesses > 0)
        {
            guess = Random.Range(min,max+1);
            myText.text = guess + "? ";
            maxGuesses--;
        }
        else
        {
            SceneManager.LoadScene("Win");
        }
        
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
        
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
        
    }

    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    


}
