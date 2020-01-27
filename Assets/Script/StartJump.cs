using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartJump : MonoBehaviour
{

    public PlayerManager player;
    public AnimationClip anim;
    public float jumpForce;
    public int numberOfEnemies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            gameObject.SetActive(false);
            Level.setNumberOfEnemies(numberOfEnemies);
            player.Jump(anim, jumpForce);
        }
    }
}
