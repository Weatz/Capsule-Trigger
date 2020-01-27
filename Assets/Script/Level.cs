using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public GameObject player;

    private static PlayerManager playerManager;
    private static Transform playerTransform;
    private static int numberOfEnemies = 0;

    void Start()
    {
        playerManager = player.GetComponent<PlayerManager>();
    }

    public static void setNumberOfEnemies(int number)
    {
        numberOfEnemies = number;
    }

    public static void enemyKilled()
    {
        numberOfEnemies--;
        if (numberOfEnemies == 0)
        {
            playerManager.DisableLaser();
            SlowMotion.StopSlowMotion();
            playerManager.Reload();
        }
    }


}
