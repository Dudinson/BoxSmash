using UnityEngine;
using System.Collections;

public class ObjectPool : MonoBehaviour {


    public GameObject[] boxes;
    public GameObject[] sideMoveBoxes;
    public GameObject[] circles;

    private GameObject boxPrefab;
    private GameObject circlePrefab;

  


    public void createBoxes(int boxAmount) {
        GameObject[] boxes = new GameObject[boxAmount];

        for (int i = 0; i < boxAmount; i++) {
            boxes[i] = (GameObject)Instantiate(Resources.Load("Box", typeof(GameObject)), Vector3.zero, Quaternion.identity);
            boxes[i].active = false;
        }

        this.boxes = boxes;
    }

    public void createSideMoveBoxes(int boxAmount)
    {
        GameObject[] boxes = new GameObject[boxAmount];

        for (int i = 0; i < boxAmount; i++)
        {
            boxes[i] = (GameObject)Instantiate(Resources.Load("SideMoveBox", typeof(GameObject)), Vector3.zero, Quaternion.identity);
            boxes[i].active = false;
        }

        this.sideMoveBoxes = boxes;
    }
    public void createCircles(int circleAmount)
    {
        GameObject[] circles = new GameObject[circleAmount];

        for (int i = 0; i < circleAmount; i++)
        {
            circles[i] = (GameObject)Instantiate(Resources.Load("Circle", typeof(GameObject)), Vector3.zero, Quaternion.identity);
            circles[i].active = false;
        }

        this.circles = circles;
    }
}
