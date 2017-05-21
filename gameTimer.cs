using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/*
 * 1. Declare timertext
 * 2. Declare and Initialise myGameTimer as 0.0
 * 3. In Start() declare timerText as get component Text
 * 4. In Update() add Time.deltaTime to myGameTimer
 * 5. convert myGameTimer to string;
 * 6. declare timerText.text with "Timer : " plus myGameTimer
 * 7. Show only up to 3 decimal points
 */

public class gameTimer : MonoBehaviour {

    private Text timerText;
    public float myGameTimer = 0.0f;
	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        myGameTimer += Time.deltaTime;
        timerText.text = "Timer : " + myGameTimer.ToString("f3");
        
	}
}
