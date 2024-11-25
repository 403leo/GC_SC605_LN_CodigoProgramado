using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void BotonStart()
    {

        SceneManager.LoadScene(1);

}

    // Update is called once per frame
    public void BotonSalir()
    {
        Debug.Log("Salir....");
        Application.Quit();
    }

    // Update is called once per frame
    public void BotonVolverOpciones()
    {
        SceneManager.LoadScene(0);
    }


}

