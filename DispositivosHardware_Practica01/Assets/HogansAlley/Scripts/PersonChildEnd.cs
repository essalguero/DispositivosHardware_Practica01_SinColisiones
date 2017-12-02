using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonChildEnd : MonoBehaviour {

    public PersonEnd personScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            personScript.HeColisionado();
        }
    }
}
