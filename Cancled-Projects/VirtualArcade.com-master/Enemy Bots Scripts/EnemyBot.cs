using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYBOTMOVEMENTS : MonoBehaviour {
//<!--- ==== START ENEMY BOT FUNCTIONS ==== --->   
// Code that dictates enemy bot movement
// Code that detects attraction to player movement 
    public Rigidbody eb;
    public Rigidbody Player;
    public float speed = 15f;
    Vector3 Start_pos;
    Vector3 End_pos;
    public float fraction_of_way_there;
//<!--- ==== START MOVEMENT FOR ENEMY BOT ==== --->
	void Start () {
        for (int i = 0; i < 10; i++) {
            Start_pos = transform.position;
            eb.AddForce(20 * speed * Time.deltaTime, 0, 0);
            End_pos = transform.position + new Vector3(5 * speed * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER IS MOVING");
            Update();
        }
	}
	void Update() {
        fraction_of_way_there += 0.01f;
        transform.position = Vector3.Lerp (Start_pos, End_pos, fraction_of_way_there);
	}
	//<!--- END MOVEMENT TO ENEMY BOT --->

	//<!--- ==== ENEMY BOT DETECTION SYSTEM ==== --->
	void OnTriggerEnter(Collider cr) {
        if (cr.CompareTag("Player")) {
            transform.position = Player.position;
            Debug.Log("ENEMY BOT IS FOLLOWING PLAYER");
        }
    }
    //<!--- END ENEMY BOT DETECTION SYSTEM --->
//<!--- ==== END ENEMY BOT FUNCTIONS ==== -->
}
