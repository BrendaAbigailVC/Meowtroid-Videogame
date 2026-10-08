using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMov : MonoBehaviour
{
    public Animator animator;

    public SpriteRenderer spriteRenderer;

    public float speed=0.5f;

    private float waitTime;

    public Transform[] movSpots;

    public float startWaitTime=2;

    private int i=0;

    private Vector2 actualPos;

    void Start()
    {
        waitTime=startWaitTime;
    }

    void Update()
    {
        transform.position= Vector2.MoveTowards(transform.position,movSpots[i].transform.position, speed*Time.deltaTime);
        if(Vector2.Distance(transform.position,movSpots[i].transform.position)<0.1f){
            if(waitTime<=0){
                if(movSpots[i]!=movSpots[movSpots.Length-1]){
                    i++;
                }else{
                    i=0;
                }
                waitTime =startWaitTime;
            }else{
                waitTime-=Time.deltaTime;
            }
        }
    }
}
