using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
   [SerializeField]
    private float amount;

    public float Amount
    {
        get => amount;
        set
        {
            amount = value;
            if (amount <= 0)
            {

                Animator anim = gameObject.GetComponent<Animator>();
                anim.SetTrigger("PlayDie");


                Invoke("PlayDestruction", 1);
                               

                Destroy(gameObject, 2);


            }

        }
    }
    void PlayDestruction()
    {
        ParticleSystem explosion = gameObject.GetComponentInChildren<ParticleSystem>();
        explosion.Play();
    }
}
