using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasPasables : MonoBehaviour
{
    private GameObject Platform;
    [SerializeField] private CapsuleCollider2D playercollider;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (Platform != null)
            {
                StartCoroutine(DisableCollision());
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            Platform = collision.gameObject;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            Platform = null;
        }
    }

    private IEnumerator DisableCollision()
    {
        BoxCollider2D platformCollider = Platform.GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(playercollider, platformCollider);
        yield return new WaitForSeconds(0.25f);
        Physics2D.IgnoreCollision(playercollider, platformCollider, false);
    }

}
