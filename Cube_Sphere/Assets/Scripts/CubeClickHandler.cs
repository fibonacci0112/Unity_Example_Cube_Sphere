using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeClickHandler : MonoBehaviour
{
    private bool clickColorActive;
    private bool clickMoveActive;
    private bool isDraggable;

    void Update()
    {
        if (isDraggable)
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);            //Casts a ray from Camera to Mouse position
            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit))                        //if casted ray hits the cube
            {
                transform.position = new Vector3(hit.point.x, transform.position.y, transform.position.z);
                transform.position = new Vector3(transform.position.x, hit.point.y, transform.position.z);
                                                                            //sets Cube's x and y axis to Mouse position
            }
        }
    }

    void OnMouseDown()                                                      // is executed if cube is clicked
    {
        if (clickColorActive)
        {
            this.GetComponent<Renderer>().material.color = RandomColor();   // sets material color to random color
        }
        if (clickMoveActive)
        {
            isDraggable = true;                                             // lets Update() Code run
        }
    }

    void OnMouseUp()
    {
        isDraggable = false;                                                // stops running Update() Code
    }

    Color RandomColor()                                                     // Generates a random color
    {
        return new Color(Random.value, Random.value, Random.value);     
    }

    public void ToggleOneChanged(bool newVal)                               //if Toggle is changed
    {
        clickColorActive = newVal;
    }

    public void ToggleTwoChanged(bool newVal)
    {
        clickMoveActive = newVal;
    }
}
