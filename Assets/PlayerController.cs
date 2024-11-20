using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del enemigo

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtén el movimiento en el eje horizontal
        float movimientoX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

        // Aplica el movimiento en la posición actual
        transform.Translate(movimientoX, 0, 0);
    }
}
