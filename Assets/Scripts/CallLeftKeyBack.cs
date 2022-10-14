using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallLeftKeyBack : MonoBehaviour
{
   public GameObject left;
    PlayerController controllerScript;
   
    void Start()
    {
        left = GameObject.Find("Left");
        controllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (left.transform.position == transform.position)
        {
            left.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
    }
    private void OnMouseDown()
    {

        left.transform.position = transform.position;
        controllerScript.leftAllowed = true;
        left.GetComponent<BoxCollider2D>().isTrigger = true;
        left.GetComponent<DraggableObjects>().leftKey = false;
    }
}
