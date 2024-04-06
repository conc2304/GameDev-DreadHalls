using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameAudio : MonoBehaviour
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
        // restart the whisper game audio
        if (Input.GetAxis("Submit") == 1)
        {
            AudioManager.Play(gameAudio);
        }
    }
}
