using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGen : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] GameObject GroundLevel;
    void Start()
    {
        Generation();
    }

    // Update is called once per frame
    void Generation()
    {
        for (int x = 0; x < width; x++)
        {
            Instantiate(GroundLevel, new Vector2(x, 0), Quaternion.identity);
        }
        
    }
}
