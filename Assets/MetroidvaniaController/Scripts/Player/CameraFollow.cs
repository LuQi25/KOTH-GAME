using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public float FollowSpeed = 2f;
	public Transform Target;
	public Vector3 minValues, maxValues;

	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	private Transform camTransform;

	// How long the object should shake for.
	public float shakeDuration = 0f;

	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.1f;
	public float decreaseFactor = 1.0f;

	Vector3 originalPos;

	void Awake()
	{
		Cursor.visible = false;
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}

	void OnEnable()
	{
		originalPos = camTransform.localPosition;
	}

	private void Update()
	{
		Vector3 newPosition = Target.position;
		newPosition.z = -10;
		Vector3 boundPosition = new Vector3(
			Mathf.Clamp(newPosition.x, minValues.x, maxValues.x),
			Mathf.Clamp(newPosition.y, minValues.y, maxValues.y),
			Mathf.Clamp(newPosition.z, minValues.z, maxValues.z));

		transform.position = Vector3.Slerp(transform.position, boundPosition, FollowSpeed * Time.deltaTime);

		

		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= Time.deltaTime * decreaseFactor;
		}
	}

	public void ShakeCamera()
	{
		originalPos = camTransform.localPosition;
		shakeDuration = 0.2f;
	}
}
