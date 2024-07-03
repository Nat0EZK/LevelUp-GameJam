using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhasesChanges : MonoBehaviour
{

    [SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject huntingPanel;
    [SerializeField] private GameObject uiHuntingPanel;

    // Cambiar a la escena Cueva 
    public void ChangeCueva()
    {
        SceneManager.LoadScene("Cueva");
    }

    // Cambiar a la escena Rio
    public void ChangeRio()
    {
        SceneManager.LoadScene("Rio");
    }

    // Cambiar a la escena Oasis
    public void ChangeOasis()
    {
        SceneManager.LoadScene("Oasis");
    }

    // Cambiar al Panel QuickTimeEvent Hunting 
    public void ChangeHunting()
    {
        gamePanel.SetActive(false);
        huntingPanel.SetActive(true);
        uiHuntingPanel.SetActive(true);
    }
}
