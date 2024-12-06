/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using Unity.VisualScripting;
//// using GoogleMobileAds.Api;

public class AdIntegrate : Singleton<AdIntegrate>
{
    public int AdInt;

	public bool isInterstitialAvailable;

	public bool isRewardedVideoAvailable;

	public bool isStartedPlayingVideo;

	public bool ReceivedReward;

	private GameObject parent;

	////private BannerView bannerView;

	////private InterstitialAd interstitial;

	////private RewardedAd rewardedAd;

	private AndroidJavaObject objNative;

	private AndroidJavaObject playerActivityContext;

	private bool ReadyForNextRequest = true;

	public bool isRewardedVideoLoaded;

	private bool isRewarededVideoClicked;

	private bool isRewardedVideoFailed;

	private bool isDestroyed;

	public struct AdsData
	{
		public string Banner;
		public string Interstetial;
		public string Reward;
	}
	AdsData adsData;

	string jsonURL = "https://drive.google.com/uc?export=download&id=1FN-JEcwuSDNFUkTHoQo8LLrS8DgZNron";
	private static bool created = false;

	public string BannerId, InterstitialId, RewardId;

	private void Awake()
	{
		////MobileAds.Initialize(initStatus => { });
		////if (!created)
		////{
		////	DontDestroyOnLoad(this.gameObject);
		////	StartCoroutine(GetData(jsonURL));
		////	created = true;
		////}
		////if (objNative == null)
		////{
		////	AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		////}
	}

	IEnumerator GetData(string url)
	{
		UnityWebRequest request = UnityWebRequest.Get(url);
		yield return request.SendWebRequest();
		if (request.isNetworkError)
		{
			GetData(url);
		}
		else
		{
			adsData = JsonUtility.FromJson<AdsData>(request.downloadHandler.text);

			BannerId = adsData.Banner;
			InterstitialId = adsData.Interstetial;
			RewardId = adsData.Reward;
		}
		request.Dispose();

		RequestBanner();
		RequestInterestialAd();
		requestRewardedVideo();
	}

	void Start()
	{
		StartCoroutine(Nextscene());
	}

