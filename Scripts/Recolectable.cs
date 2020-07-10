using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public GameObject objeto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Personaje"))
        {
            objeto.SetActive(false);
        }
    }
}
