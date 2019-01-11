using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    public Rigidbody dr;
    public Rigidbody Player;
	// Use this for initialization
	void OnTriggerEnter(Collider cr) {
        if (cr.CompareTag("Player")) {
            Update();
        }
	}
	
	// Update is called once per frame
	void Update () {
        dr.AddForce(0, 50 * Time.deltaTime, 0);
	}
}
