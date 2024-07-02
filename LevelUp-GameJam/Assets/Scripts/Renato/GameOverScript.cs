using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{

    [SerializeField] private GameObject Game; // Asigna el Panel Game
    [SerializeField] private GameObject GameOver; // Asigna el Panel Game Over
    [SerializeField] private int LionsCount; // Contador de Leones
    [SerializeField] private int CrazyValue; // Barra de Locura
    [SerializeField] private bool LoseBossFinal = false; // Pelea vs BossFinal

    // Funcion para Activar el Panel GameOver
    public void OnGameOver()
    {
        // Verifica si se cumple una de las siguientes Losing Conditions para activar el Panel GamerOver
        if (LionsCount <= 0 || CrazyValue == 50 || LoseBossFinal == true)
        {
            GameOver.SetActive(true);
            Game.SetActive(false); 
        }
    }

    // Funcion para Activar el Panel Game
    public void OffGameOver()
    {
        Game.SetActive(true);
        GameOver.SetActive(false);
    }

    // Funcion para ir al Menu Principal 
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
