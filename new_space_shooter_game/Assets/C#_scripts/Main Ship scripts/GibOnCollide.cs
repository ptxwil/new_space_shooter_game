using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour {

    public GameObject[] gibs;

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
