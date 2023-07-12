using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputProviderForScroll : EventTrigger
{
    public float inputStrength = 0.5f;
    public override void OnDrag(PointerEventData eventData)
    {
        //Debug.Log(eventData.delta);

        Vector2 delta = eventData.delta;

        float value = -delta.x / 20;

        DragNotifier.Instance.scroller.value+= value*Time.deltaTime*inputStrength;

    }
}
