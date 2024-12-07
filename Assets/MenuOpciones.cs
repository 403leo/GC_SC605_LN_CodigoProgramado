using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{

[SerializeField] private AudioMixer audiomixer;

  public void PantallaCompleta(bool pantallaCompleta)
  {
    Screen.fullScreen = pantallaCompleta;
  }

  public void CambiarVolumen(float volumen)
  { 

audiomixer.SetFloat("Volumen", volumen);
  
  }

  public void CambiarCalidad(int index)
  {

QualitySettings.SetQualityLevel(index);
  
  }
}
