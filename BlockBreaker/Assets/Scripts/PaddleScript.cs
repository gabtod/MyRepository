using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        print(Input.mousePosition.x);

        //Calculating the new Mouse position in the game units since pixel units are returned
        // screen width of 800 px in equivalent to 16 game units
        // since there is still an offset difference between the mouse and the paddle
        // the offset was noticed to be on the nagative side and that is why we need to reduce
        //-8 game units.



        float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16)-8;

        Vector3 newPaddlePos = new Vector3(mousePosInUnits, gameObject.transform.position.y, gameObject.transform.position.z);

        //we need to create a new var for the new paddle position since we cannot change
        //one cordinate (eg x cooridinate) on its own
        newPaddlePos.x =
            Mathf.Clamp(mousePosInUnits, -7.35f, 7.35f);

        gameObject.transform.position = newPaddlePos;
	}
}
