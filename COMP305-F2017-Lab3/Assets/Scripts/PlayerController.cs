using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Use this for physics
    void FixedUpdate()
    {
        float hMove = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(hMove, 0, 0);
        rb.velocity = movement * speed;
    }
}
