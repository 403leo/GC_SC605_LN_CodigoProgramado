using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditWeapon : MonoBehaviour
{
	
    public int attackDamage = 20;
	public int enragedAttackDamage = 40;

	public Vector3 attackOffset;
	public float attackRange = 1f;
	public LayerMask attackMask;

	private GameManager gameManager;

    private void Start()
    {
        // Asegúrate de que el GameManager esté correctamente asignado.
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Attack()
	{
		// Busca al jugador y activa su animación de herida
		/*
		HeroKnight hero = FindObjectOfType<HeroKnight>();
		if (hero != null)
		{
			hero.ActivarAnimacionHerida();
		}
		*/

		// Reduce la vida del jugador usando el GameManager
		if (gameManager != null)
		{
			//gameManager.PerderVida();
		}
		else
		{
			Debug.LogError("GameManager no encontrado.");
		}
	}

	

	/*
	public void EnragedAttack()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
		if (colInfo != null)
		{
			colInfo.GetComponent<GameManager>().PerderVida();
		}
	}
	*/

	void OnDrawGizmosSelected()
	{
		Vector3 pos = transform.position;
		pos += transform.right * attackOffset.x;
		pos += transform.up * attackOffset.y;

		Gizmos.DrawWireSphere(pos, attackRange);
	}
	

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Jugador golpeado por jefe");

			// Activar animación de herida en el protagonista
			HeroKnight hero = other.gameObject.GetComponent<HeroKnight>();
			if (hero != null)
			{
				hero.ActivarAnimacionHerida();
			}

			// Reducir la vida del jugador usando el GameManager
			if (GameManager.Instance != null)
			{
				GameManager.Instance.PerderVida();
			}
			else
			{
				Debug.LogError("GameManager no encontrado.");
			}
		}
	}





	
}
