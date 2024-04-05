using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveInventory : MonoBehaviour
{
     private RectTransform rectTransform;
    private Vector2 originalPosition;
    private bool isMoved = false;
    public GameObject closeButton;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalPosition = rectTransform.anchoredPosition;
        MoveRectTransformOutOfBounds();
    }



    public void MoveRectTransformToOriginalPosition()
    {
        closeButton.SetActive(true);
        rectTransform.anchoredPosition = originalPosition;
    }

    public void MoveRectTransformOutOfBounds()
    {
        closeButton.SetActive(false);
        Vector2 newPosition = new Vector2(Screen.width * 3f, Screen.height * 3f); // Move it out of bounds
        rectTransform.anchoredPosition = newPosition;
    }

}
