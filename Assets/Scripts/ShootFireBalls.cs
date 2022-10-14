using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFireBalls : MonoBehaviour
{
    public GameObject ballPrefabs;
    public float waitForSeconds,startDelay;
    void Start()
    {
        
        InvokeRepeating("ShootBalls", startDelay, waitForSeconds);
    }

    
    void Update()
    {
        
    }
    
    void ShootBalls()
    {
        Instantiate(ballPrefabs, transform.position, ballPrefabs.transform.rotation);
    }
}
