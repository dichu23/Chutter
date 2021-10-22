using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{

    public static EnemyManager SharedInstance;

    private List<Enemy> enemies;

    public int EnemyCount
    {
        get => enemies.Count;
    }

    public UnityEvent OnEnemyChanged;


    private void Awake()
    {
        if (SharedInstance == null)
        {
            SharedInstance = this;
            enemies = new List<Enemy>();
        }

        else
        {
            Destroy(this);
        }
    }

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
        OnEnemyChanged.Invoke();
    }

    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        OnEnemyChanged.Invoke();
    }

}
