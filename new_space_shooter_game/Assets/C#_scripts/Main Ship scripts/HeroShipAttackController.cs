using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroShipAttackController : MonoBehaviour {

    public float bulletSpeed;

	// Use this for initialization
	void Start ()
    {
        Vector3 newVelocity = Vector3.zero; //Crated a new variable to control the bullet movement to work with collision
        newVelocity.x = bulletSpeed;
        GetComponent<Rigidbody>().velocity = newVelocity;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //We are not using the segement of the code since we are now working on the start
        //Vector3 shipPosition = transform.position;          //Crated a variable of type vector 3 to change the transform of a object position the object being our ship.
        //shipPosition.x += bulletSpeed * Time.deltaTime; // Here we tell the vector 3 that its going to move from an input called Horizontal which will move it to the right and left, we added speed times Time.delta incase we have any issues with frame rates droping if things get to intense. We added the speed float because if not the ship would only move relative to the delta time
        //transform.position = shipPosition; // This sets the initial transfom position to that of the ship
    }
}
