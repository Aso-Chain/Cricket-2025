using UnityEngine;

public class ROTATE : MonoBehaviour
{
	private Vector3 angle;

	private void Start()
	{
		angle = base.transform.eulerAngles;
	}

	private void Update()
	{
		angle.y += Time.deltaTime * 100f;
		base.transform.eulerAngles = angle;
	}
}
