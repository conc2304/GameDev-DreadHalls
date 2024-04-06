using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour
{

	private AudioSource pickupSoundSource;
	void Awake()
	{
		pickupSoundSource = AudioManager.AudioSources[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.gameObject.tag == "Pickup")
		{
			AudioManager.Play(pickupSoundSource);

			SceneManager.LoadScene("Play");
			// increase the level count
			LevelScoreManager.levelCount += 1;
		}
	}
}
