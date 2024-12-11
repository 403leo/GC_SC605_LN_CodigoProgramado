using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject BotonPausa;
    [SerializeField] private GameObject MenuPausaPausa; // Cambiar este nombre si lo deseas
    private bool juegoPausado = false;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        BotonPausa.SetActive(false);
        MenuPausaPausa.SetActive(true); // Uso del nombre correcto
    }

    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        BotonPausa.SetActive(true);
        MenuPausaPausa.SetActive(false); // Uso del nombre correcto
    }

    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar()
    {
        juegoPausado = false;
        Debug.Log("Cerrando Juego");
        Application.Quit();

        //Para un Buen Commit
    }
}
