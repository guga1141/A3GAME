using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatSystem : MonoBehaviour
{
    public Animator anim;

    public LayerMask enemyLayers;
    public Transform attackPoint;

    public float attackRange = 0.5f;
    public int attackDamage;
    public float attackRate = 2f;
    public float nextAttackTime = 0f;

    public Button AttackButton;
         







   public void PlayerAttack()
    {
        if (Time.time >= nextAttackTime)
        {
            if (AttackButton == true)
            {
                anim.SetTrigger("Player_Attack");
                Debug.Log("Attack");
                nextAttackTime = Time.time + 1f / attackRate;

                Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

                foreach (Collider2D enemy in hitEnemies)
                {
                    enemy.GetComponent<Enemy>().TakeDamage(attackDamage);

                    Debug.Log("I hit" + enemy.name);
                }
            }
        }     
    }
    void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;

            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }

}
