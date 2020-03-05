using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Collider2D>().tag == "Player")
        {
            Destroy(gameObject);
            characterMovement food1 = other.GetComponent<characterMovement>();
            food1.food.Add("burguer");
            print(food1.food[0]);
        }
    }
}
