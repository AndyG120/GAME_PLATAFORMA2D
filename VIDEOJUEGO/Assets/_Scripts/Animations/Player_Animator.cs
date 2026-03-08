using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animator : MonoBehaviour
{
    private Animator _animator;
    private NewInput _newInput;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _newInput = GetComponent<NewInput>();

    }

    // Update is called once per frame
    void Update()
    {
        playerMoveAnim();
    }

    public void playerMoveAnim()
    {
        _animator.SetBool("IsMoving", _newInput.inputX != 0);
    }

}
