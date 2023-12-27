using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaretDeath : MonoBehaviour
{
    [SerializeField] float enemyAttackSpeed;
    //[SerializeField] float leftScreenBounds = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Düþman tarafýndan öldürüldü.");
            Destroy(collision.gameObject);
        }
    }

 
    private void FixedUpdate()
    {
        AttackEnemy();
        //DestroyEnemy();
    }

    private void AttackEnemy()
    {
        transform.Translate(0, -1 * enemyAttackSpeed * Time.deltaTime, 0);
    }

    //private void DestroyEnemy()
    //{
    //    if (transform.position.x < -leftScreenBounds)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
