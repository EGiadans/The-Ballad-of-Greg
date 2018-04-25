using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewManejador : MonoBehaviour
{

    public Canvas preguntas;
    private Completed.Player player;


    // Use this for initialization
    void Start()
    {
        preguntas = GameObject.Find("StartMenu").GetComponent<Canvas>();
        player = GameObject.FindObjectOfType<Completed.Player>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BotonPresionadoStart()
    {
        Debug.Log("presiono start");
        
        Time.timeScale = 1;
        
    }

    public void BotonPresionadoQuit()
    {
        Debug.Log("presiono quit");
        Application.Quit();
        
    }

}