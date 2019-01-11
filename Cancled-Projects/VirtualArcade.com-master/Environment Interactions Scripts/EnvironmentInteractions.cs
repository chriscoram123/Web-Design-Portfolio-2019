using UnityEngine;
using System.Collections;

public class EnvironmentInteractions : MonoBehaviour {
    //<!--- ==== START ENVIRONMENT INTERACTION ==== --->    
    // Code will dictate game environment interaction with the player
    //<!--- ==== ENVIRONMENT INTERACTION SUGGESTIONS ==== --->
    // Function 1 = Obstacle One ( Will fall down when player enters middle of room )
    // Function 2 = Obstacle Two ( Will make some obstacles fall quicker than others )
    // Function 3 = Obstacle Three ( Will dissapear when reaching the ground on trigger ) 
    //<!--- ==== END INTERACTION SUGGESTIONS ==== --->
    public Rigidbody obstacle;
    public Rigidbody obstacletwo;
    public float speed;
    public float speedtwo;
    //<!--- ==== START OBSTACLE INTERACTION ==== --->
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    //<!--- END OBSTACLE INTERACTION --->
//<!--- END ENVIRONMENT INTERACTION --->
}
