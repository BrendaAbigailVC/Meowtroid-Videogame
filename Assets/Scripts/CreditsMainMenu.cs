using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMainMenu : MonoBehaviour
{
    public void mainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("MeniPrincipal");
    }
}
