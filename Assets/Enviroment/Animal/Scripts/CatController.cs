using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    Rigidbody2D rb;
    public ChuroomController churoom;
    bool bat = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setbat()
    {
        bat = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(bat&& collision.gameObject.tag == "Player")
        {
            churoom.CatFind();
            Destroy(gameObject);
        }
    }
}
