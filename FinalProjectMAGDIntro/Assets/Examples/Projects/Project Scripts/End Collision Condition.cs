using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCollisionCondition : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "Player")
		{
			SceneManager.LoadScene("Project 1 End Scene");
		}
	}
}
