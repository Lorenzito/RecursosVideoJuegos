using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoquePersonaje : MonoBehaviour
{

    public GameObject personajeMalo;
    public int vida = 7;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            Debug.Log("Choque con Bala");
            vida--;
        }

        if(vida <= 0)
        {
            personajeMalo.SetActive(false);
        }
    }
}
