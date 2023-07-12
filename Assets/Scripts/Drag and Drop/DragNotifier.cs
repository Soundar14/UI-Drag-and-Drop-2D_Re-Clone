using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DragNotifier : Singleton<DragNotifier>
{

    public Scrollbar scroller;
    // Start is called before the first frame update
    public bool canDrag;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetCanDrag()
    {
        canDrag = true;
    }
    public void SetCannotDrag()
    {
        canDrag = false;
    }

    public void ScrollTheScrollBar(float value)
    {
        scroller.value = value;
    }


}
