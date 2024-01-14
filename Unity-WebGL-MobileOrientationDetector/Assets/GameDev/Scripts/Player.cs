using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public Text txt;

    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray,out hit,100f))
            {
                nav.SetDestination(hit.point + Vector3.up);

                txt.text = hit.point.ToString();
            }

            API.SetScreen(false);
        }
    }
}
