using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour
{
    private AudioSource gameAudio;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if player falls below floor then game over
        if (transform.position.y < -25) // let them fall for a bit
        {
            SceneManager.LoadScene("GameOver");

            // reset score on game over
            LevelScoreManager.levelCount = 0;
        }
    }
}
