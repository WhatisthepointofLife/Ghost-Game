using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMent : MonoBehaviour
{
    //Distance for the Magical Teleport
    private float distance = 4;

    //Speed related floats
    private float maxSpeed = 20.0f;
    private float minSpeed = -5f;
    public float currentSpeed = 1f;
    private float resetSpeed = 0f;
    
    //Player gameObject
    public GameObject player;

    //Duration and build up
    private float timeAcceleration = 1f;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        minSpeed = currentSpeed;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Keyinputs for up and down teleportation
        if (Input.GetKeyDown("w"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + distance);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - distance);
        }

        //Speed for the character
        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / timeAcceleration);
        transform.position += transform.right * currentSpeed * Time.deltaTime;
        time += Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "obstacle")
        {
            currentSpeed = minSpeed;
            Debug.Log ("Collided");
        }
    }
}
