using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    private NewInput _newInput;
    public float speed;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        Stats.score = 0;
        _newInput = GetComponent<NewInput>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
            transform.Translate(Vector3.right * _newInput.inputX * speed * Time.deltaTime);
            //_rb.velocity = new Vector3(_newInput.inputX * speed, _rb.velocity.y, 0);
    }


}
