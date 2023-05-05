using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int maxHealth = 1;
    public Rigidbody2D rb;
    public Animator ani;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        ani.SetTrigger("Hurt");

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Enemy has been killed!");

        ani.SetBool("isdead", true);

        GetComponent<Collider2D>().enabled = false;

        GetComponent<ChasePlayers>().enabled = false;

        this.enabled = false;
    }

 }
