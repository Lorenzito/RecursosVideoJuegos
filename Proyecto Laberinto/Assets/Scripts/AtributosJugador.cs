using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosJugador : MonoBehaviour
{
    public float vida = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChoqueEnemigo()
    {
        vida--;
    }



}
