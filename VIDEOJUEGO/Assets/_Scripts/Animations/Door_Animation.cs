using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Animation : MonoBehaviour
{
    public Animator _anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DoorAnim();
    }

    public void DoorAnim()
    {
        if (Input.GetKeyDown(KeyCode.R))
            _anim.SetTrigger("Anim");
    }
}
