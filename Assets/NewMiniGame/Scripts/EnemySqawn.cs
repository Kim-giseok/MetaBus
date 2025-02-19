using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySqawn : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefebs;
    Rigidbody2D _rigEnemy;

    float delayTime = 3;

    const float maxTime = 30;
    float curTime = maxTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (curTime < 0)
        {
            curTime = 0;
            GameManager.instance.GameOver();
            return;
        }
        curTime -= Time.deltaTime;

        if (delayTime <= 0)
        {
            SpawnEnemy();
            delayTime = Random.Range(3f, 6f);
        }
        else
        {
            delayTime -= Time.deltaTime;
        }
    }

    public void SpawnEnemy()
    {
        _rigEnemy = Instantiate(enemyPrefebs[Random.Range(0, enemyPrefebs.Length)], this.transform).GetComponent<Rigidbody2D>();

        _rigEnemy.transform.localPosition += new Vector3(Random.Range(-4, 4), 0, 0);
        _rigEnemy.AddForce(Vector2.up * Random.Range(600f, 800f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
