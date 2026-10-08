using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAttack : MonoBehaviour
{
    public Animator animator;
    public float distanceRaycast =0.5f;
    private float cooldownAttack =1.5f;
    private float actualcooldownAttack;
    public GameObject bullet;

    void Start()
    {
        actualcooldownAttack = 0;
    }

    
    void Update()
    {
        actualcooldownAttack -= Time.deltaTime;
    }

    private void FixedUpdate(){
        RaycastHit2D hit2D= Physics2D.Raycast(transform.position,Vector2.down,distanceRaycast);
        if(hit2D.collider!=null){
            if(hit2D.collider.CompareTag("Player")){       
                if(actualcooldownAttack<0){
                    Invoke("LaunchBullet",0.5f);
                    animator.Play("Attack");
                    actualcooldownAttack =cooldownAttack;
                }         
            }
        }
    }

    void LaunchBullet(){
        GameObject newBullet;
        newBullet = Instantiate(bullet,transform.position,transform.rotation);
    }
}
