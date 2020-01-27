using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMananger : MonoBehaviour
{

    public Text bulletCounter;
    public GameObject bulletImages;

    private int maxBullets;
     
    // Start is called before the first frame update
    void Start()
    {
        maxBullets = 5; // For now only one weapon with 5 bullets in loader
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetNumberofBullets(int nbOfBulletsLeft)
    {
        if(nbOfBulletsLeft > 5 || nbOfBulletsLeft < 0)
        {
            return;
        }

        bulletCounter.text = nbOfBulletsLeft + "/" + maxBullets;
        for (int i = 0; i < maxBullets; i++)
        {
            if(i < nbOfBulletsLeft)
            {
                bulletImages.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                bulletImages.transform.GetChild(i).gameObject.SetActive(false);
            }
        }



    }

}
