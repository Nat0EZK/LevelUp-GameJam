using System;
using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

#if UNITY_EDITOR
#endif
class KeyManager : MonoBehaviour
{
    public enum KeyAction
    {
        None,
        KeyA,
        KeyS,
        KeyW,
        KeyD,
        KeySpace
    }

    public KeyAction keyAction;
    public GameObject keyGameObject;

    private float timer = 0f; // Temporizador
    private bool timerActive = true; // Bandera para controlar el temporizador

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.0f && timerActive) // Si han pasado 2 segundos y el temporizador está activo
        {
            StartCoroutine(DestroyGameObjectAfterDelay());
            timerActive = false; // Desactivar el temporizador para no reiniciar la corutina
        }
    

   

        if (keyGameObject != null && timerActive)
        {
            switch (keyAction)
            {
                case KeyAction.KeyA:
                    HandleKey(KeyCode.A);
                    break;
                case KeyAction.KeyS:
                    HandleKey(KeyCode.S);
                    break;
                case KeyAction.KeyW:
                    HandleKey(KeyCode.W);
                    break;
                case KeyAction.KeyD:
                    HandleKey(KeyCode.D);
                    break;
                case KeyAction.KeySpace:
                    HandleKey(KeyCode.Space);
                    break;
            }
        }
    }

    // Método para manejar la lógica común de las teclas
    void HandleKey(KeyCode key)
    {
        if (Input.GetKeyDown(key))
        {
            Destroy(gameObject); // Destruye inmediatamente el GameObject
            timer = 0f; // Reiniciar el temporizador
            timerActive = true; // Activar el temporizador
            
        }
    }

    IEnumerator DestroyGameObjectAfterDelay()
    {
        Destroy(gameObject);
        yield return new WaitForSeconds(1); 
                                            
    }


#if UNITY_EDITOR
    [CustomEditor(typeof(KeyManager))]
    public class KeyManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            KeyManager script = (KeyManager)target;

            // Enum popup
            script.keyAction = (KeyManager.KeyAction)EditorGUILayout.EnumPopup("Key Action", script.keyAction);

            // Mostrar GameObject solo si el enum no es None
            if (script.keyAction != KeyManager.KeyAction.None)
            {
                EditorGUILayout.PropertyField(serializedObject.FindProperty("keyGameObject"), new GUIContent("Key GameObject"));
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}