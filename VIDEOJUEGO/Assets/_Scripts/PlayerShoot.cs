using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform starPos;

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started)
        { 
            GameObject bullet = Instantiate(bulletPrefab, starPos.position, starPos.rotation);
            Destroy(bullet, 1f);
        }
    }


}
