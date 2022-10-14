using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public bool leftAllowed,rightAllowed,jumpAllowed;
    Rigidbody2D playerRb;
    public float jumpForce;
    Animator playerAnim;
    bool jumps;

    void Start()
    {
        
        leftAllowed = true;
        rightAllowed = true;
        jumpAllowed = true;
        playerRb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        if ((Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))&&rightAllowed==true)
        {
            transform.eulerAngles = new Vector2(0, 0);
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
            playerAnim.SetFloat("SPEED", 1);
        }
        else
        {
            playerAnim.SetFloat("SPEED", 0);
        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))&&leftAllowed==true)
        {
            transform.eulerAngles = new Vector2(0, 180);
            transform.Translate(Vector2.left * Time.deltaTime * speed * horizontalInput);
            playerAnim.SetFloat("SPEED",1);
        }
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && jumpAllowed&&jumps)
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnim.SetBool("JUMP", true);
            jumps = false;
           
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // if (collision.gameObject.CompareTag("Ground")|| collision.gameObject.CompareTag("Left")|| collision.gameObject.CompareTag("Right"))
        //{
            jumps = true;
            playerAnim.SetBool("JUMP",false);
            
        
    }
}
