using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour
{
    [SerializeField] private Image Custom1;
    [SerializeField] private Image Custom2;
    [SerializeField] private Image Custom3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (CompareTag("Player"))
        {
            Custom1.enabled = true;
            Custom2.enabled = true;
            Custom3.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (CompareTag("Player"))
        {
            Custom1.enabled = false;
            Custom2.enabled = false;
            Custom3.enabled = false;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
