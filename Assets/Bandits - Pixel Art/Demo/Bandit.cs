using UnityEngine;
using System.Collections;

public class Bandit : MonoBehaviour {

    public Transform player; // Referencia al jugador
    public float speed = 2.0f; // Velocidad de movimiento del Bandit
    public float attackRange = 1.5f; // Distancia mínima para atacar
    public bool isFlipped = false;

    private BanditWeapon weapon; // Referencia al script de arma

    private void Start()
    {
        weapon = GetComponent<BanditWeapon>();
    }

    private void Update()
    {
        // Mirar al jugador
        LookAtPlayer();

        // Calcular la distancia al jugador
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        // Perseguir al jugador si está fuera del rango de ataque
        if (distanceToPlayer > attackRange)
        {
            ChasePlayer();
        }
        else
        {
            // Atacar si está en rango
            AttackPlayer();
        }
    }

    private void ChasePlayer()
    {
        // Moverse hacia el jugador
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    private void AttackPlayer()
    {
        if (weapon != null)
        {
            weapon.Attack();
        }
    }


    public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;

		if (transform.position.x > player.position.x && isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;
		}
		else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
		}
	}

	

}
