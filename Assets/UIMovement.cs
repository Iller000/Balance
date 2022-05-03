using System;
using UnityEngine;
using UnityEngine.UI;

public class UIMovement : MonoBehaviour
{
    [SerializeField] Button left;

    void Awake()
    {
        // left.OnPointerDown();
    }
 
    public void LeftDown()
    {
        
    }

    Vector3 mousePosDown;
    bool isMouseDown;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosDown = Input.mousePosition;
            isMouseDown = true;
        }

        if (isMouseDown)
        {
            Vector3 movment = Input.mousePosition - mousePosDown;
        }


        if (Input.GetMouseButtonUp(0)) 
            isMouseDown = false; 

    }
}
