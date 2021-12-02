using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peao : MonoBehaviour {
    // Start is called before the first frame update
    public int posPaB = 21;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (ui.moviment) {
            transform.position = new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z);
        }
    }
}