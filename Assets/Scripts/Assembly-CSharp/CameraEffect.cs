using UnityEngine;

public class CameraEffect : MonoBehaviour
{
	public Material m_Mat;

	public bool m_Enable = true;

	[Range(0.1f, 0.8f)]
	public float m_ThermalHigh = 0.3f;

	[Range(0.1f, 1f)]
	public float m_BlurAmount = 0.5f;

	[Range(0.1f, 1f)]
	public float m_DimensionsX = 0.5f;

	[Range(0.1f, 1f)]
	public float m_DimensionsY = 0.5f;

	private RenderTexture m_RT;

	private void Start()
	{
		m_RT = new RenderTexture(Screen.width, Screen.height, 0);
	}

	private void Update()
	{
		float x = Random.Range(0f, 0.3f);
		float y = Random.Range(0f, 0.3f);
		m_Mat.SetVector("_Rnd", new Vector4(x, y, 0f, 0f));
		m_Mat.SetVector("_Dimensions", new Vector4(m_DimensionsX, m_DimensionsY, 0f, 0f));
		m_Mat.SetFloat("_HotLight", m_ThermalHigh);
		m_Mat.SetFloat("_BlurAmount", m_BlurAmount);
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
		if (m_Enable)
		{
			Graphics.Blit(src, m_RT, m_Mat, 0);
			Graphics.Blit(m_RT, dst, m_Mat, 1);
		}
		else
		{
			Graphics.Blit(src, dst);
		}
	}

	private void OnGUI()
	{
		int num = 320;
		GUI.Box(new Rect(Screen.width / 2 - num / 2, 10f, num, 25f), "Thermal Vision Demo");
	}
}
