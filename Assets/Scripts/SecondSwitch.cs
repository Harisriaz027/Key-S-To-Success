using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSwitch : MonoBehaviour
{
    PlatformHorizontal script;
    void Start()
    {
        script = GameObject.Find("platform-long (1)").GetComponent<PlatformHorizontal>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            script.isLeftActive = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            script.isLeftActive = false;
        }
    }
}
