using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    Transform SpawnPoint;

    public int health;
    public int maxHealth = 3;
    public Animator anim;
    public int direction = 1;
    public Rigidbody2D rb;

    public BarraDeVida healthBar;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
    
    
    public void TakeDamage(int amount) 
    {
        health -= amount;
        if(health <= 0 )
        {
            transform.CompareTag("Enemy");
            transform.position = SpawnPoint.position;
            anim.SetTrigger("die");
            health = maxHealth;
            
        }

        if(health >= 1)
        {
            anim.SetTrigger("hurt");
            if (direction == 1)
                rb.AddForce(new Vector2(-5f, 1f), ForceMode2D.Impulse);
            else
                rb.AddForce(new Vector2(5f, 1f), ForceMode2D.Impulse);
        }

        //void OnCollisionEnter2D(Collision2D collision)
        {
           
            
        }

    }

}
