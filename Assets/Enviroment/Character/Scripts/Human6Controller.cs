using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Human6Controller : MonoBehaviour
{
    public GameObject ekey;
    Rigidbody2D rb;
    public GameObject chunha;
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
            chunha.GetComponent<Collider2D>().enabled = true;
            ui.SetActive(true);
            text.text = "Cửa hàng đang tạm thời đóng cửa vì ông chủ đang đi câu với những người bạn bên hồ rồi .Anh có thể đi đến hồ để hỏi ông ấy .";
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
