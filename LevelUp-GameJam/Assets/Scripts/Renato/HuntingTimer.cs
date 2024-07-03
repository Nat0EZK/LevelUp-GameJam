using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

class HuntingTimer : MonoBehaviour
{
    
        [SerializeField] private Text countdownText; // Referencia al componente de texto
        [SerializeField] private GameObject gamePanel; // Referencia al GameObject GamePanel
        [SerializeField] private GameObject huntingPanel; // Referencia al GameObject huntingPanel
        [SerializeField] private GameObject uiHuntingPanel; // Referencia al GameObject uiHuntingPanel
        [SerializeField] private GameObject buttonHunting; // Referencia al GameObject uiHuntingPanel
        [SerializeField] private float countdown = 10.0f; // Tiempo inicial del contador
    
        void Update()
        {
            if (countdown > 0 && uiHuntingPanel.activeSelf)
            {
                countdown -= Time.deltaTime; // Disminuye el contador cada segundo
                countdownText.text = Mathf.Ceil(countdown).ToString(); // Actualiza el texto mostrado
            }
            else if (countdown <= 0)
            {
                
                huntingPanel.SetActive(false); // Desactiva el GameObject
                uiHuntingPanel.SetActive(false); // Desactiva el GameObject
                gamePanel.SetActive(true); // Desactiva el GameObject
                buttonHunting.SetActive(false); // Desactiva el GameObject
        }
        }
 }

