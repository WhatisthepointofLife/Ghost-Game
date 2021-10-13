using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMent : MonoBehaviour
{
    float distance = 4;

    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + distance);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - distance);
        }
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
