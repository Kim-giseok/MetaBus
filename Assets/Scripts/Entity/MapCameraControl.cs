using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCameraControl : MonoBehaviour
{
    public Transform target;
    float offsetX, offsetY;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null) return;

        offsetX = transform.position.x - target.position.x;
        offsetY = transform.position.y - target.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;

        Vector3 pos = new Vector3(target.position.x + offsetX, target.position.y + offsetY, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);

        if ((transform.position - pos).magnitude < 0.01f)
            transform.position = pos;
    }
}