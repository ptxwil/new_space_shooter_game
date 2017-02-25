using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroShipAttack : MonoBehaviour {

   public GameObject blast; // We created a public gameObject that is going to hold our blast object

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //this is a place holder for our attack button right now any key triggers our blast attack
        {
            Instantiate(blast, transform.position, transform.rotation); // This starts the position of our plast from the origin of the ship
        }
		
	}
}