	IEnumerator Nextscene()
	{
		yield return new WaitForSeconds(3f);

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void RequestBanner()
	{
		////if (bannerView != null)
		////{
		////	bannerView.Destroy();
		////}
		////bannerView = new BannerView(BannerId, AdSize.Banner, AdPosition.Top);
		////bannerView.OnAdLoaded += HandleAdLoaded;
		////bannerView.OnAdFailedToLoad += HandleAdFailedToLoad;
		////bannerView.OnAdOpening += HandleAdOpened;
		////bannerView.OnAdClosed += HandleAdClosed;
		////AdRequest request = new AdRequest.Builder().Build();
		////bannerView.LoadAd(request);
		
	}

	public void HideAd()
	{
		////if (bannerView != null)
		////{
		////	bannerView.Hide();
		////}
	}

    public void ShowAd()
    {
        ////bannerView.Show();
    }

    public void RemoveAds()
	{
		////if (bannerView != null)
		////{
		////	CONTROLLER.receivedAdEvent = false;
		////	bannerView.Destroy();
		////}
	}

	public void RequestInterestialAd()
	{
		////if (interstitial != null)
		////{
		////	interstitial.Destroy();
		////}
		////interstitial = new InterstitialAd(InterstitialId);
		////interstitial.OnAdLoaded += HandleInterstitialLoaded;
		////interstitial.OnAdFailedToLoad += HandleInterstitialFailedToLoad;
		////interstitial.OnAdOpening += HandleInterstitialOpened;
		////interstitial.OnAdClosed += HandleInterstitialClosed;
		////AdRequest request = new AdRequest.Builder().Build();
		////interstitial.LoadAd(request);
	}

	public void DisplayInterestialAd()
	{
		////if (interstitial.IsLoaded())
		////{
		////	interstitial.Show();
		////}
		//else
		//{
		//	RequestInterestialAd();
		//}		
	}

	public bool isRewardedVideoReadyToPlay()
	{
		////if (rewardedAd.IsLoaded())
		////{
		////	return true;
		////}
		return false;
	}

	//private IEnumerator waitForNextRequest()
	//{
	//	ReadyForNextRequest = false;
	//	yield return new WaitForSecondsRealtime(3f);
	//	ReadyForNextRequest = true;
	//}

	public void requestRewardedVideo()
	{
		////this.rewardedAd = new RewardedAd(RewardId);

		////this.rewardedAd.OnAdLoaded += HandleRewardBasedVideoLoaded;
		////this.rewardedAd.OnAdFailedToLoad += HandleRewardBasedVideoFailedToLoad;
		////this.rewardedAd.OnAdOpening += HandleRewardBasedVideoOpened;
		////this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
		////this.rewardedAd.OnUserEarnedReward += HandleRewardBasedVideoRewarded;
		////this.rewardedAd.OnAdClosed += HandleRewardBasedVideoClosed;
		
		////AdRequest request = new AdRequest.Builder().Build();
		////this.rewardedAd.LoadAd(request);

		//StartCoroutine(waitForNextRequest());
	}

	public void showRewardedVideo(int rewardedVideoType, bool fromLoadingScreen = false)
	{
		////ReceivedReward = false;
		////CONTROLLER.rewardedVideoType = rewardedVideoType;
		////if (!fromLoadingScreen)
		////{
		////	parent = GameObject.FindGameObjectWithTag("StoreCanvas");
		////	GameObject gameObject = UnityEngine.Object.Instantiate(Resources.Load("RewardVideoLoadingScreen"), parent.transform) as GameObject;
		////	gameObject.SetActive(value: true);
		////	isStartedPlayingVideo = false;
		////}
  ////      if (CheckForInternet())
  ////      {
  ////          if (rewardedAd.IsLoaded())
  ////          {
  ////              isStartedPlayingVideo = true;
  ////              Screen.sleepTimeout = -1;
  ////              rewardedAd.Show();
  ////          }
  ////          else
  ////          {
  ////              MonoBehaviour.print("Reward based video ad is not ready yet");
  ////              isRewarededVideoClicked = false;
  ////          }
  ////      }
  ////      else
  ////      {
  ////          if (CONTROLLER.pageName == "toss")
  ////          {
  ////              Singleton<TossPageTWO>.instance.Coin.SetActive(value: false);
  ////          }
  ////          isRewarededVideoClicked = false;
  ////      }
    }

	public void shownovideoPopup()
	{
		if (Singleton<Popups>.instance != null)
		{
			Singleton<Popups>.instance.ShowMe();
		}
	}

	public bool hasRewardedVideoAdLoaded()
	{
		////bool result = false;
		////if (rewardedAd.IsLoaded())
		////{
		////	result = true;
		////}
		////else if (isRewardedVideoFailed)
		////{
		////	requestRewardedVideo();
		////}
		////return result;
		return false;

    }

	public void HandleAdLoaded(object sender, EventArgs args)
	{
		CONTROLLER.receivedAdEvent = true;
		MonoBehaviour.print("HandleAdLoaded event received");
		if (SceneManager.GetActiveScene().name == "Preloader" || CONTROLLER.pageName == "landingPage")
		{
			HideAd();
		}
	}

	////public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	////{
	////}

	public void HandleAdOpened(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleAdOpened event received");
	}

	public void HandleAdClosed(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleAdClosed event received");
	}

	public void HandleAdLeftApplication(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleAdLeftApplication event received");
	}

	public void HandleInterstitialLoaded(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleInterstitialLoaded event received");
		isInterstitialAvailable = true;
	}

	////public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	////{
	////	isInterstitialAvailable = false;
	////}

	public void HandleInterstitialOpened(object sender, EventArgs args)
	{
		isInterstitialAvailable = false;
		MonoBehaviour.print("HandleInterstitialOpened event received");
	}

	public void HandleInterstitialClosed(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleInterstitialClosed event received");
		isInterstitialAvailable = false;
		RequestInterestialAd();
	}

	public void HandleInterstitialLeftApplication(object sender, EventArgs args)
	{
		isInterstitialAvailable = false;
		MonoBehaviour.print("HandleInterstitialLeftApplication event received");
	}

	public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
	{
		isRewardedVideoAvailable = true;
		MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
	}

	////public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	////{
	////	isRewardedVideoFailed = true;
	////	isRewarededVideoClicked = false;
	////	isRewardedVideoAvailable = false;
	////	requestRewardedVideo();
	////}

	public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
	}

	////public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
	////{
	////	MonoBehaviour.print(
	////		"HandleRewardedAdFailedToShow event received with message: "
	////						 + args.Message);
	////}

	public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
	{
		MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
		isRewarededVideoClicked = false;
		isRewardedVideoAvailable = false;
		requestRewardedVideo();
		if (Singleton<PauseGameScreen>.instance != null && Singleton<PauseGameScreen>.instance.RVPanel.activeSelf)
		{
			Singleton<RewardedVideoScript>.instance.AutoPlayNoButton();
		}
		if (!(Singleton<GameModel>.instance != null))
		{
			return;
		}
		if (CONTROLLER.rewardedVideoType == 3)
		{
			Time.timeScale = 0f;
		}
		if (ReceivedReward == false)
		{
			Singleton<GameModel>.instance.rebowled = false;
			Time.timeScale = 1f;
			Singleton<GameModel>.instance.DisableRVPopUp();
		}
	}

