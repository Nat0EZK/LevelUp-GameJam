using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;

class MoveObject : MonoBehaviour
{
    [SerializeField] private float[] speeds = new float[] { 5f, 6f, 7f,8f }; // Intervalos de velocidadess 
    [SerializeField] private float timer = 0f; // Contador de Tiempo
    [SerializeField] private bool checkPosition = false; // Verifica si el objeto esta en posicion 
    [SerializeField] public static int contador = 0;
    [SerializeField] private  const int maxContador = 5;

    private void Start()
    {
        
    }



    void Update() {
        float speed = speeds[UnityEngine.Random.Range(0, speeds.Length)]; // Selecciona un intervalo de manera aleatoria
        transform.Translate(-speed * Time.deltaTime, 0, 0);

        timer += Time.deltaTime; // Incrementa el temporizador cada frame
        if (timer > 2f)
        { // Si han pasado 2 segundos
            checkPosition = true; // Activa la verificación de posición
        }

        if (checkPosition)
        {
            // Comprueba si el objeto ha salido de los límites de la cámara
            Vector3 screenPosition = Camera.main.WorldToViewportPoint(transform.position);
            if (screenPosition.x < 0 || screenPosition.x > 1 || screenPosition.y < 0 || screenPosition.y > 1)
            {
                Destroy(gameObject); // Destruye el objeto si está fuera de la pantalla
            
            }
        }
    }

    void OnMouseDown()
    {
        if (tag == "Animal")
        {
            if (contador < maxContador)
            {
                contador++;
                TextUpdater.UpdateTextDisplay(); // Actualiza el texto cada vez que cambia el contador
                Destroy(gameObject);
            }
        }
        else if (tag == "Animal1")
        {
            if (contador > 0)
            {
                contador--;
                TextUpdater.UpdateTextDisplay();
                Destroy(gameObject);
            }
        }
    }
}