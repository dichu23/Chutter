using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Tooltip("Cantidad de puntos por derrotar al enemy")]
    public int pointsAmount = 10;


    private void Awake()
    {
        var life = GetComponent<Life>(); //var or Life, same
        life.OnDeath.AddListener(DestroyEnemy);
    }


    private void Start()
    {
        EnemyManager.SharedInstance.AddEnemy(this);
    }

    private void DestroyEnemy()
    {


        Animator anim = gameObject.GetComponent<Animator>();
        anim.SetTrigger("PlayDie");


        Invoke("PlayDestruction", 1);


        Destroy(gameObject, 2);

        EnemyManager.SharedInstance.RemoveEnemy(this);
        ScoreManager.SharedInstance.Amount += pointsAmount;
    }

    private void OnDestroy()
    { 

        var life = GetComponent<Life>();
        life.OnDeath.RemoveListener(DestroyEnemy);
    }


    void PlayDestruction()
    {
        ParticleSystem explosion = gameObject.GetComponentInChildren<ParticleSystem>();
        explosion.Play();
    }
}
