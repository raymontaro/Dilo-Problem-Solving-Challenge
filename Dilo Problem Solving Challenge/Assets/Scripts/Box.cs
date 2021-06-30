using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{

    Renderer r;
    Collider col;

    Transform player;

    bool isHit = false;
    float time = 3f;
    float timer = 0f;

    private void Start()
    {
        r = GetComponent<Renderer>();
        col = GetComponent<Collider>();

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        r.enabled = !isHit;
        col.enabled = !isHit;

        if(isHit && timer < time)
        {
            timer += Time.deltaTime;
        }
        else if(isHit && timer >= time)
        {
            ChangePosition();

            isHit = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Score.Instance.AddScore(1);

            isHit = true;
            timer = 0f;
        }
    }

    void ChangePosition()
    {
        float posX = Random.Range(-8, 8);
        float posZ = Random.Range(-4, 4);
        Vector3 pos = new Vector3(posX, 0.25f, posZ);

        if(Vector3.Distance(pos, player.position) <= 2f)
        {
            ChangePosition();
        }
        else
        {
            transform.position = pos;
        }
    }
}
