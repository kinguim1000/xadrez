using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadrado : MonoBehaviour {
    public float y = 0.01f;
    public static bool movimente = false;
    public int contador = 0;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        //if (ui.moviment == true) {
        //transform.position = transform.position + new Vector3 (0, 0.01f, 0);
        //contador = contador + 1;
        //}
        //if (contador == (int.Parse (ui.casasaida) * 100)) {
        //ui.moviment = false;
        //contador = 0;
        //}

    }

    /*
       void movimentos () {
            int z, h, l, c;
            
                if (z == 7) {

                    
                    l = z - 2;
                    c = h;
                    if (ui.xadrez[l,c] == "  ") {
                        ui.xadrez[l,c] = "x";
                    }
                    l = z - 1;
                    c = h;
                    if (ui.xadrez[l,c] == "  ") {
                        ui.xadrez[l,c] = "x";
                    }
                } else {
                    l = z - 1;
                    c = h;
                }
                if (ui.xadrez[l,c] == "  ") {
                    ui.xadrez[l,c] = "x";
                }

                ///////////////////////////////
                if ((ui.xadrez[x,y] == "x")) {
                   while(contador != (int.Parse (ui.casasaida) * 100)){

                   
                        transform.position = transform.position + new Vector3 (0, 0.01f, 0);
                        contador = contador + 1;
                    
                    }
                    contador = 0;
                    
                        
                    
                    ui.xadrez[z,h] = "  ";
                    for (t = 0; t < 10; ++t) {
                        for (i = 0; i < 10; ++i){
                            if (ui.xadrez[t,i] == "x") {
                                ui.xadrez[t,i] = "  ";
                            }
                        
                        else {

                            printf ("%3c", ui.xadrez[t,i]);
                            printf ("\n");
                        }
                        }
                    }
                }
            
        }*/

}