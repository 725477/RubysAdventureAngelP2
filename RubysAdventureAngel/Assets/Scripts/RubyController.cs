using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("horizontal");
        Debug.Log(horizontal);
        Vector2 position = transform.position;
        position.x = position.x + 0.01f;
        transform.position = position;
    }
}
        
    

