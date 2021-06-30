using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public LayerMask layerMask;    

    NavMeshAgent nav;
    Camera cam;

    GameObject instruction;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        cam = Camera.main;
        instruction = GameObject.FindGameObjectWithTag("instruction");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && !instruction.activeSelf && !Score.Instance.gameOverPanel.activeSelf && !Score.Instance.winPanel.activeSelf)
        {

            RaycastHit hit;

            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, layerMask))
            {                
                nav.SetDestination(hit.point);
            }
        }
    }
}
