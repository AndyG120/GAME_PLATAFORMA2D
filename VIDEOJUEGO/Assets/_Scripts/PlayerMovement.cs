using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    private NewInput _newInput;
    public float speed;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        Stats.score = 0;
        _newInput = GetComponent<NewInput>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
            //transform.Translate(Vector3.right * _newInput.inputX * speed * Time.deltaTime);
            _rb.velocity = new Vector3(_newInput.inputX * speed, _rb.velocity.y, 0);
            Flip();
    }

    public void Flip()
        {
        if (_newInput.inputX > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (_newInput.inputX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
