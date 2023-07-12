using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DraggableOnlyObject : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer correspondingSprite;
    [HideInInspector]
    public bool canAttach;

    [HideInInspector]
    public int requiredPoint=3;

    private Socket socket;

    private void Awake()
    {
        correspondingSprite = GetComponent<SpriteRenderer>();
       
    }

    public void AttachTheGameObject(GameObject go)
    {
        Debug.Log("Trying to attach..");
        if(canAttach&&socket!=null)
        {
            socket.Attach(requiredPoint, go);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collison Entered on" + this.name);

        if (collision.gameObject.GetComponent<Socket>())
        {
            Debug.Log("Collided with socket");
            socket = collision.gameObject.GetComponent<Socket>();
            canAttach = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Socket>())
        {
            socket = null;
            canAttach = false;
        }
    }

    

}
