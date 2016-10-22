using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {
    
    public GameObject scoreTextObj;
    Text scoreText;

    void Start()
    {
        scoreText = scoreTextObj.GetComponent<Text>();
    }


    void Update()
    {
        scoreText.text = GameManager.lifes.ToString() ;
    }
}
