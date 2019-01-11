using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYERKILLER : MonoBehaviour
{
    //<!--- ==== START PLAYER KILLER FUNCTIONS ==== ---> 
    // Code that dictates player killer movement
    // Code that affects player when making contact
    public Rigidbody pk;
    public float speed = 15f;
    //<!--- ==== START ONTRIGGER KILL PLAYER ==== --->   
    void OnTriggerEnter(Collider cr) {
        if (cr.CompareTag("Player")) {
            //<!--- ==== START SCENE MANAGER ==== --->

            Debug.Log("GAME OVER");
        }
    }
    //<!--- ==== END SCENE MANAGER ==== --->
    //<!--- END ONTRIGGER KILL PLAYER --->
    //<!--- END PLAYER KILLER FUNCTIONS --->
}
