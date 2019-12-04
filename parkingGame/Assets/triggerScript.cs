using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerScript : MonoBehaviour
{

    public playerMovement movement;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit detected");
       // movement.enabled = false;	
    }
}
