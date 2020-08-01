using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecolectarMonedas : MonoBehaviour
{
    public int CantMonedas = 0;
    public Text txt_CantMonedas;
    public Interfaz interfaz;
    public GameObject panel;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Moneda"))
        {
            CantMonedas++;
            txt_CantMonedas.text = CantMonedas + "";
            collision.enabled = false;
          //collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Peligro"))
        {
             interfaz.PantallaReiniciar();
            //panel.SetActive(true);
        }
    }



    }

