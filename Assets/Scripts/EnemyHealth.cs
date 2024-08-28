using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    public void TakeDamage(float damage)
    {
        if(hitPoints - damage > 0)
        {
            BroadcastMessage("OnDamageTaken");
            hitPoints -= damage;
            Debug.Log(hitPoints);
        }
        else
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) { return; }
        isDead = true;
        GetComponent<Animator>().SetTrigger("dead");
    }
}
