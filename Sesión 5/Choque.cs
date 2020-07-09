using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choque : MonoBehaviour
{
    public AudioSource mordida;

    public int cantPizza;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {
            Debug.Log("Choque con pizza");
            cantPizza++;
            mordida.Play();
        }
    }
}
