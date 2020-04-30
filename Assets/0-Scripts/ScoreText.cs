using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    private int lastPoint;
    CharacterController characterController = new CharacterController();
    void Start()
    {
        lastPoint = characterController.point;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = characterController.pointsText.ToString();
    }
}
