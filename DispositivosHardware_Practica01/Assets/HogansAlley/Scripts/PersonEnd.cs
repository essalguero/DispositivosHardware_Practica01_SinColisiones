using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonEnd : MonoBehaviour {

    public float pointsWhenDie = -100;
    public float pointsWhenHit = 200;

    private Animator animator;


    private float timeWhenStart;
    private float waitTime;


    private const int MIN_WAIT_TIME = 4;
    private const int MAX_WAIT_TIME = 10;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();

        timeWhenStart = Time.realtimeSinceStartup;
        waitTime = Random.Range(MIN_WAIT_TIME, MAX_WAIT_TIME);

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup > (waitTime + timeWhenStart))
        {
            animator.SetTrigger("EndNow");
        }
    }

    public void HeColisionado()
    {

        animator.SetTrigger("EndNow");
    }

    /*void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            animator.SetTrigger("EndNow");
        }
    }*/
}
