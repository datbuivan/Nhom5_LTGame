using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TopLadder : MonoBehaviour
{
    private GameObject player;
    private BoxCollider2D Collider;
    Rigidbody2D rb;
    public bool isclimb = false;
    public bool setuppos = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Collider = gameObject.GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Player.transform.position.y > transform.position.y+kcPlayer)
        if (player.transform.position.y > transform.position.y + 0.5f && isclimb)
        {
            player.GetComponent<PlayerController>().Climb = false;
        }
            if (player.transform.position.y > transform.position.y + 0.5f)
        {
            Collider.isTrigger = false;
            setuppos = false;
        }
        else
        {
            Collider.isTrigger = true;
        }
        float inputy = Input.GetAxis("Vertical");

        if (!player.GetComponent<PlayerController>().Climb && inputy < 0 && isclimb && !setuppos)
        {
            setuppos = true;
            player.GetComponent<PlayerController>().Climb = true;
            player.transform.position = new Vector3(transform.position.x, player.transform.position.y - 0.5f, player.transform.position.z);
        }

        if (!player.GetComponent<PlayerController>().Climb && inputy < 0 && isclimb && setuppos)
        {
            player.GetComponent<PlayerController>().Climb = true;
            player.transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z);
        }
    }

    public void setclimp()
    {
        isclimb = false;
        setuppos = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isclimb = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isclimb = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isclimb = true;
        }
    }
}
