using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
class TextUpdater : MonoBehaviour
{

        private static Text displayText; // Arrastra aquí el componente Text de tu UI en el Inspector

    void Start()
        {
            displayText = GetComponent<Text>();
            UpdateTextDisplay();
        }

    public static void UpdateTextDisplay()
    {
        displayText.text = $"{MoveObject.contador}/5";

    }
}

