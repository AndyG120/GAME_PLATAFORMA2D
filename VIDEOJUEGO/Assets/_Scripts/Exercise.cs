using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    // Creación de variables 
    [Header("Numbers")]
    public int a;
    public int b;
    private int _result;

    // Start is called before the first frame update
    void Start()
    {
        AddNumber(  );
    }

    // Método para realizar la suma de las variables a y b
    public void AddNumber()
    {
        _result = a + b;
        Debug.Log("El resultado de la suma es: " + _result);
        Debug.Log(string.Format("El resultado de {0} + {1} es: {2}", a, b, _result));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
