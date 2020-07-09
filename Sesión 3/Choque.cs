using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choque : MonoBehaviour
{
    public Text txt_cantPizza;
    public Text txt_Mensaje;
    public Image img_vida;

    public AudioSource mordida;

    public int cantPizza = 0;
    public int cantVida = 4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {
            Debug.Log("Choque con pizza");
            cantPizza++;
            mordida.Play();
            txt_cantPizza.text = "Objetos: " + cantPizza;
        }
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("Choque con enemigo");
            cantVida = cantVida - 1;
            if (cantVida == 3)
            {
                img_vida.color = Color.yellow;
            }
            else if (cantVida == 2)
            {
                img_vida.color = Color.red;
            }
            else if (cantVida == 1)
            {
                img_vida.color = Color.blue;
            }
            else
            {
                txt_Mensaje.text = "Has muerto";
            }

        }


    }
}
