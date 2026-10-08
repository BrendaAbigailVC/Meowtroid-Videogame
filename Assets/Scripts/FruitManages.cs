using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManages : MonoBehaviour
{
    public Text levelCleared;
    public GameObject transition;

    public Text totalfruits;

    public Text FruitsCollected;

    private int totalfruitsinLevel;

    private void Start(){
        totalfruitsinLevel = transform.childCount;
    }

    private void Update(){
        AllFruitsCollected();
        totalfruits.text=totalfruitsinLevel.ToString();
        FruitsCollected.text =transform.childCount.ToString();
    }
    public void AllFruitsCollected(){

        if(transform.childCount==0){
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene",1);
        }
    }

    void ChangeScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

}
