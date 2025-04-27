using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycontroller : MonoBehaviour
{
    public GameObject UnityChan;

    // Start is called before the first frame update
    void Start()
    {
        UnityChan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityChan.transform.position.z > this.transform.position.z+2)
            Destroy(gameObject);
    }
 }
