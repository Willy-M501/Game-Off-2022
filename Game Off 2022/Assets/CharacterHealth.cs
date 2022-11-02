using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    float health = 10;

    void Update()
    {
        
    }

    public void takeDamage(float damgaeTaken)
    {
        health -= damgaeTaken;

        if (health <= 0)
        {
            //Game over / respawn at checkpoint
            Debug.Log("Player dead");
        }
    }
}
