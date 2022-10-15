using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D col)
	{
		if(col.GetComponent<IInteractable>() != null)
		{
			col.GetComponent<IInteractable>().Interact();
		}
	}
}
