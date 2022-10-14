using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public GameObject ex;
    void Start()
    {
       ex = GameObject.Find("Particle").GetComponent<Particle>().part;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
        Instantiate(ex, gameObject.transform.position, ex.transform.rotation);
    }
}
