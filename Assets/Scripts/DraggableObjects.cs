using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableObjects : MonoBehaviour
{
    Vector2 mousePOS;
    GameObject pos,pos1,pos2;
    public bool leftKey,rightKey,spaceKey;
    public bool canPlaced;
    PlayerController controllerScript;

    void Start()
    {
        pos = GameObject.Find("LeftPlace");
        pos1 = GameObject.Find("RightPlace");
        pos2 = GameObject.Find("SpacePlace");
        controllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        canPlaced = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (canPlaced==false)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .3f);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1,1);
        }
        mousePOS = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        if (gameObject.CompareTag("Left"))
        {
            if (leftKey == false)
            {
                transform.position = pos.transform.position;
            }
        }
        if (gameObject.CompareTag("Right"))
        {
            if (rightKey == false)
            {
                transform.position = pos1.transform.position;
            }
        }
        if (gameObject.CompareTag("Space"))
        {
            if (spaceKey == false)
            {
                transform.position = pos2.transform.position;
            }
        }

    }
    private void OnMouseDrag()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        transform.position = mousePOS;
        if (gameObject.CompareTag("Right"))
        {
            rightKey = true;
            
            //controllerScript.rightAllowed = false;
        }
        if (gameObject.CompareTag("Left"))
        {
            leftKey = true;
           // transform.position = mousePOS;
           // controllerScript.leftAllowed = false;
        }
        if (gameObject.CompareTag("Space"))
        {
            spaceKey = true;
            // transform.position = mousePOS;
            // controllerScript.leftAllowed = false;
        }


    }

    private void OnMouseUp()
    {
        
        if (canPlaced==true)
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
            if (gameObject.CompareTag("Left"))
            {
                controllerScript.leftAllowed = false;
            }
            if(gameObject.CompareTag("Right"))
            {
                controllerScript.rightAllowed = false;
            }
            if (gameObject.CompareTag("Space"))
            {
                controllerScript.jumpAllowed = false;
            }
        }
        if (gameObject.CompareTag("Left"))
        {
            if (canPlaced == false)
            {
                leftKey = false;
                controllerScript.leftAllowed = true;
                transform.position = pos.transform.position;
                
            }
        }
        if (gameObject.CompareTag("Right"))
        {
            if (canPlaced == false)
            {
                rightKey = false;
                controllerScript.rightAllowed = true;
                transform.position = pos1.transform.position;
                
            }
        }
        if (gameObject.CompareTag("Space"))
        {
            if (canPlaced == false)
            {
                spaceKey = false;
                controllerScript.jumpAllowed = true;
                transform.position = pos2.transform.position;

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.gameObject.CompareTag("Player")|| collision.gameObject.CompareTag("Ground")|| collision.gameObject.CompareTag("Grid"))
            {
                canPlaced = false;
            }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ground")|| collision.gameObject.CompareTag("Grid"))
        {
            canPlaced = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canPlaced = true;
    }
}
