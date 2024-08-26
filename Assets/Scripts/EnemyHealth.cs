using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        if(hitPoints - damage > 0)
        {
            hitPoints -= damage;
            Debug.Log(hitPoints);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
