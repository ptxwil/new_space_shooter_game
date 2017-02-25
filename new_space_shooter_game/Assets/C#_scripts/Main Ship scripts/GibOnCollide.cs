using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour {

    public GameObject[] gibs; //short for giblets (pronounced "jibs"), is a humorous term referring to the variably-sized body parts ("guts"), fragments, and offal produced when non-player characters or game players are damaged or killed in video games. According to John Romero in IGN's interview, Adrian Carmack has been credited for coining the term "gibs".[1] To "gib" one's opponents is to hit them with such force (often with explosives) that they rupture.

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter()
    {
        foreach(GameObject gib in gibs)
        {
            Instantiate(gib, transform.position, transform.rotation);
        }

        Destroy(gameObject);
    }
}
