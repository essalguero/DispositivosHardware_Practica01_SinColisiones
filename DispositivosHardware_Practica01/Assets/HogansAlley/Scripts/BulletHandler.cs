using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour {

    private Rigidbody rb;
    private AudioSource audioSource;
    public AudioClip audioClipHit;
    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
        rb = GetComponent < Rigidbody >();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	/*void Update () {
		
	}*/

    public void Shoot(Vector3 direction)
    {
        //Empujar la pelota
        rb.AddForce(direction, ForceMode.Impulse);
    }

    public void onCollisionEnter(Collider other)
    {
        ps.Play();
        audioSource.PlayOneShot(audioClipHit);
    }
}
