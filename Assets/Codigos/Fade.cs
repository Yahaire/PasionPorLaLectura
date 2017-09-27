using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour
{
		public void FadeMe() {
			StartCoroutine (DoFade());
		}

		IEnumerator DoFade()
		{
			CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
			while (canvasGroup.alpha>0)
			{
			//canvasGroup.alpha -= Time.deltaTime / 2;
			canvasGroup.alpha = 0;
			yield return null;
		}
			canvasGroup.interactable = false;
			yield return null;
		}

	public void ExitMenu()
	{
		//Canvas.enabled = false;
	}
		
}