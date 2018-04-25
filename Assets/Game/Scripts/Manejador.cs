using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manejador : MonoBehaviour {

    public Canvas preguntas;
    
    private Completed.Player player;


    // Use this for initialization
    void Start () {
        preguntas = GameObject.Find("Preguntas").GetComponent<Canvas>();
       
        player = GameObject.FindObjectOfType<Completed.Player>();
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BotonPresionado(bool respuesta)
    {
        player.CheckAnswer(respuesta);
        Debug.Log("presiono "+respuesta);
        preguntas.enabled = false;
        Time.timeScale = 1;
    }
}
