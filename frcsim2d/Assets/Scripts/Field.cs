using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(MapMeta.length, MapMeta.width, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
