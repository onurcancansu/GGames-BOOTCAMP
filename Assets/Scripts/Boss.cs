using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boss : MonoBehaviour
{
    private const double V = 2.85f;
    public GameObject bossPrefab;
    
    public Vector3 size;
    public Time time;
    public Vector3 spawnPosition;


    void Start()
    {
        spawnPosition = new Vector3(0, 0, 0);

        InvokeRepeating("ChangePosition", 0, (float)V);
    }

    
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null)
        {
            if (hit.collider.tag == "dart")
            {


                SpawnNextBoss();


            }
        }
    }



    public void SpawnNextBoss()
    {
        Vector3 pos = new Vector3(Random.Range(-size.x / 3, size.x / 3), Random.Range(-size.y / 2, size.y / 2), 0);
        Instantiate(bossPrefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
    void ChangePosition()
    {
        transform.position = spawnPosition;
        
        spawnPosition = new Vector3(Random.Range(3,8), Random.Range(-2, 1), Random.Range(-1, 2));
    }
}
