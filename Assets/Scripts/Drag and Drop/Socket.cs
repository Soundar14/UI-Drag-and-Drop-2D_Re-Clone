using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Socket : MonoBehaviour
{
    public bool CanAttach(int RequiredSocketPoints)
    {
        return Body.Instance.AvailableSocketPoints >= RequiredSocketPoints;
        
    }

    public void Attach(int requiredPoints,GameObject go)
    {
        Debug.Log("Check attachement points");
        if (CanAttach(requiredPoints))
        {
            GameObject inst = Instantiate(go,go.transform.position,Quaternion.identity);
            inst.transform.SetParent(transform,true);
            inst.SetActive(true);            
            //go.transform.position = Vector3.zero;
            Debug.Log("Attached successfully...");
        }
    }
}
