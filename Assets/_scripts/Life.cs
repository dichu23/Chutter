using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
   [SerializeField]
    private float amount;

    public float maximiumLife = 100f;


    public UnityEvent OnDeath;

    public float Amount
    {
        get => amount;
        set
        {
            amount = value;
            if (amount <= 0)
            {
                OnDeath.Invoke();
               
            }

        }
    }

    private void Awake()
    {
        amount = maximiumLife;
    }

}
