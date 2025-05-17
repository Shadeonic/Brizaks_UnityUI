using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour, IBeginDragHandler,
    IDragHandler, IEndDragHandler {
    private RectTransform rectTransform;
    public Canvas canva;
    private CanvasGroup canvasGroup;
    public ObjectScript objectScript;

    public ImageScript imageScript;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    //Kad sāk vilkt
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Input.GetMouseButton(0) && Input.GetMouseButton(2) == false)
        {
            objectScript.lastDragged = null;
            Debug.Log("Begin Drag: " + gameObject.name);
            canvasGroup.alpha = 0.6f;
            rectTransform.SetSiblingIndex(50);

        }
    }
    //Vilkšanas laikā
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging: " + gameObject.name);
        Vector2 mousePosition = 
            new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        mousePosition.x = Mathf.Clamp(
            mousePosition.x, 0 + rectTransform.rect.width/2,
            Screen.width - rectTransform.rect.width/2);

        mousePosition.y = Mathf.Clamp(
            mousePosition.y, 0 + rectTransform.rect.height / 2,
            Screen.height - rectTransform.rect.height / 2);

        transform.position = mousePosition;
    }
    //Uz vilkšanas beigām
    public void OnEndDrag(PointerEventData eventData) {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Dragging ended: " + gameObject.name);
            objectScript.lastDragged = eventData.pointerDrag;
            canvasGroup.alpha = 1f;
            //Atjaunina slaideri
            imageScript.UpdateSliders();
        }
    }
}
