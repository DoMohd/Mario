﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    public Color startColor = Color.white;
    public Color endColor = Color.white;
    public GameObject ps = null;

    int counter = 8;
    public Animator anim;

    private SpriteRenderer rend;
    [Range(0, 1)]
    public float value;


    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        rend.color = Color.Lerp(startColor, endColor, value);
        
    }
    private void OnMouseDown()
    {
        if (ps != null && ps.active != null)
        {
            value += 0.4f;
            if (counter >= 0)
            {
                Debug.Log("eeeeeeeeeeeeeeeee" +counter);
                counter--;
            }
            if (counter <= 0)
            {
                Debug.Log(" You can not get more" );
            counter--;
            }
        }
    }
    private void OnMouseEnter()
    {
        anim.Play("anim");
        Debug.Log("It is a god one");

    }
    private void OnMouseExit()
    {
        anim.Play("animE");
    }
}
