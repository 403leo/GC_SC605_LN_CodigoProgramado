using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        //SceneManagement.LoadScene("SC Demo Scene - Village Props");
    }

    // Update is called once per frame
    public void Salir()
    {
        Debug.Log("Salir....");
        Application.Quit();
    }
}
