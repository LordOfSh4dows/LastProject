using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelegaMOVIE : MonoBehaviour
{
    public int speed, index;
    public GameObject[] Targets;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "MARK")
        {
            index++;
        }
    }

    void Update()
    {
        
        if (index<Targets.Length)
        {

            var heading =  Targets[index].transform.position-gameObject.transform.position;
            gameObject.transform.Translate(heading*Time.deltaTime);
        }
    }
}
