using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("PlayerKilled");
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SlowMotion.StopSlowMotion();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //Destroy(gameObject);
    }
}
