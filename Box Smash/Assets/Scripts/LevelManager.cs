using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    ObjectPool objPool = new ObjectPool();

    public void createObjects() {
        objPool.createBoxes(5);
        objPool.createCircles(5);
        objPool.createSideMoveBoxes(5);
    }


    public void createWave() {

        int tmp = Random.Range(1, 5);
        int yStep = 0;

        for (int i = 0; i < tmp; i++)
        {
            yStep += Random.Range(0, 2);

            float tmpVal = Random.value;
            if (tmpVal < 0.1f)
            {
                objPool.circles[i].active = true;
                objPool.circles[i].transform.position = new Vector3(Random.Range(-3, 4), 5 + yStep, 0);
            } else if(tmpVal < 0.2f){
                objPool.sideMoveBoxes[i].active = true;
                objPool.sideMoveBoxes[i].transform.position = new Vector3(0, 5 + yStep, 0);
            }
            else
            {
                objPool.boxes[i].active = true;
                objPool.boxes[i].transform.position = new Vector3(Random.Range(-2, 3), 5 + yStep, 0);
            }

        }

    }



}
