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
        if(other.tag == "SPHERA")
        {
            speed=1;
        }
    }


    void Update()
    {
        if (speed==1)
        {
            if (index<Targets.Length)
            {
                var heading =  Targets[index].transform.position-gameObject.transform.position;
                var distance = heading.magnitude;
                var direction = heading / distance;
                gameObject.transform.Translate(direction*10*Time.deltaTime);
            }
        }
    }
}
