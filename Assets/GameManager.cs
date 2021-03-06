﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TriviaQuizGame;
using UnityEngine.EventSystems;
using TriviaQuizGame.Types;
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Image[] ballImages = new Image[3];
    public Image[] AiBallImage = new Image[3];
    public Category[] categories = new Category[6];
    public GameObject clickedButton;
    // Start is called before the first frame update
    private void Awake()
    {
        gameManager = this;   
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TQGGameController.tQG.victoryCanvas || TQGGameController.tQG.gameOverCanvas)
        {
            for (int i = 0; i < TQGGameController.tQG.answers.Length; i++)
            {
                if (TQGGameController.tQG.answers[i] == 0)
                {
                    ballImages[i].color = Color.red;
                }
                else { ballImages[i].color = Color.green; }                
            }
        }
    }
    public void AiScoreGenrator()
    {
        for (int i = 0; i < AiBallImage.Length; i++)
        {
            int random = Random.Range(0, 2);
            if (random == 0) {
                AiBallImage[i].color = Color.red;
            }
            else
            {
                AiBallImage[i].color = Color.green;
            }
        }
    }
    /*
     * Method: 
     * 1- Select 3 categories from 6 categories randomly.
     * 2- Put selected to our category grid.
     */
    public void Selected()
    {
        clickedButton = EventSystem.current.currentSelectedGameObject;
    }   
}