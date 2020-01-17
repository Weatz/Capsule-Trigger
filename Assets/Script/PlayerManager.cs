using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float speed = 5f;
    public float bulletSpeed = 10f;
    public Transform mainCamera;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public GameObject TextStart;
    public GameObject TextWin;


    private Rigidbody playerRigidbody;
    private Transform playerTransform;
    private Animator playerAnimator;
    private LineRenderer playerLaser;

    private bool canShoot;
    private bool playing;
    private bool won;

    private GameObject bullet;

    private Vector3 cameraVector;
    private Vector3 playerForward;
    

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerTransform = GetComponent<Transform>();
        playerAnimator = GetComponent<Animator>();
        playerLaser = GetComponent<LineRenderer>();
        canShoot = false;
        playing = false;

        TextWin.SetActive(false);
        TextStart.SetActive(true);

        cameraVector = new Vector3(0, 2, -10);      // The offset between the player and the camera
        mainCamera.position = playerTransform.position + cameraVector; // Place the camera at the right spot so it follows the player
    }


    void Update()
    {
        if (!playing)
        {
            if (Input.GetMouseButtonDown(0))
            {
                playing = true;
                TextStart.SetActive(false);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (canShoot)
                {
                    Shoot();
                }
            }
        }
        if (won)
        {

            if (Input.GetMouseButtonDown(1))
            {
                won = false;
                SceneManager.LoadScene("MainScene");
            }
        }
    }


    void FixedUpdate()
    {
        if (playing)
        {
            mainCamera.position = playerTransform.position + cameraVector; // Place the camera at the right spot so it follows the player

            playerRigidbody.velocity = new Vector3(speed, playerRigidbody.velocity.y, 0);   // We want to have a constant horizontal speed (x axis) 
        }                                                                              // but we want to let unity calculate gravity and jumps (y axis)
    }


    public void Jump(AnimationClip anim)
    {
        Debug.Log("Jump entered");
        playerRigidbody.AddForce(Vector3.up * 5, ForceMode.Impulse);
        playerAnimator.Play(anim.name);
        ActivateLaser();
    }


    public void ActivateLaser()
    {
        Debug.Log("Laser entered");
        canShoot = true;
        playerLaser.enabled = true;
    }


    public void DisableLaser()
    {
        Debug.Log("DisableLaser");
        canShoot = false;
        playerLaser.enabled = false;

    }


    public void Shoot()
    {
        bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, bulletSpeed, 0), ForceMode.Impulse);

    }

    public void Win()
    {
        playerRigidbody.velocity = new Vector3(0, 0, 0);
        playing = false;
        won = true;
        TextWin.SetActive(true);
    }


}
