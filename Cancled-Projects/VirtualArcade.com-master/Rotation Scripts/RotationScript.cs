using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {
    public float Rotatespeed = 30f;
    // <!-- ==== START PLAYER ROTATION ON COMMAND ==== -->
    void Rotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * Rotatespeed * Time.deltaTime);
            Debug.Log("ROTATION USING LEFT ARROW");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Rotatespeed * Time.deltaTime);
            Debug.Log("ROTATION USING RIGHT ARROW");
        }
    }
    // <-- END PLAYER ROTATION ON COMMANMD -->
	
	
}
