using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public Vector3 offset;

    // Update is called once per frame
//<!--- ==== EXICUTE GAMING MECHANICS ==== --->
    void Update() {
        //<!--- ==== START PLAYER MOVEMENT ==== --->        
        if (Input.GetKey("w")) {
            rb.AddForce(250 * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER MOVED BACK");
        }
        if (Input.GetKey("q")) {
            rb.AddForce(-50 * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER MOVED FORWARD");
        }
        if (Input.GetKey("s")) {
            rb.AddForce(0, 0, 50 * Time.deltaTime);
            Debug.Log("PLAYER MOVED RIGHT");
        }
        if (Input.GetKey("a")) {
            rb.AddForce(0, 0, -50 * Time.deltaTime);
            Debug.Log("PLAYER MOVED LEFT");
        }
        //<!--- ==== START PLAYER ROTATE X AXIS ==== --->
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
            Debug.Log("OBJECT ROTATED RIGHT");
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(Vector3.down * speed * Time.deltaTime);
            Debug.Log("OBJECT ROTATED LEFT");
        }
        //<--- END PLAYER ROTATE X AXIS --->
        //<!--- START PLAYER MOVEMENT Y AXIS --->
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(0, 50 * Time.deltaTime, 0);
            Debug.Log("PLAYER MOVED BACK");
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(0, -50 * Time.deltaTime, 0);
            Debug.Log("PLAYER MOVED BACK");
        }
        //<--- END PLAYER MOVEMENT Y AXIS --->
        //<--- END PLAYER MOVEMENT --->
    }
//<!--- ==== END GAMING MECHANICS ==== --->
}
