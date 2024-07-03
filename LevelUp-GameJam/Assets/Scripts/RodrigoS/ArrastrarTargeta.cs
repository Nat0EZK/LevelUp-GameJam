using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ArrastrarTargeta : MonoBehaviour
{
    public float maxPosY = 5f;
    public Animator animator;
    private bool isDragging = false;
    private Vector2 startMousePos;
    private Vector2 startRectPos;
    private Vector2 originalPosition;
    private ContadorLeones contL;
    

    void Start()
    {
        originalPosition = transform.position;
        contL = GetComponentInParent<ContadorLeones>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                startMousePos = mousePos;
                startRectPos = transform.position;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isDragging)
            {
                isDragging = false;

                if (transform.position.y >= originalPosition.y + maxPosY){
                    if (animator != null)
                    {
                        if(tag == "Inteligente"){
                            //contL.AumentoL();
                            animator.SetTrigger("Decision");
                        }else if(tag == "Loco"){
                            //contL.RestaL();
                            animator.SetTrigger("Decision");
                        }
                    }
                }
                else
                {
                    transform.position = originalPosition;
                }
            }
        }

        if (isDragging)
        {
            Vector2 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 offset = currentMousePos - startMousePos;
            float newYPos = startRectPos.y + offset.y;

            float clampedYPos = Mathf.Clamp(newYPos, startRectPos.y, startRectPos.y + maxPosY);

            transform.position = new Vector2(transform.position.x, clampedYPos);
        }
    }

    
}
   
