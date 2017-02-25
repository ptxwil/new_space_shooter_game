using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroShipController : MonoBehaviour {

    public float ship_Speed = 1.0f; //This is a variable we apply to modify the speed of the ship

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 shipPosition = transform.position; //Crated a variable of type vector 3 to change the transform of a object position the object being our ship.
        shipPosition.x += Input.GetAxis("Horizontal") * ship_Speed * Time.deltaTime; // Here we tell the vector 3 that its going to move from an input called Horizontal which will move it to the right and left, we added speed times Time.delta incase we have any issues with frame rates droping if things get to intense. We added the speed float because if not the ship would only move relative to the delta time
        transform.position = shipPosition;
	}
}
