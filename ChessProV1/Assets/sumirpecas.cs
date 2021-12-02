using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumirpecas : MonoBehaviour {
    public static string sumir;
    public static bool algumapecamorreupreta = false;
    public static bool algumapecamorreubranca = false;
    public static string[] pretas = new string[15] { "p1", "p2", "p3", "p4", "p5", "p6", "p7", "p8", "t1", "c1", "b1", "q1", "b2", "c2", "t2" };
    public static string[] brancas = new string[15] { "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "T1", "C1", "B1", "Q1", "B2", "C2", "T2" };
    public static int qualpecasumiu;
    public static bool sumirpeca = false;
    public static bool sumirpecab = false;
    public static int vez = 0;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        if (algumapecamorreupreta) {
            for (int c = 0; c < 16; c++) {
                if (pretas[c] == sumir) {
                    qualpecasumiu = c;
                    algumapecamorreupreta = false;
                    sumirpeca = true;
                }
            }

        }
        if (algumapecamorreubranca) {
            for (int c = 0; c < 16; c++) {
                if (brancas[c] == sumir) {
                    qualpecasumiu = c;
                    algumapecamorreubranca = false;
                    sumirpecab = true;
                }
            }

        }
    }

}