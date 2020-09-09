using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rigidbody;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rigidbody.MovePosition(rigidbody.position + Vector2.right * moveX * speed * Time.deltaTime);
        
    }
}
