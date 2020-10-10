using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    Rigidbody rigidbody;
    float speed = 10f;
    public float rango = 10f;
    public float distanciaEnfrente;
    public GameObject jugador;
    public float distanciaMaxima = 5f;

    public float VelocidadSeguimientoJugador = 3f;                //Velocidad con la que sigue al jugador


    public float rangoDeSeguimiento = 3f;

    public bool estaLibre;


    float x = 0;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        distanciaMaxima = Random.Range(1,8);

        //Debug.DrawRay(transform.position,transform.forward,Color.green);
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, rango))
        {

            if(hit.collider.gameObject.tag == "Player")
            {
                estaLibre = true;
                distanciaEnfrente = distanciaMaxima;
            }
            else if (hit.collider.gameObject.tag == "Muro")
            {
                estaLibre = false;
                distanciaEnfrente = hit.distance;
            }
            else
            {
                estaLibre = true;
                distanciaEnfrente = hit.distance;
            }
            
            Debug.Log(hit.collider.gameObject.name);
           // Debug.Log(distanciaEnfrente);
        }
        else
        {
            distanciaEnfrente = distanciaMaxima;
        }



        if (distanciaEnfrente < distanciaMaxima)
        {
            // rigidbody.MoveRotation(Quaternion.Euler(0,90,0));
            //transform.Rotate(0,180,0);
            //transform.RotateAround(transform.position,new Vector3 (0,-100,0), 100 * Time.deltaTime);
            //transform.rotation = Quaternion.AngleAxis(45, Vector3.up);
           
            
            x += Time.deltaTime * 100;
            transform.rotation = Quaternion.Euler(0, x, 0);

                Debug.Log("Parado");


            
        }
        else if (distanciaEnfrente >= distanciaMaxima)
        {
           
           // transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, speed * Time.deltaTime);
            Debug.Log("Adelante");
            if (CalcularDistancia() <= rangoDeSeguimiento && estaLibre)
            {

                Vector3 relativePos = jugador.transform.position - transform.position;
                Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);

                //transform.RotateAround(transform.position, new Vector3(0, -50, 0), 100 * Time.deltaTime);
                transform.rotation = rotation;
                transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, VelocidadSeguimientoJugador * Time.deltaTime);
               //rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
            }
            else
            {
                rigidbody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
            }

        }









    }

    float CalcularDistancia()
    {
        float distancia = Vector3.Distance(this.transform.position,jugador.transform.position);
        return distancia;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<AtributosJugador>().ChoqueEnemigo();                                  //Metodo del jugador que se activa al colisionar
            this.gameObject.SetActive(false);
        }
    }
}
