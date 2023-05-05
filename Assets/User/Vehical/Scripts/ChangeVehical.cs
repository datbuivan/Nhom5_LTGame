using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVehical : MonoBehaviour
{
    public GameObject Player;
    public GameObject Point;
    public Vector2 posplay, posdog;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            rb.velocity = Vector2.zero;
            Player.SetActive(true);
            Player.transform.position = new Vector3(transform.position.x + posplay.x, transform.position.y - posplay.y, Player.transform.position.z);  //setup vi chí người so với xe
            GetComponent<VehicalController>().enabled = false;
            GetComponent<ChangeVehical>().enabled = false;
            GetComponent<CapsuleCollider2D>().isTrigger = true;
            Point.SetActive(false);
        }
    }
}
