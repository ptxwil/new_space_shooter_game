using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour {

    public GameObject[] gibs; //short for giblets (pronounced "jibs"), is a humorous term referring to the variably-sized body parts ("guts"), fragments, and offal produced when non-player characters or game players are damaged or killed in video games. According to John Romero in IGN's interview, Adrian Carmack has been credited for coining the term "gibs".[1] To "gib" one's opponents is to hit them with such force (often with explosives) that they rupture.
    public float explosionForce;
    public float spawnRadius = 1.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter() // this is to work with the ridgidbody system and when 2 ridgibodies collide with each other it will check them and then trigger the script the ridgidbody need to be set to trigger.
    {
        foreach(GameObject gib in gibs)
        {
          GameObject gibInstance = Instantiate(gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject; //This is where we active the gib in the object, Random inside sphere and spwan explosion this give us a random vector witing a sphere where going to make the radius as wide to spawn the gib
            gibInstance.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, transform.position, spawnRadius);
        }

        Destroy(gameObject); //This will destroy the gameobject that this script is attached too
    }
}
