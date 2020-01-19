using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSlowMotion : MonoBehaviour
{
    public PlayerManager player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            gameObject.SetActive(false); // Prevent double activation
            SlowMotion.StartSlowMotion();
            player.ActivateLaser();
        }
    }
}
