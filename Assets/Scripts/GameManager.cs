using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
	public HUD hud;

    public int PuntosTotales {get; private set;}

	private int vidas = 3;

    

	// NUEVOS ATRIBUTOS	
	/*
	[Serializable]
        public class DamageEvent : UnityEvent<Damager, GameManager>
        { }
	[Serializable]
        public class HealEvent : UnityEvent<int, GameManager>
        { }

	protected bool m_Invulnerable;
	protected int m_CurrentHealth;
    protected Vector2 m_DamageDirection;
    protected bool m_ResetHealthOnSceneReload;
	public DamageEvent OnTakeDamage;
	public DamageEvent OnDie;
    public HealEvent OnGainHealth;
	*/
	/*
	public int CurrentHealth
        {
            get { return m_CurrentHealth; }
    	}
	*/
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Cuidado! Mas de un GameManager en escena.");
        }
    }

    public void SumarPuntos(int puntosASumar)
    {
        PuntosTotales += puntosASumar;
		hud.ActualizarPuntos(PuntosTotales);
    }

	/*
	public void EnableInvulnerability(bool ignoreTimer = false)
        {
            m_Invulnerable = true;
            //technically don't ignore timer, just set it to an insanly big number. Allow to avoid to add more test & special case.
            m_InulnerabilityTimer = ignoreTimer ? float.MaxValue : invulnerabilityDuration;
        }
	*/
	public void PerderVida() {
	//public void PerderVida(Damager damager, bool ignoreInvincible = false) {
		vidas -= 1;
		if(vidas == 0)
		{
			// Reiniciamos el nivel.
			SceneManager.LoadScene(0);
		}
		/*
		if ((m_Invulnerable && !ignoreInvincible) || m_CurrentHealth <= 0)
                return;

            //we can reach that point if the damager was one that was ignoring invincible state.
            //We still want the callback that we were hit, but not the damage to be removed from health.
            if (!m_Invulnerable)
            {
                m_CurrentHealth -= damager.damage;
                OnHealthSet.Invoke(this);
            }

            m_DamageDirection = transform.position + (Vector3)centreOffset - damager.transform.position;

            OnTakeDamage.Invoke(damager, this);

            if (m_CurrentHealth <= 0)
            {
                OnDie.Invoke(damager, this);
                m_ResetHealthOnSceneReload = true;
                EnableInvulnerability();
                if (disableOnDeath) gameObject.SetActive(false);
            }
			*/



		hud.DesactivarVida(vidas);
	}

	public bool RecuperarVida() {
		if (vidas == 3)
		{
			return false;
		}

		hud.ActivarVida(vidas);
		vidas += 1;
		return true;
	}
}
