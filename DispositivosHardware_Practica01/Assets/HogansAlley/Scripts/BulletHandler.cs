using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour {

    private Rigidbody rb;
    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
        rb = GetComponent < Rigidbody >();
	}
	
	// Update is called once per frame
	/*void Update () {
		
	}*/

    public void Shoot(Vector3 direction)
    {

    }

    public void onCollisionEnter(Collider other)
    {

    }
}
