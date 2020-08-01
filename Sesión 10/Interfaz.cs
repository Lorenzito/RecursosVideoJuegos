using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Interfaz : MonoBehaviour
{
    public GameObject panel;


    private void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Panel");
        panel.SetActive(false);
    }
    public void IniciarNivel()
    {
        SceneManager.LoadScene("Nivel 1");

    }

    public void PantallaReiniciar()
    {
        panel.SetActive(true);
    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene("Nivel 1");
    }

}
