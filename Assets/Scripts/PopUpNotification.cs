using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.UI;

public class PopUpNotification : MonoBehaviour
{
    public RectTransform rect;
    public Gradient grad;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DoPopup();
        }
        if (Input.GetMouseButtonUp(0))
        {
            DoReversePop();
        }
    }

    void DoPopup()
    {
        //rect.DOAnchorPos(new Vector3(rect.position.x + 100,0),1.5f).SetEase(Ease.OutBounce);
        rect.DOAnchorPosX(rect.position.x + 1000, 1f).SetEase(Ease.InOutQuart);
        GetComponent<Image>().DOGradientColor(grad, 1f).SetEase(Ease.OutBounce);
    }
    void DoReversePop()
    {
        rect.DOAnchorPosX(rect.position.x - 100, 1f).SetEase(Ease.OutBounce);
    }
}
