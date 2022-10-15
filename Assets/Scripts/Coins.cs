using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour, IInteractable
{
	public void Interact()
	{
		UserInterface.updateCoinsUI();
		Destroy(gameObject);
	}
}
