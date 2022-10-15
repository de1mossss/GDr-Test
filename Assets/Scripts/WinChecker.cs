using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    private Coins[] coins;

	private void Start()
	{
		UserInterface.updateCoinsUI += Win;
	}

	private void Win()
	{
		coins = FindObjectsOfType<Coins>(); //плохо
		if(coins.Length - 1 == 0)
		{
			UserInterface.showWinWindow();
		}
		Debug.Log(coins.Length);
	}
}
