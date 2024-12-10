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
                
                HeroKnight hero = other.gameObject.GetComponent<HeroKnight>();
                if(hero != null){
                        hero.ActivarAnimacionHerida();
                }

                GameManager.Instance.PerderVida();
                }
    }
}
