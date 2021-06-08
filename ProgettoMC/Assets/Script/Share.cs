using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Share : MonoBehaviour
{
	public Button shareButton;

	private bool isFocus = false;

	private string shareSubject, shareMessage;
	private bool isProcessing = false;
	private string screenshotName;
	string timer;

	void Start()
	{
		shareButton.onClick.AddListener(OnShareButtonClick);
	}


	void OnApplicationFocus(bool focus)
	{
		isFocus = focus;
	}

	public void OnShareButtonClick()
	{
		timer = Timer.minutes + ":" + Timer.seconds;
		Debug.Log("1");
		screenshotName = "Funziona.png";
		shareSubject = "I challenge you to beat my time in The Cursed";
		shareMessage = "I challenge you to beat my time in The Cursed.\n " +
		"TIME:" + timer;

		ShareScreenshot();
	}


	private void ShareScreenshot()
	{
		Debug.Log("2");

#if UNITY_ANDROID
		if (!isProcessing)
		{
			Debug.Log("3");
			StartCoroutine(ShareScreenshotInAnroid());
		}

#else
		Debug.Log("No sharing set up for this platform.");
#endif
	}



#if UNITY_ANDROID
	public IEnumerator ShareScreenshotInAnroid()
	{
		Debug.Log("4");
		isProcessing = true;
		// wait for graphics to render
		yield return new WaitForEndOfFrame();
		Debug.Log("5");
		string screenShotPath = Application.persistentDataPath + "/" + screenshotName;
		ScreenCapture.CaptureScreenshot(screenshotName, 1);
		Debug.Log(screenShotPath);
		yield return new WaitForSeconds(0.5f);

		if (!Application.isEditor)
		{
			Debug.Log("6");
			//current activity context
			AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

			//Create intent for action send
			AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
			AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
			intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));


			//create file object of the screenshot captured
			AndroidJavaObject fileObject = new AndroidJavaObject("java.io.File", screenShotPath);

			//create FileProvider class object
			AndroidJavaClass fileProviderClass = new AndroidJavaClass("android.support.v4.content.FileProvider");

			object[] providerParams = new object[3];
			providerParams[0] = currentActivity;
			providerParams[1] = "com.EngmaGames.TheCursed.provider";
			providerParams[2] = fileObject;

			//instead of parsing the uri, will get the uri from file using FileProvider
			AndroidJavaObject uriObject = fileProviderClass.CallStatic<AndroidJavaObject>("getUriForFile", providerParams);

			//put image and string extra
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
			intentObject.Call<AndroidJavaObject>("setType", "image/png");
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), shareSubject);
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareMessage);

			//additionally grant permission to read the uri
			intentObject.Call<AndroidJavaObject>("addFlags", intentClass.GetStatic<int>("FLAG_GRANT_READ_URI_PERMISSION"));

			AndroidJavaObject chooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, "Share your high score");
			currentActivity.Call("startActivity", chooser);
			Debug.Log("7");
		}

		yield return new WaitUntil(() => isFocus);
		isProcessing = false;
	}
#endif
}