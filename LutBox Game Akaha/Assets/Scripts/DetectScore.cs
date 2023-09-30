using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScore : MonoBehaviour
{
    public float score;
    public float lol;

   public void LoL()
    {
        lol = Random.Range(4f, 4.5f);
    }

    private void Update()
    {
        if (lol > 0f)
        {
            lol -= Time.deltaTime;
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "minus")
        {
            score -= 1f;
        }
        if (other.tag == "almir")
        {
            score += 5f;
        }
        if (other.tag == "plus")
        {
            score += 1f;
        }
        if (other.tag == "plus3")
        {
            score += 3f;
        }
        if (other.tag == "minus3")
        {           
            score -= 10f;                
            
        }
    }

}
