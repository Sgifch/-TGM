using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovoment : MonoBehaviour
{
    private Rigidbody2D rb;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Up")
        {
            //float x = transform.position.x;
            //float y = transform.position.y;
            //transform.Translate(-1+x, 3+y, 0);
            rb.velocity = new Vector2(-0.2f, 0.3f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
