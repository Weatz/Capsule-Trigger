using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{

    public Enemy enemy;

    private void OnTriggerEnter(Collider other)
    {
        if (enemy.isActiveAndEnabled)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                gameObject.SetActive(false);
                enemy.Shoot();
            }
        }
    }
}
