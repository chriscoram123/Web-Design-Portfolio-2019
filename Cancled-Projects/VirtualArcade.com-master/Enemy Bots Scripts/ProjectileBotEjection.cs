using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBotEjection : MonoBehaviour {
    public Rigidbody projectile;
    public float speed = 270f; 
    //<!--- ==== START PROJECTILE EJECTION ==== --->
	// Use this for initialization
	void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Player")) {
            projectile.AddForce(transform.position -= transform.forward * Time.deltaTime * speed);
            Update();
        }
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("ENEMY PROJECTILE HAS BEEN EJECTED");
	}
    //<!--- END PROJECTILE EJECTION --->
}

