using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject mainMenuUI;
    public GameObject gameUI;

    private PlayerController playerCtrl;
    private ObjectPool objPool = new ObjectPool();
    private LevelManager lvlManager = new LevelManager();

    private float timer = 0;
    public static int lifes;
    public static int score;
    private bool game;


    void Start() {
        playerCtrl = GetComponent<PlayerController>();

        game = false;

        lvlManager.createObjects();
    }


	void Update () { 
        if (game){
            Game();
        } 
	}


    public void startNewGame() {
        score = 0;
        lifes = 5;
        timer = 0;

        mainMenuUI.active = false;
        gameUI.active = true;

       
        game = true;

    }


    public void gameOver() {
        game = false;

       

        mainMenuUI.active = true;
        gameUI.active = false;

    }


    private void Game() {
        if (lifes <= 0) {
            gameOver();
            return;
        }

        if (timer < 0) {
            lvlManager.createWave();
            timer = Random.RandomRange(2.5f,5);
        }

        timer -= Time.deltaTime;

        GameObject hitedObj = null;

        if (Input.GetMouseButtonDown(0))
        {
             hitedObj = playerCtrl.GetHitedObject();
        }
        

        if (hitedObj.tag == "Box") {
            hitedObj.GetComponent<Controller>().Kill();
            score++;
        } else if (hitedObj.tag == "Circle") {
            lifes--;
        }

    }


   
   


  
}
