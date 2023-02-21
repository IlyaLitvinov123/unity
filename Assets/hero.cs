using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Run()
    {

        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = transform.position + dir * (speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
    }
} 

