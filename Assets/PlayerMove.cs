using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    public float speed;
    public Animator animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float ud = Input.GetAxis("UpDiagonal");
        float dd = Input.GetAxis("DownDiagonal");
        move = new Vector2(h + ud + dd, v + Mathf.Abs(ud) - Mathf.Abs(dd));
    }
    private void FixedUpdate()
    {
        Vector2 display = rb.velocity = move.normalized * speed * Time.deltaTime;        
        animator.SetFloat("x", display.normalized.x);
        animator.SetFloat("y", display.normalized.y);
    }
}
