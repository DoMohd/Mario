using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerSc : fungusSc  {
    private SpriteRenderer rend2;
    int counter2 = 8;

    // Use this for initialization
    void Start()
        {
        rend2 = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
        {
        rend2.color = Color.Lerp(startColor, endColor, value);

    }
    private void OnMouseDown()
    {
        if (ps != null && ps.active != null)
        {
            value += 0.4f;
            if (counter2 >= 0)
            {
                Debug.Log("eeeeeeeeeeeeeeeee" +"  YOU HAVE "+ counter2 +" LEFT");
                counter2--;
            }
            if (counter2 <= 0)
            {
                Debug.Log(" You can not get more!!");
                counter2--;
            }
        }
    }
    private void OnMouseEnter()
    {
        anim.Play("anim2");
        Debug.Log("It is a god one 3<");

    }
    private void OnMouseExit()
    {
        anim.Play("animE2");
    }
}

