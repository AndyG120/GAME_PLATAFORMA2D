using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorandPause : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public GameObject triangle;


    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeColor();
        ChangePose();
    }

    // Metodo para cambiar de color
    public void ChangeColor()
    {
        _spriteRenderer.color = Color.green;
    }

    public void ChangePose()
    {
        transform.position = triangle.transform.position;
    }

}
