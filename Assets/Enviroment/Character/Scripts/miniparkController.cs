using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class miniparkController : MonoBehaviour
{
    public GameObject ekey;
    public GameObject Cong;
    public GameObject ui;
    public TMP_Text text;
    public Sprite sprite;
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
            Cong.GetComponent<Collider2D>().isTrigger = true;
            Cong.GetComponent<SpriteRenderer>().sprite = sprite;
            text.text = "NoAh ! Tôi đã làm thất lạc ba cục tiền ở trong khu công viên .Anh hãy giúp tôi thu thập nó và đưa lại cho Quang Thuần đang đứng đợi ở cổng bên kia.";
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
