using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lutbox : MonoBehaviour
{
    public GameObject[] boxs;

    int ip;
    public GameObject[] prices;
    public int rangeBox = 6;

    public Vector3[] posprices;
    int start;
    public int time;
    public int time2;
    public int restart;
    public int restart2;
   

    private void Update()
    {
        if (start == 2)
        {
            if (0 < restart)
            {
                restart -= restart2;
            }
            if (restart <= 0)
            {
                SceneManager.LoadScene(4);
            }
        }
       
        if (start == 1)
        {
            if (0 < time)
            {
                time -= time2;
            }
        }
        
        switch (rangeBox)
        {
            case (0):
                boxs[1].SetActive(false);
                boxs[2].SetActive(false);
                Instantiate(prices[ip], posprices[0], Quaternion.identity);
                start = 1;
                if(time <= 0)
                {
                    boxs[0].SetActive(false);
                    start = 2;
                }
                break;
            case (1):
                boxs[0].SetActive(false);
                boxs[2].SetActive(false);
                Instantiate(prices[ip], posprices[1], Quaternion.identity);
                //prices[0].SetActive(false);
                //prices[2].SetActive(false);
                start = 1;
                if (time <= 0)
                {
                    boxs[1].SetActive(false);
                    start = 2;
                }
                break;
            case (2):
                boxs[1].SetActive(false);
                boxs[0].SetActive(false);
                Instantiate(prices[ip], posprices[2], Quaternion.identity);
               // prices[1].SetActive(false);
              //  prices[0].SetActive(false);
                start = 1;
                if (time <= 0)
                {
                    boxs[2].SetActive(false);
                    start = 2;
                }
                break;
        }
        
    }

    public void ChooseBox()
    {
        rangeBox = Random.Range(0, 3);
        ip = Random.Range(0, 5);
    }
}
