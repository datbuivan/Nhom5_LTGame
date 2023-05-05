using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ekey : MonoBehaviour
{
    public GameObject ekey;
    Rigidbody2D rb;
    public GameObject player;
    public GameObject dog;
    bool Controll = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Controll)
        {
            player.SetActive(false);
            dog.SetActive(false);
            GetComponent<VehicalController>().enabled = true;
            GetComponent<ChangeVehical>().enabled = true;
            GetComponent<CapsuleCollider2D>().isTrigger = false;
            rb.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ekey.SetActive(true);
            Controll = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ekey.SetActive(false);
            Controll = false;
        }
    }
}
