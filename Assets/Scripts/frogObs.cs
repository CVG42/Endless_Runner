using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogObs : MonoBehaviour
{
    public float speed;
    public int dmg = 1;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= -11.9)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().health -= dmg;
            Debug.Log(collision.GetComponent<PlayerController>().health);
            Destroy(gameObject);
        }
    }
}

