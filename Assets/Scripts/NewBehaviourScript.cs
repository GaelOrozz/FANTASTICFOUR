using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    // Update is called once per frame
    public void Move(Vector2 input)
    {
        transform.Translate(input.x * speed * Time.deltaTime, 0, input.y * speed * Time.deltaTime);
    }
}
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
