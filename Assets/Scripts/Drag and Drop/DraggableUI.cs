using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DraggableUI : MonoBehaviour
{
    public GameObject CorrespondingDraggable;


    private Vector3 dragOffset;

    private Vector3 defaultPos;
    private Vector3 endingPos;
    private Camera cam;

    private RectTransform rectT;
    
    private Sprite spriteImage;
    private bool isDragging;
    private bool isInit;

    private void Start()
    {
        spriteImage = GetComponent<Image>().sprite;
        defaultPos = CorrespondingDraggable.transform.position;
        CorrespondingDraggable.SetActive(false);
        cam = Camera.main;
        rectT = GetComponent<RectTransform>();
    }
    
    
    public void InitDraggableObject()
    {
        isInit = true;

        if (DragNotifier.Instance.canDrag)
        {
            CorrespondingDraggable.SetActive(true);
            CorrespondingDraggable.GetComponent<DraggableOnlyObject>().correspondingSprite.sprite = spriteImage;
            Vector3 screenPos = cam.ScreenToWorldPoint(Input.mousePosition);

            screenPos.z = 0;

            //dragOffset = cam.ScreenToWorldPoint(rectT.position) - screenPos;
            //dragOffset.z = 0;

            CorrespondingDraggable.transform.position = screenPos + dragOffset;
        }
            
    }

    public void OnDragging()
    {
        if (DragNotifier.Instance.canDrag && isInit)
        {
            CorrespondingDraggable.SetActive(true);
            CorrespondingDraggable.GetComponent<DraggableOnlyObject>().correspondingSprite.sprite = spriteImage;
            Vector3 screenPos1 = cam.ScreenToWorldPoint(Input.mousePosition);

            screenPos1.z = 0;

            //dragOffset = cam.ScreenToWorldPoint(rectT.position) - screenPos1;
            //dragOffset.z = 0;

            CorrespondingDraggable.transform.position = screenPos1;
            isInit = false;
        }
        else if(!isInit)
        {
            Vector3 screenPos = cam.ScreenToWorldPoint(Input.mousePosition);
            screenPos.z = 0;
            CorrespondingDraggable.transform.position = screenPos;
            endingPos = CorrespondingDraggable.transform.position;
            //Debug.Log(dragOffset);
        }
        else
        {
            
           //DragNotifier.Instance.ScrollTheScrollBar();
        }
            
       
    }

    public void OnDragEnding()
    {
        
        if (DragNotifier.Instance.canDrag)
        {
            CorrespondingDraggable.GetComponent<DraggableOnlyObject>().AttachTheGameObject(CorrespondingDraggable);
        }

        CorrespondingDraggable.transform.position = endingPos;
        CorrespondingDraggable.SetActive(false );
        
    }

}
