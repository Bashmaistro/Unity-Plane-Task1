using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyplanemovement : MonoBehaviour
{
    private Vector3 movementDirection;
    private float speed;
    private Renderer enemyRenderer;
    public float visibleDistance = 10f; 

    private Vector3 spawnPosition;

    void Start()
    {
        
        movementDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-0.5f, 0.5f),
            Random.Range(-1f, 1f)
        ).normalized;

        speed = Random.Range(5f, 15f);

        spawnPosition = transform.position;

        
        enemyRenderer = GetComponent<Renderer>();
        enemyRenderer.enabled = false;
    }

    void Update()
    {
       
        transform.Translate(movementDirection * speed * Time.deltaTime);

        
        float distanceFromSpawn = Vector3.Distance(spawnPosition, transform.position);

        
        if (distanceFromSpawn >= visibleDistance)
        {
            enemyRenderer.enabled = true;
        }
    }
}
