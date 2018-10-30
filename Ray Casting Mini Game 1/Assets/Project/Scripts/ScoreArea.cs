 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour {

    public GameObject effectObject;

    void Start()
    {
        effectObject.SetActive(false);
    }

    void OnTriggerEnter(Collider othercollider)
    {
        if (othercollider.GetComponent<Ball> () != null){
            effectObject.SetActive(true);

        }
    }
}
