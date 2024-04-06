using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScoreManager : MonoBehaviour
{

    public Text levelText;
    public static int levelCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        levelText = GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level: " + Mathf.Round(levelCount);
    }
}
