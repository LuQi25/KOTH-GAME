using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSecreta : MonoBehaviour
{
    //public SpriteRenderer[] wallElements;
    float alphavalue = 1f;
    public float disappearRate = 1f;
    bool playaerEntered;
    public bool togglewall = false;

    
    void Update()
    {
        if (playaerEntered)
        {
            alphavalue -= Time.deltaTime * disappearRate;

            if (alphavalue<=0)
            {
                alphavalue = 0;
            }

            Destroy(gameObject);
            /*foreach (SpriteRenderer wallItem in wallElements)
            {
                wallItem.color = new Color(wallItem.color.r, wallItem.color.g, wallItem.color.b, alphavalue)
            }*/
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playaerEntered = true;
        }
    }


}
