using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void openRepo()
	{
		#if !UNITY_EDITOR
		openWindow("https://github.com/3Gennadius/Unit5_B00139774");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}