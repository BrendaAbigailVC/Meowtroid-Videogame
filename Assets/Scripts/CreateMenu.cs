using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class CreateMenu : MonoBehaviour
{
    public AudioSource clip;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ToMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit(){
        Application.Quit();
    }

    public void Configuration(){
        //Sonido y Ajustes
    }

    public void PlayEffect(){
        clip.Play();
    }
}
