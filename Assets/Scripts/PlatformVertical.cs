using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformVertical : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    int curernt;
    public bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == true)
        {
            if (transform.position != target[curernt].position)
            {
                transform.position = Vector2.MoveTowards(transform.position, target[curernt].position, speed * Time.deltaTime);

            }
            else
            {
                curernt = (curernt + 1) % target.Length;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.position.y > transform.position.y)
        {
            collision.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
