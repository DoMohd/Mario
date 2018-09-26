using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour {

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnMouseEnter()
    {
        Debug.Log("It is ");

    }
    private void OnMouseDown()
    {
        anim.Play("anim5");
    }
    private void OnMouseExit()
    {
        anim.Play("New State");
    }
}
