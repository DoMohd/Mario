using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite Cursor2;
    public GameObject Cursor3;

    public Sprite normalCursor;
    public GameObject clickEffect;
    public float timeBtwSpaw = 0.1f;

    public Texture2D mouseCursorTexture;

    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(mouseCursorTexture, Vector2.zero, CursorMode.Auto);
        rend = GetComponent<SpriteRenderer>();
        Cursor.visible = true ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 curosrPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = curosrPos;
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(Cursor2, transform.position, Quaternion.identity);
            rend.sprite = Cursor2;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            rend.sprite = normalCursor;

        }
    }
}
