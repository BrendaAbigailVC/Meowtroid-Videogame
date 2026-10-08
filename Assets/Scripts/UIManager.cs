using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private Respawn respawn;
    public AudioSource clip;
    public GameObject optionsPanel;

    private void Start(){
        respawn =GameObject.FindGameObjectWithTag("Player").GetComponent<Respawn>();
        respawn.Death += ActivateGameOver;
    }

    private void ActivateGameOver(object sender, EventArgs e){
        menuGameOver.SetActive(true);
    }

    public void OptionsPanel(){
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Return(){
        Time.timeScale =1;
        optionsPanel.SetActive(false);
    }

    public void mainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("MeniPrincipal");
    }

    public void Salirjuego(){
        Application.Quit();
    }

    public void Reiniciar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PlayEffect(){
        clip.Play();
    }

}
