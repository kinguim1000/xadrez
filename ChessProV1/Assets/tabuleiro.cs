using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabuleiro : MonoBehaviour {
    public int x = -4;

    // Start is called before the first frame update
    void Start () {
        for (int x = -4; x < 4; x = x + 2) {
            for (int y = -4; y < 4; y = y + 2) {
                GameObject tabul = GameObject.CreatePrimitive (PrimitiveType.Quad);
                tabul.transform.position = new Vector3 (x, y, 0);
                tabul.GetComponent<Renderer> ().material.color = Color.black;
            }
            for (int y = -3; y < 4; y = y + 2) {
                GameObject tabul = GameObject.CreatePrimitive (PrimitiveType.Quad);
                tabul.transform.position = new Vector3 (x, y, 0);
                tabul.GetComponent<Renderer> ().material.color = Color.white;
            }
        }
        for (int x = -3; x < 4; x = x + 2) {
            for (int y = -4; y < 4; y = y + 2) {
                GameObject tabul = GameObject.CreatePrimitive (PrimitiveType.Quad);
                tabul.transform.position = new Vector3 (x, y, 0);
                tabul.GetComponent<Renderer> ().material.color = Color.white;
            }
            for (int y = -3; y < 4; y = y + 2) {
                GameObject tabul = GameObject.CreatePrimitive (PrimitiveType.Quad);
                tabul.transform.position = new Vector3 (x, y, 0);
                tabul.GetComponent<Renderer> ().material.color = Color.black;
            }
        }

    }

    // Update is called once per frame
    void Update () {

    }
}