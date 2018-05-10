using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }
    //Allow the game to continue when pressed
    public void BotonPresionadoStart()
    {
        Debug.Log("presiono start");
        Time.timeScale = 1;

    }
    //Terminate application
    public void BotonPresionadoQuit()
    {
        Debug.Log("presiono quit");
        Application.Quit();

    }
}
