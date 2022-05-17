/** 
 * Allows the player to choose the difficulty
 * Author: Eric Tran
 * Version: 5/17/2022
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    public int difficulty;

    private Button button;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + "was clicked");
        gameManager.StartGame(difficulty);
    }
}
