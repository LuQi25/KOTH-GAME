using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public CharacterController2D characterController2D;
    public Image fillImage;
    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
