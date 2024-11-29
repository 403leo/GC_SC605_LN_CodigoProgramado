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
        if (gameManager != null)
        {
            gameManager.PerderVida();
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
	

	private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        Attack(); // Llama a Attack cuando el jugador entre en el rango del arma.
    }
}

	
}
