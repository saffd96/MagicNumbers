using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public Text label;
    public Text numberOfTries;

    [SerializeField]
    private int min = 1;

    [SerializeField]
    private int max = 1000;

    public int guess;
    public int count = -1;

    [SerializeField]
    private SceneLoader sceneChanger;

    #endregion

    #region Unity Lifecycle

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        label.text = $"Загадай число от {min} до {max}";
        UpdateGuess();
    }

    #endregion

    #region Public Methods

    public void SetLower()
    {
        min = guess;
        UpdateGuess();
    }
    public void SetHigher()
    {
        max = guess;
        UpdateGuess();
    }

    public void CorrectAnswer()
    {
        GameOver();
    }

    #endregion

    #region Private Methods

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        label.text = $"Твое число равно {guess}?";
        count++;
        numberOfTries.text = $"Попыток: {count}";
    }

    private void GameOver()
    {
        sceneChanger.ChangeScene(2);
    }

    #endregion
}
