using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    


    public void Nivel1(){
        SceneManager.LoadScene(0);
    }

    public void Nivel2() {
        SceneManager.LoadScene(1);
    }
}
