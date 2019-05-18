using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatController : MonoBehaviour
{
    private Vector3 rawPosition;
    private Vector3 hatPosition;
    private float maxWidth;
    public GameObject effect;
    

   

    void Start()
    {
        Vector3 screenPos = new Vector3(Screen.width, 0, 0);
        Vector3 moveWidth = Camera.main.ScreenToWorldPoint(screenPos);

        float hatWidth = GetComponent<Renderer>().bounds.extents.x;
        hatPosition = transform.position;
        maxWidth = moveWidth.x - hatWidth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rawPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        hatPosition = new Vector3(rawPosition.x, hatPosition.y, 0);
        hatPosition.x = Mathf.Clamp(hatPosition.x, -maxWidth, maxWidth);
        GetComponent<Rigidbody2D>().MovePosition(hatPosition);
    }
    //碰撞消失
    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject newwffect = (GameObject)Instantiate(effect, transform.position, effect.transform.rotation);
        newwffect.transform.parent = transform;
        Destroy(collision.gameObject);
        Destroy(newwffect, 1.0f);
    }
}
