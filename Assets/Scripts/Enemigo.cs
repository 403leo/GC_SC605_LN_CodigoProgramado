using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
	private Animator            m_animator;
	void Start () {
		m_animator = GetComponent<Animator>();
	}
    private void OnCollisionEnter2D(Collision2D other) {
            if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Jugador golpeado");
            m_animator.Play("HeroKnight_Hurt");
            GameManager.Instance.PerderVida();
        }
	}
}
