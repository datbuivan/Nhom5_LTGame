﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BossParkController : MonoBehaviour
{
    Animator Anm;
    SpriteRenderer sr;
    public EnemiCarController car;
    public GameObject ekey;
    public GameObject ui;
    public TMP_Text text;
    public bool k=false;
    float sl = 3;

    bool iscontroll = false;
    // Start is called before the first frame update
    void Start()
    {
        sl = PlayerPrefs.GetFloat("sl");
        Anm = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && iscontroll)
        {
            ekey.SetActive(false);
            ui.SetActive(true);
            if (sl > 0)
            {
                text.text = "Oh ! Cậu vẫn chưa tìm đủ số cọc tiền ư, hãy thử quay lại và xem xét sung quanh một lần nữa nào .";
            }
            else
            {
                text.text = "Oh ! Cảm ơn NoAh cậu đã tìm lại số tiền bị mất giúp chúng tôi, giườ tôi mang tiền đi đánh Tài Xỉu đây .Tạm biệt cậu .";
                Invoke("setk", 2f);
            }
        }
        if (k) gotoCar();
    }
    void setk()
    {
        k = true;
    }

    public void setSl()
    {
        PlayerPrefs.SetFloat("sl", sl - 1);
        sl = sl - 1;
    }
    private void gotoCar()
    {
        sr.flipX = false;
        Anm.SetBool("walk", true);
        if(transform.position.x< 60.41f)
        {
            transform.Translate(Vector2.right*Time.deltaTime);
        }
        if (transform.position.x > 60.42f)
        {
            car.getCar();
            Invoke("unActive", 0.2f);   
        }
    }
    void unActive()
    {
        gameObject.SetActive(false);
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
