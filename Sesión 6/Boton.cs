using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{

    //Asigna la variable text del UI
    public Text txt_objetos;
    public Text txt_Mensaje;
    public Image img_vida;

    //Almacena la cantidad de objetos
    private int cantObjetos = 0;
    private int cantVida = 4;

    //Suma uno a los objetos
    public void AgregarObjetos()
    {
        cantObjetos++;
        txt_objetos.text = "Objetos: " + cantObjetos;
    }

    //Quita vida al personaje
    public void QuitarVida()
    {
        //Reducimos la variable de vida en 1
        cantVida = cantVida - 1;
        //Checamos cuanto vale la vida
        if(cantVida == 3){
            img_vida.color = Color.yellow;
        }
        else if (cantVida == 2){
            img_vida.color = Color.red;
        }
        else if (cantVida == 1){
            img_vida.color = Color.blue;
        }
        else
        {
            txt_Mensaje.text = "Has muerto";
        }
       
    }




}
