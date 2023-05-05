using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class ChuroomController : MonoBehaviour
{
    public GameObject ekey;
    public GameObject bien;
    public GameObject ui;
    public TMP_Text text;
    Rigidbody2D rb;
    public CatController cat;

    bool iscontroll=false;
    bool findcat = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && iscontroll)
        {
            cat.setbat();
            ekey.SetActive(false);
            ui.SetActive(true);
            text.text = "Đúng là tôi đang giữ một cọc,Cậu có thể lấy lại nó nếu như cậu giúp ta tìm lại được con mèo đi lạc của tôi.";
            if (findcat)
            {
                bien.SetActive(false);
                text.text = "Cảm ơn cậu rất nhiều ! Cọc tiền của cậu tôi để đâu đó trong cửa hàng, Hãy vào bên trong và lấy nó .Nhân tiện tôi có nhìn thấy ông Phú Xuyên của cửa hàng LAWSON cầm một cọc.";
            }
        }
    }

    public void CatFind()
    {
        findcat = true;
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
            iscontroll = false;
            ui.SetActive(false);
        }
    }
}
