using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	[SerializeField] AudioClip sfx_diparar;
	public float dmgValue = 4;
	public GameObject throwableObject;
	public Transform attackCheck;
	private Rigidbody2D m_Rigidbody2D;
	public Animator animator;
	public bool canAttack = true;
	public bool isTimeToCheck = false;

	public float SegundosEspera;
	public float Segundostotales;

	public GameObject cam;

	private void Awake()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Start is called before the first frame update
	void Start()
    {
		SegundosEspera = Segundostotales;
    }

    // Update is called once per frame
    void Update()
    {

		SegundosEspera -= Time.deltaTime;

		if (Input.GetKeyDown(KeyCode.B) && canAttack)
		{
			canAttack = false;
			animator.SetBool("IsAttacking", true);
			StartCoroutine(AttackCooldown());
		}

		if (Input.GetKeyDown(KeyCode.Z) && SegundosEspera <= 0)
		{
			AudioSource.PlayClipAtPoint(sfx_diparar, Camera.main.transform.position);
			GameObject throwableWeapon = Instantiate(throwableObject, transform.position + new Vector3(transform.localScale.x * 0.5f,-0.2f), Quaternion.identity) as GameObject; 
			Vector2 direction = new Vector2(transform.localScale.x, 0);
            throwableWeapon.GetComponent<ThrowableWeapon>().direction = direction; 
			throwableWeapon.name = "ThrowableWeapon";
			SegundosEspera = Segundostotales;
		}
	}

	IEnumerator AttackCooldown()
	{
		yield return new WaitForSeconds(0.25f);
		canAttack = true;
	}

	public void DoDashDamage()
	{
		dmgValue = Mathf.Abs(dmgValue);
		Collider2D[] collidersEnemies = Physics2D.OverlapCircleAll(attackCheck.position, 0.9f);
		for (int i = 0; i < collidersEnemies.Length; i++)
		{
			if (collidersEnemies[i].gameObject.tag == "Enemy")
			{
				if (collidersEnemies[i].transform.position.x - transform.position.x < 0)
				{
					dmgValue = -dmgValue;
				}
				collidersEnemies[i].gameObject.SendMessage("ApplyDamage", dmgValue);
				cam.GetComponent<CameraFollow>().ShakeCamera();
			}
		}
	}
}
