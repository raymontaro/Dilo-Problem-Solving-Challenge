using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public GameObject boxNo;
    public Text boxNoText;

    GameObject instructionPanel;

    public int no;

    private void Start()
    {
        instructionPanel = GameObject.FindGameObjectWithTag("instruction");
    }

    private void Update()
    {
        boxNo.SetActive(instructionPanel.activeSelf);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (no == Score.Instance.currentScore)
            {

                Score.Instance.AddScore(1);

                this.gameObject.SetActive(false);
            }
            else
            {
                this.gameObject.SetActive(false);
                Score.Instance.GameOver();
            }
        }
    }    
}
