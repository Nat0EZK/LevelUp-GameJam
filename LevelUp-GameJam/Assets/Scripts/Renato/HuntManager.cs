using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntManager : MonoBehaviour
{
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private GameObject huntingPanel;
    [SerializeField] private GameObject uiHuntingPanel;
    [SerializeField] private GameObject Animal;
    [SerializeField] private GameObject Animal1;


    void Update()
    {
        if (MoveObject.contador == 5)
        {
            gamePanel.SetActive(true);
            huntingPanel.SetActive(false);
            uiHuntingPanel.SetActive(false);
        }

    




    }
}
