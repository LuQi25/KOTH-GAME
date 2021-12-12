using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovible : MonoBehaviour
{
    public GameObject ObjetoMover;
    public Transform StartPoint;
    public Transform EndPoint;

    public float Velocidad;

    private Vector3 MoverHacia;
    
    void Start()
    {
        MoverHacia = EndPoint.position;
    }

    
    void Update()
    {
        ObjetoMover.transform.position = Vector3.MoveTowards(ObjetoMover.transform.position, MoverHacia, Velocidad * Time.deltaTime);

        if (ObjetoMover.transform.position == EndPoint.position)
        {
            MoverHacia = StartPoint.position;
        }
        if (ObjetoMover.transform.position == StartPoint.position)
        {
            MoverHacia = EndPoint.position;
        }
    }
}
