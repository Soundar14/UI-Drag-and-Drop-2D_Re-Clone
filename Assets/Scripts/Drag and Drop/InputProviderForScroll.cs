using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputProviderForScroll : EventTrigger
{
    public override void OnDrag(PointerEventData eventData)
    {
        //Debug.Log(eventData.delta);

        Vector2 delta = eventData.delta;

        float value = -delta.x / 10;

        DragNotifier.Instance.scroller.value+= value*Time.deltaTime;

    }
}
