using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Leveledge : MonoBehaviour
{
  
    public static float liftSi  = -20.3f;
    public static float rightSi = 20.3f;
    public  float interliftSi;
    public  float interrightSi;


    // Update is called once per frame
    void Update()
    {
        interliftSi = liftSi;
        interrightSi = rightSi;
    }
}
