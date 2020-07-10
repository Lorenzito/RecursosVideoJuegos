using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBala : MonoBehaviour
{
    //Objeto proyectil
    public Rigidbody bala;
    public Transform personaje;
    public float tiempoEntreDisparo;
    private float tiempoDisparo;
    public float balaVelocidad;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time >= tiempoDisparo)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Rigidbody balaPrefab;
                balaPrefab = Instantiate(bala, personaje.position, Quaternion.identity) as Rigidbody;
                balaPrefab.AddForce(personaje.forward * 100 * balaVelocidad);
                tiempoDisparo = Time.time + tiempoEntreDisparo;
            }



        }
    }
}
