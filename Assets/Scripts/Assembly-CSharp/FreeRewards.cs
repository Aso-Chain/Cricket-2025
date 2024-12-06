using UnityEngine;

public class FreeRewards : Singleton<FreeRewards>
{
	public GameObject holder;

	public static int count = 0;

	public static string status = string.Empty;

	private void Start()
	{
		holder.SetActive(value: false);
	}

	public void WatchVideo()
	{
		//Singleton<AdIntegrate>.instance.showRewardedVideo(1); //Pratik
	}

	public void ShowMe(int index)
	{
		if (Application.internetReachability != NetworkReachability.NotReachable)
		{
			switch (index)
			{
			case 1:
				//Singleton<AdIntegrate>.instance.showRewardedVideo(1); //Pratik
				break;
			case 2:
				//Singleton<AdIntegrate>.instance.showRewardedVideo(9);  //Pratik
				break;
			case 3:
				//Singleton<AdIntegrate>.instance.showRewardedVideo(10);  //Pratik
				break;
			}
		}
		else
		{
			CONTROLLER.PopupName = "noInternet";
			Singleton<Popups>.instance.ShowMe();
		}
	}

	public void HideMe()
	{
		holder.SetActive(value: false);
	}
}
