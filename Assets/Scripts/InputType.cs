using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputType : MonoBehaviour
{
    public Transform gameobject;

    void OnTouchDown()
    {
        //Vector3 newPos = new Vector3(10.0f, 2.0f, 0f);
        //gameobject.transform.position = newPos;
        Debug.Log("Down");
    }
    void OnTouchStay()
    {
        Debug.Log("Stay");
    }
    void OnTouchUp()
    {       
        //Vector3 newPos = new Vector3(0.0f, 0.0f, 0.0f);
        //gameobject.transform.position = newPos;
        Debug.Log("Up");
    }
    void OnTouchExit()
    {
        //Vector3 newPos = new Vector3(0.0f, 0.0f, 0.0f);
        //gameobject.transform.position = newPos;
        Debug.Log("Exit");
    }

    void OnTouchMoved()
    {
        //Vector3 newPos = new Vector3(2.0f, 0.0f, 0.0f);
        //gameobject.transform.position = newPos;
        Debug.Log("Exit");
    }
}