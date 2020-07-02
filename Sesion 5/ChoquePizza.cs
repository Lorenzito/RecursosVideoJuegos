using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoquePizza : MonoBehaviour
{
    public GameObject pizza;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Personaje"))
        {
            Debug.Log("Choque Personaje");
            pizza.SetActive(false);
        }
    }
}
