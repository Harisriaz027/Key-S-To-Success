using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallUp : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
   
}
