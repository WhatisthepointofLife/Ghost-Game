using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGenUp : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] GameObject UpLevel;
    void Start()
    {
        Generation();
    }

    // Update is called once per frame
    void Generation()
    {
        for (int x = 0; x < width; x++)
        {
            Instantiate(UpLevel, new Vector2(x, 4), Quaternion.identity);
        }

    }
}
