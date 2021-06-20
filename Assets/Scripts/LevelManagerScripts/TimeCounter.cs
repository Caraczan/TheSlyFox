using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {
	public float s_counter;

	public bool countingUp = true;

	public bool timerIsRunning = false;


	// Deleagata aby 
	private delegate void TimerDelegate();
	private TimerDelegate UpdateTimer;


	void Start() {
		Debug.Log("Strart timer");
		timerIsRunning = true;

		if(countingUp) {
			UpdateTimer = UpdateTimerUp;
			s_counter = 0;
		} else {
			UpdateTimer = UpdateTimerDown;
			if(s_counter <= 0) {
				s_counter = 60;
			}
		}

	}

	void Update() {
		UpdateTimer();
	}



	public void UpdateTimerUp() {
		if(timerIsRunning) {
			if(s_counter < 60) {
				s_counter += Time.deltaTime;
			}
			DisplayTime(s_counter);
		}
	}

	public void UpdateTimerDown() {
		if(timerIsRunning) {
			if (s_counter > 0) {
				s_counter -= Time.deltaTime;
			} else {
				Debug.Log("Time has run out!");
				s_counter = 0;
				timerIsRunning = false;
				//TODO GameOver
			}
			DisplayTime(s_counter);
		}
	}

	private void DisplayTime(float timeToDisplay) {
		float minutes = Mathf.FloorToInt(timeToDisplay/60);
		float seconds = Mathf.FloorToInt(timeToDisplay%60);
		float milliSeconds = (timeToDisplay%1)*1000;
		//QUESTION czy godziny są potrzebne
		float hour = Mathf.Floor(timeToDisplay/3600);

		string timeText = string.Format("{3:00}:{0:00}:{1:00}:{2:000}",minutes,seconds,milliSeconds,hour);


		//TODO Display "timeText" in game
		Debug.Log(timeText);
	}
}