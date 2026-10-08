using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Respawn : MonoBehaviour
{
    public GameObject[] hearts;
    private int life;
    public event EventHandler Death;

    
    void Start()
    {
        life=hearts.Length;
       
    }

    private void Update(){
        if(life<1){
            Death?.Invoke(this,EventArgs.Empty);
            Destroy(hearts[0].gameObject);
            GetComponent<PlayerMovement>().Die();
        }else if(life<2){
            Destroy(hearts[1].gameObject);
        }else if(life<3){
            Destroy(hearts[2].gameObject);
        }
    }

    public void Damage(){
        life--;
    }

}
