using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float highPosY = 1f;
    public float lowPosY = -1f;

    public float hoeSizeMin = 1f;
    public float hoeSizeMax = 3f;

    public Transform topObj, bottomObj;

    public float widthPadding = 4f;

    GameManager GM;

    private void Start()
    {
        GM = GameManager.instance;
    }

    public Vector3 SetRnadomPlace(Vector3 lastP, int obstaclCount)
    {
        float holeSize = Random.Range(hoeSizeMin, hoeSizeMax);
        float halfHoleSize = holeSize / 2;

        topObj.localPosition = new Vector3(0, halfHoleSize);
        bottomObj.localPosition = new Vector3(0, -halfHoleSize);

        Vector3 placeP = lastP + new Vector3(widthPadding, 0);
        placeP.y = Random.Range(lowPosY, highPosY);

        transform.position = placeP;

        return placeP;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
            GM.AddScore(1);
    }
}
