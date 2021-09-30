using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
 
    }

    void OnCollisionEnter(Collision collision)
    {
        //è’ìÀîªíË
        if (collision.gameObject.tag == "Plane")
        {
            Destroy(this.gameObject);
        }

        //è’ìÀîªíË
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
