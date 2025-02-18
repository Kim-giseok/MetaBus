using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLooper : MonoBehaviour
{
    public int obsCount = 0;
    public int numBgCount = 5;
    public Vector3 obsLastP = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();
        obsLastP = obstacles[0].transform.position;
        obsCount = obstacles.Length;

        foreach (var obstacle in obstacles)
            obsLastP = obstacle.SetRnadomPlace(obsLastP, obsCount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered: " + collision.name);

        if (collision.CompareTag("Background"))
        {
            float widthOfBgObj = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObj * numBgCount;
            collision.transform.position = pos;
            return;
        }

        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
            obsLastP = obstacle.SetRnadomPlace(obsLastP, obsCount);
    }
}
