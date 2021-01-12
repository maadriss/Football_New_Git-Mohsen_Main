using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TriviaQuizGame;
public class GameManager : MonoBehaviour
{
    public Image[] ballImages = new Image[3];
    
    // Start is called before the first frame update
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
}