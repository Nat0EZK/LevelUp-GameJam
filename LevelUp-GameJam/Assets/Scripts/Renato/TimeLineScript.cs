using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLineScript : MonoBehaviour
{ 
    [SerializeField]  private  Slider slider; // Asigna el Slider desde el Inspector
    [SerializeField]  private float recorrido = 70f; // % Recorrido
    [SerializeField]  private  float duration = 2f; // Duraci�n de la animaci�n en segundos
    [SerializeField]  private  float delay = 1f; // Retraso antes de iniciar la animaci�n

    void Start()
    {

        // Inicia la corrutina para animar el Slider
        StartCoroutine(AnimateSlider());
    }

    IEnumerator AnimateSlider()
    {
        // Espera el retraso especificado antes de iniciar la animaci�n
        yield return new WaitForSeconds(delay);

        float elapsed = 0f;
        float startValue = slider.value;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float newValue = Mathf.Lerp(startValue, recorrido, elapsed / duration);
            slider.value = newValue;
            yield return null;
        } 

        slider.value = recorrido;
    }
}