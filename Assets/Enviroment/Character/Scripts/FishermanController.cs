using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FishermanController : MonoBehaviour
{
    public GameObject ekey;
    Rigidbody2D rb;
    public GameObject key;
    public GameObject ui;
    public TMP_Text text;
    bool Controll = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Controll)
        {
            ekey.SetActive(false);
            key.SetActive(true);
            ui.SetActive(true);
            text.text = "Ah ! Đúng là ta có nhặt được một cọc, ta đang để nó trong cửa hàng còn chìa khóa ta để rơi nó rồi nhưng ta nhớ nó ở đâu đó chỗ các trang cỏ." +
                "khi vào cửa hàng hãy cẩn thận với những người bảo vệ của cửa hàng,họ khá là hung giữ .";
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
            ui.SetActive(false);
        }
    }
}
