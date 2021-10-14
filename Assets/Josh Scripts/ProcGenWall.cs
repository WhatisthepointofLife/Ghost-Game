using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGenWall : MonoBehaviour
{
    [SerializeField] int width, height;
    [SerializeField] GameObject Wall;
    void Start()
    {
        Generation();
    }

    // Update is called once per frame
    void Generation()
    {
        for (int x = 0; x < width; x++)//spawns on the x axis
        {
            for (int y = 0; y < width; y++)
            {
                //Instantiate(Wall, new Vector2(x, 2), Quaternion.identity);
                spawnObj(Wall, x);
            }
            
        }

    }

    void spawnObj(GameObject Wall, int width)//what it spawns will be a child of the procedural gen
    {
        Wall = Instantiate(Wall, new Vector2(width, height), Quaternion.identity);
        Wall.transform.parent = this.transform;
    }
}
