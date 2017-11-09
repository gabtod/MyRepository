﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript instance = null;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { 

            Destroy(gameObject);
            print("Duplicate Music Player is self detructing!");
    }
            
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
