using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{

    public float pSpeed = 5;
    public float lrSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * pSpeed, Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.transform.position.x > Leveledge.liftSi)
            {
                transform.Translate(Vector3.left * Time.deltaTime * lrSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.transform.position.x < Leveledge.rightSi)
            {
                transform.Translate(Vector3.left * Time.deltaTime * lrSpeed * -1);
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            SceneManager.LoadScene(0);
        }
    }
}
