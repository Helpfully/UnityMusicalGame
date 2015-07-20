using UnityEngine;
using System.Collections;

public class AllMapObjectController : MonoBehaviour
{
    public MapObject[] AllMapObjects;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in AllMapObjects)
            {
                item.Activate();
            }
        }
    }
}
