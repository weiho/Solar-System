using UnityEngine;
using System.Collections;

public class SimulationSpeed : MonoBehaviour {

	public GUIText timeScaleText;

	// Use this for initialization
	void Start () {
		updateTimeScaleText();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Time.timeScale = 2 * Time.timeScale;
			updateTimeScaleText();
		}
		if (Input.GetButtonDown ("Fire2")) {
			Time.timeScale = Time.timeScale/2;
			updateTimeScaleText();
		}
		//Time.fixedDeltaTime = 0.02F * Time.timeScale;
	}

	void updateTimeScaleText (){
		timeScaleText.text = "Time Scale : " + Time.timeScale.ToString();
	}
}
