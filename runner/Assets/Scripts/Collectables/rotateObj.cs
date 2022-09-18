using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class rotateObj : MonoBehaviour
{
    public float rot = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rot, 0, Space.World);
        
    }
}
