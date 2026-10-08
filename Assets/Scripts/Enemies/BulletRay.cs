using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRay : MonoBehaviour
{
    public float speed=2;
    public float bulletlife=2;

    private void Start(){
        Destroy(gameObject, bulletlife);
    }

     private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Destroy(gameObject);
        }
    }

    private void Update(){
            transform.Translate(Vector2.down*speed*Time.deltaTime);
    }
}
