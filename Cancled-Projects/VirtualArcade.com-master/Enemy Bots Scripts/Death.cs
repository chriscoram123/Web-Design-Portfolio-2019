using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
    //<!--- ==== START DEATH FUNCTION ==== --->
    public Rigidbody enemy;
	// Use this for initialization
	void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Bullet")) {
            Destroy(this.enemy);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
//<!--- END DEATH FUNCTIONS --->
}
