using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicalController : MonoBehaviour
{
    public GameObject Point;
    public GameObject ekey;
    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator Anm;

    public float speed = 5f;
    float velocity_x;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        Anm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Point.SetActive(true);
        ekey.SetActive(false);
        velocity_x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(velocity_x * speed, rb.velocity.y);
        Anm.SetFloat("velocity_x", velocity_x);
    }
}
