/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {
    Animator myAnim;
    public GameObject key;
    public float chestDelay;
    bool chestOpened = false;
    bool keyPicked = false;

    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E) && !chestOpened)
            {
                StartCoroutine(OpenChest());
            }
        }
    }

    IEnumerator OpenChest()
    {
        myAnim.Play("chest_open");
        yield return new WaitForSeconds(chestDelay);

        if (!keyPicked)
        {
            Instantiate(key, transform.position, Quaternion.identity);
            keyPicked = true;
        }

        chestOpened = true;
    }
}
*/