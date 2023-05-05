using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanhController : MonoBehaviour
{
    public GameObject bus;
    Rigidbody2D rb;
    Animator Anm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anm = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velocity_x = bus.GetComponent<Rigidbody2D>().velocity.x;
        Anm.SetFloat("velocity_x", velocity_x);
    }
}
