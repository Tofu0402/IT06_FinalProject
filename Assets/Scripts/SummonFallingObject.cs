using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonFallingObject : MonoBehaviour
{
    public GameObject prefab;
    private int i = 0;
    public int interval;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(i == interval){
            Instantiate(prefab, new Vector3(transform.localPosition.x+Random.Range(-4,10), transform.localPosition.y, transform.localPosition.z), Quaternion.identity);
            i = 0;
        }

        else
        {
            i++;
        }
    }
}
