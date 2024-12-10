using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{

    [SerializedField] private GameObject BotonPausa;
    [SerializedField] private GameObject MenuPausaPausa;
    private bool  juegoPausado = false;
    // Start is called before the first frame update

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(juegoPausado){
                Reanudar();
            }else{
                Pausa();
            }
        }
    }

    public void Pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        BotonPausa.SetActive(false);
        MenuPausa.SetActive(true);
    }

    public void Reanudar()
    {
juegoPausado = false;
        Time.timeScale = 1f;
        BotonPausa.SetActive(true);
        MenuPausa.SetActive(false);
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
        Debug.Log("Cerrando Juego")
        Application.Quit();
    }
}
