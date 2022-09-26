using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    
    public float speed, begin, end;
    void Update()
    {
        transform.Translate((Vector2.left * speed * Time.deltaTime));
        if (transform.position.x <= end)
        {
            Vector2 startPosition = new Vector2(begin, transform.position.y);
            transform.position = startPosition;
        }
    }
}