	////public void HandleRewardBasedVideoRewarded(object sender, Reward args)
	////{
	////	string type = args.Type;
	////	double amount = args.Amount;
	////	MonoBehaviour.print("HandleRewardBasedVideoRewarded event received for " + amount + " " + type + " ---" + CONTROLLER.rewardedVideoType);

	////	ReceivedReward = true;
	////	isRewarededVideoClicked = false;
	////	if (CONTROLLER.rewardedVideoType == 1)
	////	{
	////		double num = amount;
	////		amount = 100.0;
	////		SavePlayerPrefs.SaveUserCoins((int)amount + 50 * FreeRewards.count, 0, (int)amount + 50 * FreeRewards.count);
	////		Singleton<Popups>.instance.ShowCoinRewardPopup(0, (int)amount + 50 * FreeRewards.count);
	////		FreeRewards.count++;
	////		FreeRewards.status = "coins";
	////		Singleton<GameModeTWO>.instance.ResetDetails();
	////		Singleton<PowerUps>.instance.ResetDetails();
	////	}
	////	else if (CONTROLLER.rewardedVideoType == 2)
	////	{
	////		Singleton<TossPageTWO>.instance.RVTossAgainAdCall();
	////	}
	////	else if (CONTROLLER.rewardedVideoType == 3)
	////	{
	////		Singleton<PauseGameScreen>.instance.autoPlayOperations();
	////	}
	////	else if (CONTROLLER.rewardedVideoType == 4)
	////	{
	////		if (CONTROLLER.PlayModeSelected == 6)
	////		{
	////			Singleton<GameModeTWO>.instance.GetExtraTicket();
	////		}
	////		else
	////		{
	////			Singleton<EntryFeesAndRewards>.instance.RVDeduction();
	////		}
	////	}
	////	else if (CONTROLLER.rewardedVideoType == 5)
	////	{
	////		Singleton<GameModeTWO>.instance.GetExtraSpin();
	////	}
	////	else
	////	{
	////		if (CONTROLLER.rewardedVideoType == 6)
	////		{
	////			return;
	////		}
	////		if (CONTROLLER.rewardedVideoType == 7)
	////		{
	////			Singleton<SevenDaysRewards>.instance.DoubleMyRewards();
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 8)
	////		{
	////			Singleton<GameModel>.instance.RebowlLastBall();
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 10)
	////		{
	////			float num2 = 2f;
	////			SavePlayerPrefs.SaveUserTickets((int)num2, 0, (int)num2);
	////			if (Singleton<FreeRewards>.instance != null)
	////			{
	////				Singleton<FreeRewards>.instance.HideMe();
	////			}
	////			if (Singleton<GameModeTWO>.instance != null)
	////			{
	////				Singleton<GameModeTWO>.instance.ResetDetails();
	////			}
	////			if (Singleton<PowerUps>.instance != null)
	////			{
	////				Singleton<PowerUps>.instance.ResetDetails();
	////			}
	////			Singleton<Popups>.instance.ShowCoinRewardPopup(1, (int)num2);
	////			if (Singleton<MultiplayerPage>.instance != null)
	////			{
	////				Singleton<MultiplayerPage>.instance.TicketsCount.text = CONTROLLER.tickets.ToString();
	////			}
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 9)
	////		{
	////			Singleton<FreeRewards>.instance.HideMe();
	////			Singleton<GameModeTWO>.instance.ResetDetails();
	////			Singleton<PowerUps>.instance.ResetDetails();
	////			CONTROLLER.PopupName = "FreeTokens";
	////			Singleton<Popups>.instance.ShowMe();
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 11)
	////		{
	////			Singleton<PowerUps>.instance.ReduceTime(1);
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 12)
	////		{
	////			Singleton<PowerUps>.instance.ReduceTime(2);
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 13)
	////		{
	////			Singleton<PowerUps>.instance.ReduceTime(3);
	////		}
	////		else if (CONTROLLER.rewardedVideoType == 14)
	////		{
	////			Singleton<DailyRewards>.instance.doubleBonus = true;
	////			Singleton<DailyRewards>.instance.ClaimDailyReward();
	////		}
	////	}
	////}

	public void InitAdIntegrate()
	{
		RequestBanner();
		isDestroyed = false;
		RequestInterestialAd();
	}

	public bool CheckForInternet()
	{
		if (objNative != null)
		{
			return objNative.Call<bool>("isInternetOn", new object[0]);
		}
		return true;
	}
*//*    private void Update()
    {
		Debug.Log("000000000000");
    }*//*
}
*/