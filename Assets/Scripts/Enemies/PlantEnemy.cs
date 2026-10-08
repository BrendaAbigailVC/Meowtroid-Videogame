using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{
    private float waitedtime;
    public float timetoAttack=3;

    public Animator animator;

    public GameObject bulletPrefab;

    public Transform launchSpawnPoint;

    private void Start(){
        waitedtime=timetoAttack;
    }

    private void Update(){
        if(waitedtime<=0){
            waitedtime =timetoAttack;
            animator.Play("Attack");
            Invoke("LaunchBullet",0.5f);
        }else{
            waitedtime -=Time.deltaTime;
        }
    }

    public void LaunchBullet(){
        GameObject newBullet;
        newBullet= Instantiate(bulletPrefab,launchSpawnPoint.position,launchSpawnPoint.rotation);
    }

}
