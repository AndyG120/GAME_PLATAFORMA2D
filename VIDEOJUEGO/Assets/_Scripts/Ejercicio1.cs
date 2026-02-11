using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    public GameObject circle;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeColor();
        Position();

    }

    // Update is called once per frame
    public void ChangeColor()
    {
        _spriteRenderer.color = Color.red;
    }

    public void Position()
    {
        x= circle.transform.position.x;
        y = circle.transform.position.y;
        z = circle.transform.position.z;

        transform.position = circle.transform.position;
        Debug.Log(string.Format("La posición del circulo es de x:{0}  y:{1} z:{2}  -  El color del circulo es rojo", x, y, z));
    }
}
