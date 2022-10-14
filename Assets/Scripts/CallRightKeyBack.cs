using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallRightKeyBack : MonoBehaviour
{
    public GameObject right;
    PlayerController controllerScript;

    void Start()
    {
        right = GameObject.Find("Right");
        controllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (right.transform.position == transform.position)
        {
            right.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        }
    }
    private void OnMouseDown()
    {

        right.transform.position = transform.position;
        controllerScript.rightAllowed = true;
        right.GetComponent<BoxCollider2D>().isTrigger = true;
        right.GetComponent<DraggableObjects>().rightKey = false;
    }
}
