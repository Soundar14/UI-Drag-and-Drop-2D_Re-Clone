using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : Singleton<Body>
{
    private int socketPoints=6;
    public int AvailableSocketPoints
    {
        get { return socketPoints; }
    }
}
