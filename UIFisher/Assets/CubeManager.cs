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
public class CubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject changingCube;
    public TMP_Text actionCounterText;
    public int actionCounter;

    Vector3 randomPos;
    Vector3 randomScale;
    Color randomColor;
    void RandomPosistion()
    {
        actionCounter++;
        randomPos = new Vector3(Random.Range(0, 3), 2, Random.Range(0, 3));
        transform.position = randomPos;
        actionCounterText.text = "ActionCounter: " + actionCounter;
    }
    void RandomScale()
    {
        actionCounter++;
        randomScale = new Vector3(Random.Range(0.1f, 3.1f), Random.Range(0.1f, 3.1f), Random.Range(0.1f, 3.1f));
        transform.localScale = randomScale;
        actionCounterText.text = "ActionCounter: " + actionCounter;
    }
    void RandomColor()
    {
        actionCounter++;
        int color = Random.Range(1,6);
        switch (color)
        {
            case 1:
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 3:
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 5:
                GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }
        actionCounterText.text = "ActionCounter: " + actionCounter;
    }
    public void OnClickRandomPositionButton()
        {
            RandomPosistion();
        }
    public void OnClickRandomScaleButton()
        {
            RandomScale();
        }
    public void OnClickRandomColorButton()
        {
            RandomColor();
        }
    public void OnClickResetButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    public void OnClickQuitButton()
        {
        Application.Quit();
        }
    void Start()
    {
        actionCounter = 0;
        actionCounterText.text = "ActionCounter: " + actionCounter;
    }
}
