using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gravity : MonoBehaviour
{
    bool isDown;
    Rigidbody2D rb;
    SpriteRenderer tr;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        tr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update() 
    {
        if (isDown)
        {
            transform.position += (-transform.up * 5f * Time.deltaTime);
            tr.sortingLayerName = "layer2";
        }    
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.CompareTag("Tile"))
        {
            Debug.Log("Collision");
        }
    }

   void OnCollisionExit2D(Collision2D coll)
   {
       // If the Collider2D component is enabled on the collided object
        if (coll.collider.CompareTag("Tile"))
        {
            isDown = true; 
        }
    }
}
