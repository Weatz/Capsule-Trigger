using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{

    public PlayerManager player;
    public string nextScene; // To change, see how to link scenes in inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            if (nextScene == "")
            {
                player.Win();
            }
            else
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }
}
