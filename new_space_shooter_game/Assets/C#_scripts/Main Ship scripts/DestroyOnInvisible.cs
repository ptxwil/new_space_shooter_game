using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour {

	void OnBecameInvisible()
    {
        Destroy(gameObject); //This method destroy a game object when it leaves the camera
    }
}
