using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float life = 3;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Balloon") {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
