//////////////////////////////////////////////////////
// Assignment/Lab/Project: User Interface Assignment
//Name: Ethan Fisher
//Section: 2023FA.SGD.113.2102
//Instructor: Ven Lewis
// Date: 10/11/2023
//////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject changingCube;
    public TMP_Text actionCounterText;
    int actionCounter;


    Vector3 randomPos;
    Vector3 randomScale;
    Color randomColor;
    void RandomPosistion()
    {
        randomPos = new Vector3(Random.Range(0, 3),Random.Range(0, 3),Random.Range(0, 3));
    }
    void RandomScale()
    {
        randomScale = new Vector3(Random.Range(0.1f, 3.1f), Random.Range(0.1f, 3.1f), Random.Range(0.1f, 3.1f));
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        actionCounterText.text = actionCounter.ToString();
    }
}
