using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class KeyControll : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject ekey;
    public GameObject Doorin,Doorout;
    bool getkey = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && getkey)
        {
            Doorin.GetComponent<DoorController>().open = true;
            Doorout.GetComponent<DoorController>().open = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ekey.SetActive(true);
            getkey = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ekey.SetActive(false);
            getkey = false;
        }
    }
}
