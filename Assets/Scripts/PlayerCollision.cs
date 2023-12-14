using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Transform spawnpoint;
    public Animator animator2;
    private Rigidbody2D rb;

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
    IEnumerator GetHurt(float süre)
    {
        Physics2D.IgnoreLayerCollision(7, 9);
        yield return new WaitForSeconds(süre);
        Physics2D.IgnoreLayerCollision(7, 9, false);
    }

    public void Respawn()
    {

        //this.transform.position = spawnpoint.position;                             // Spawn point ile yapmaktansa scene manager ile ayný sahneyi yeniden yükledim
                                                                                     // Bu sayede karakter öldüðünde dead animasyonu takýlý kalmýyor
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        animator2.SetTrigger("Death");
    }



}
