using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Target
{
    public Transform transform;
    public Vector2 offSet;
    public bool x;
    public bool y;
}

[ExecuteInEditMode]
public class Follow : MonoBehaviour
{
    public Target target;

    
        
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            (target.x) ? target.transform.position.x + target.offSet.x : transform.position.x,
            (target.y) ? target.transform.position.y + target.offSet.y : transform.position.y,
            transform.position.z);
    }
}
