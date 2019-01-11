using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour {
    public float speed = 30f;
	//<!--- ==== START ENEMY ROTATION ==== --->
	void Update() {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        Debug.Log("Enemy is rotating");
	}
    //<!--- END ENEMY ROTATION --->
}
