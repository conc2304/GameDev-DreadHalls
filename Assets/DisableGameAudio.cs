using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameAudio : MonoBehaviour
{
    private AudioSource gameAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        gameAudio = AudioManager.AudioSources[0];
    }

    // Update is called once per frame
    void Update()
    {
        // pause the whisper game audio
        if (Input.GetAxis("Submit") == 1)
        {
            AudioManager.Pause(gameAudio);
        }
    }
}
