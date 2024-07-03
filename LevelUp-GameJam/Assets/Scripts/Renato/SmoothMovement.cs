using System;
using UnityEditor;
using UnityEngine;
class SmoothMovement : MonoBehaviour
{
        public AnimationCurve speedCurve;
        public float duration = 5.0f;
        private float startTime;
    
        void Start() {
            startTime = Time.time;
        }
    
        void Update() {
            float t = (Time.time - startTime) / duration;
            float speed = speedCurve.Evaluate(t);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }

