using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseClickDetection : CustomAction
{
    public override void Execute(float d)
    {
        if (Input.GetMouseButtonDown(0))
        {
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            foreach (var r in results)
            {
                IClickBehaviour c = r.gameObject.GetComponent<IClickBehaviour>();

                if (c != null)
                {
                    c.Click();
                    break;
                }

            }
        }
    }
}
