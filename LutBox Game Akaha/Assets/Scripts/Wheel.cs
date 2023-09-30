using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    public float speed = 1;
    public GameObject Whell;

    public void Start()
    {
       // speed = Random.Range(4f, 4.5f);
    }

    private void Update()
    {
        //Whel();
        if (speed > 0)
        {
            Whell.transform.Rotate(transform.forward * -speed);
            speed -= Time.deltaTime;
        }
    }
    
    public void Whel()
    {

        speed = Random.Range(4f, 4.5f);

    }
}
