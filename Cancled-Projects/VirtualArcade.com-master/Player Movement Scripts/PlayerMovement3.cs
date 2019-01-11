using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {
    public float speed = 10;
    private Rigidbody plyr;

	// Use this for initialization
	void Start () {
        plyr = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float qAxis = Input.GetAxis("Horizontal");
        float wAxis = Input.GetAxis("Verical");

        Vector3 movement = new Vector3(qAxis, 0, wAxis) * speed * Time.deltaTime;
	}
}
