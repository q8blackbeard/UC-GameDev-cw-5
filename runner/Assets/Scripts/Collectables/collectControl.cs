using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collectControl : MonoBehaviour
{


    public static int flosC;
    public GameObject hsabflos;

    // Update is called once per frame
    void Update()
    {
        hsabflos.GetComponent<Text>().text = "" + flosC;
        //hsabflos.SetActive(false);
    }
}
