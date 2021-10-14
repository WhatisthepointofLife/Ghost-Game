using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGen : MonoBehaviour
{
    [SerializeField] int width = 0;
    [SerializeField] GameObject GroundLevel = null;
    void Start()
    {
        Generation();
    }

    // Update is called once per frame
    void Generation()
    {
        for (int x = 0; x < width; x++)//spawn on the x axis
        {
            //Instantiate(GroundLevel, new Vector2(x, 0), Quaternion.identity);
            spawnObj(GroundLevel, x);
        }
    }

    void spawnObj(GameObject GroundLevel, int width)//Puts them as Child under the procedural Gen
    {
        GroundLevel = Instantiate(GroundLevel, new Vector2(width, 0), Quaternion.identity);
        GroundLevel.transform.parent = this.transform;
    }
}
