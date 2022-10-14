using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallSpaceKeyBack : MonoBehaviour
{
    public GameObject space;
    PlayerController controllerScript;

    void Start()
    {
        space = GameObject.Find("Spacebar");
        controllerScript = GameObject.Find("Player").GetComponent<PlayerController>();


    }

    // Update is called once per frame
    void Update()
    {
        if (space.transform.position == transform.position)
        {
         space.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
        }
    }
    private void OnMouseDown()
    {

        space.transform.position = transform.position;
        controllerScript.jumpAllowed = true;
        space.GetComponent<BoxCollider2D>().isTrigger = true;
        space.GetComponent<DraggableObjects>().spaceKey = false;
    }
}
