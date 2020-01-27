using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletManager : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Level.enemyKilled();
            collision.gameObject.SetActive(false);
        }
        Destroy(gameObject);
        if (collision.gameObject.layer == LayerMask.NameToLayer("Hostage"))
        {
            SlowMotion.StopSlowMotion();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }

}
