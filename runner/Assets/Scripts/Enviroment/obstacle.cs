using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    //Rigidbody rb;
    public GameObject player;
    public GameObject charModel;
    public AudioSource bonk;
   /* public Transform spawn;
    public Transform spawnL;
    public Transform spawnR;
    public GameObject enemy;
    public float speed;
    public float delay;*/
void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        
        bonk.Play();
        Invoke("Restart", 1.9f);
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }

    /* void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("spawnEnemy", 0f, delay);
        spawnEnemy();   
    }
    void Update()
    {
        rb.velocity = new Vector3(0, 0, speed);
    }
    void spawnEnemy()
    {
        int random = Random.Range(1, 4);
        if (random == 1)
        {
            Instantiate(enemy, spawnL);
        }
        else if (random == 2)
        {
            Instantiate(enemy, spawn);
        }
        else
        {
            Instantiate(enemy, spawnR);
        }
    }*/
}
