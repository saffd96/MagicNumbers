using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    #region Variables

    public Text guessText;
    public Text numberOfTriesText;

    public MagicNumbers magicNumbers;

    #endregion

    #region Unity Lifecycle

    private void Start()
    {
        MagicNumbers magicNumbers = FindObjectOfType<MagicNumbers>();

        guessText.text = $"Game Over! Твоё число - {magicNumbers.guess}";
        numberOfTriesText.text = $"Количество затраченых попыток - {magicNumbers.count}";
    }

    #endregion
}
