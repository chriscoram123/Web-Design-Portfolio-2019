using UnityEngine;
using System.Collections;

public class ExitObjectInteraction : MonoBehaviour {
    //<!--- ==== START PLAYER PICK UP OBJECT SUGESTIONS ==== --->
    // Function 1 = Player + Input in OnTriggered zone ( How will player pick up object )
    // Function 2 = Player + Object movment with one another ( How will object react to player movmenvents? )
    // Function 3 = Player + Input in OnTriggered zone ( How will player release object in OnTriggered zone? )
    // Function 4 = Specifications to how object is centered in area when Input + release ( How will the object center out in area? )
    //<!--- END PLAYER PICK UP OBJECT SUGESTIONS --->
    public Rigidbody pl;
    public Rigidbody ob;
    public Rigidbody pd;
    Vector3 speed;
    public float Ospeed = 30f;
    //<!--- ==== START PLAYER PICK UP / RELEASE OBJECT FUNCTIONS ==== --->
    //<!--- ==== START PLAYER OBJECT RELEASE ==== --->
    void OnTriggerEnter(Collider pi) {
        if (pi.CompareTag("Player")) {
            CompareTag("Key").position = pd.postiion + speed;
            Start();
        }
    }
    //<!--- END PLAYER OBJECT RELEASE --->
    //<!--- END PLAYER PICK UP / RELEASE OBJECT FUNCTIONS --->
    // Use this for initialization
    void Start() {
        ob.transform.Rotate(Vector3.up, Ospeed + Time.deltaTime);
        Update();
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("KEY HAS BEEN RETURNED TO PEDISTAL AND IS ROTATING!");
    }
}
