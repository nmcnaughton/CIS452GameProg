using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere : Shape
{
    Rigidbody rb;
    float speed = 9f;
    float negative = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        if (Random.Range(0, 2) == 1)
            negative = -1;
        else
            negative = 1;

        rb.AddForce(new Vector3(Random.Range((negative) * 800f, (negative) * 600f), 0f, 0f));

        if (Random.Range(0, 2) == 1)
            negative = -1;
        else
            negative = 1;

        rb.AddForce(new Vector3(0f, 0f, Random.Range((negative) * 800f, (negative) * 600f)));
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x < 1.00f && rb.velocity.y < 1.00f && rb.velocity.z < 1.00f)
        {
            Bounce();
        }
    }

    public override void ShapeHit()
    {
        Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Shape"))
        {
            Bounce();
        }

        if (collision.gameObject.CompareTag("Wall"))
        {
            Bounce();
        }
    }

    public override void Bounce()
    {
        if (Random.Range(0, 2) == 1)
            negative = -1;
        else
            negative = 1;

        rb.AddForce(new Vector3(Random.Range((negative) * 800f, (negative) * 600f), 0f, 0f));

        if (Random.Range(0, 2) == 1)
            negative = -1;
        else
            negative = 1;

        rb.AddForce(new Vector3(0f, 0f, Random.Range((negative) * 800f, (negative) * 600f)));
    }
}
