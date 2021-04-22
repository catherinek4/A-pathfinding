using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    public LayerMask hitLayers;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            RaycastHit hit; //Stores the position where the ray hits
            if(Physics.Raycast(ray, out hit, Mathf.Infinity, hitLayers))
            {
                transform.position = hit.point;
            }
        }
    }
}
