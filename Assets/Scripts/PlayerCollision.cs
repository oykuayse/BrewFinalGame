using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Transform spawnpoint;
    public Animator animator;
    private Rigidbody2D rb;

    public bool DeadCheck;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Die();
            HealthManager.health--;
            if (HealthManager.health <= 0)
            {
                
                StartCoroutine(GetHurt(0.5f));
                StartCoroutine(GameOverDelay(0.5f));
                
            }
            else
            {
                
                StartCoroutine(GetHurt(0.5f));
                StartCoroutine(RespawnAfterDelay(0.5f));
                
            }
        }


    }



    IEnumerator RespawnAfterDelay(float delay)
    {
        
        yield return new WaitForSeconds(delay);
        Respawn();
    }
    IEnumerator GameOverDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("GameOverScreen");
    }
    IEnumerator GetHurt(float s�re)
    {
        Physics2D.IgnoreLayerCollision(7, 9);
        yield return new WaitForSeconds(s�re);
        Physics2D.IgnoreLayerCollision(7, 9, false);
    }

    public void Respawn()
    {
        DeadCheck = false;
        animator.SetBool("Death", DeadCheck);

        this.transform.position = spawnpoint.position;                            // Spawn point ile yapmaktansa scene manager ile ayn� sahneyi yeniden y�kledim
        rb.bodyType = RigidbodyType2D.Dynamic;                                     // Bu sayede karakter �ld���nde dead animasyonu tak�l� kalm�yor
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void Die()
    {
        DeadCheck= true;
        animator.SetTrigger("Die");
        Debug.Log("I'm finaly working!");
        rb.bodyType = RigidbodyType2D.Static; 
    }



}
