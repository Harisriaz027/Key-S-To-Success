using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagWave : MonoBehaviour
{
    Animator flagAnim;
    void Start()
    {
        flagAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            flagAnim.SetTrigger("FLAG");
            StartCoroutine(NextScene());
        }
    }
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
