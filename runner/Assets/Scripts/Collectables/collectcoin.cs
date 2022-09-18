using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoin : MonoBehaviour
{
    public AudioSource coinfx;
void OnTriggerEnter(Collider other)
    {
        coinfx.Play();
        collectControl.flosC += 1;
           
        this.gameObject.SetActive(false);
    }
}
