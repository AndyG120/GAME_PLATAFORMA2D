using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("Inicio el juego");
    }

    public void LoadGame()
    {
        Debug.Log("Cargo el juego");
    }

    public void ExitGame()
        {
            Debug.Log("Salgo del juego");
    }

    public void Options()
    {
        Debug.Log("Abro las opciones del juego");
    }   
}
