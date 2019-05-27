using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTracking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = position;
    }
}
