using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float playerHealth = 100f;

    public void DecreaseHealth(float damage)
    {
        if(playerHealth - damage <= 0)
        {
            Debug.Log("u died nigga");
        }

        playerHealth -= damage;

    }
}
