using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeWaves : MonoBehaviour
{
    [SerializeField]
    private Life playerLife;

    [SerializeField]
    private Life baseLife;

    private void Awake()
    {
        playerLife.OnDeath.AddListener(CheckLoseCondition);
        baseLife.OnDeath.AddListener(CheckLoseCondition);


        EnemyManager.SharedInstance.OnEnemyChanged.AddListener(CheckWinCondiction);
        WaveManager.SharedInstance.onWaveChanged.AddListener(CheckWinCondiction);

    }

    void CheckLoseCondition()
    {
      
        SceneManager.LoadScene("LooseScene");

    }

    void CheckWinCondiction()
    {
        //GANAR
        if (EnemyManager.SharedInstance.EnemyCount <= 0 && WaveManager.SharedInstance.WavesCount <= 0)
        {
            SceneManager.LoadScene("WinScene 1");

        }
    }
}
