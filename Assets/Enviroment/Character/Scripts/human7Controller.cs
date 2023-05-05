using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class human7Controller : MonoBehaviour
{
    public GameObject ekey;
    public GameObject ui;
    public TMP_Text text;
    Rigidbody2D rb;
    public GameObject player;


    bool iscontroll = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && iscontroll)
        {
            ekey.SetActive(false);
            ui.SetActive(true);
            text.text = "Oh ! Anh đang tìm kiếm các cọc tiền bị mất ư,Có lẽ anh nên đến hỏi thử ông Đạt Bùi ở bến cang bên hồ.";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ekey.SetActive(true);
            iscontroll = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ekey.SetActive(false);
            ui.SetActive(false);
            iscontroll = false;
        }
    }
}
