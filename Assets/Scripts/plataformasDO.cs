using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformasDO : MonoBehaviour
{

    private PlatformEffector2D effector;
    public float startWaiTime;
    private float waitedTime;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    
    void Update()
    {
        waitedTime = startWaiTime;
        waitedTime -= Time.deltaTime;

        //if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKey("s"))
        //{
            //waitedTime = startWaiTime;
        //}


        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            effector.rotationalOffset = 180f;
            //if (waitedTime<=0)
            //{
            //effector.rotationalOffset = 90f;
            //waitedTime = startWaiTime;
            //}
            //else
            //{
            //waitedTime -= Time.deltaTime;

            //}
        }
        else
        {
            effector.rotationalOffset = 360f;
        }

        //if (Input.GetKey(KeyCode.C))
        //{
            ////effector.rotationalOffset = 270f;
        //}
    }
}
