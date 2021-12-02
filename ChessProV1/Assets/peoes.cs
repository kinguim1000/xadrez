using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoes : MonoBehaviour {
    public string waI; //who am I
    public static int soma, somad, somau;
    private int contador;
    public int valormorte;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame

    void Update () {
        if (sumirpecas.vez == 0) {
            if (ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] == waI) {

                soma = ((ui.ipartidalinha * 10) + ui.ipartidacoluna) - ((ui.ichegadalinha * 10) + ui.ichegadacoluna);

                somad = ui.ipartidalinha - ui.ichegadalinha;
                somau = ui.ipartidacoluna - ui.ichegadacoluna;

                if (ui.ipartidacoluna == ui.ichegadacoluna) {
                    if (ui.ipartidalinha == 7 && (somad == 1 || somad == 2) && ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "  ") {
                        //while(contador < somad*100){

                        transform.position = transform.position + new Vector3 (0, somad, 0);

                        //contador = contador + 1;

                        //}
                        //contador = 0;
                        ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString ();
                        ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";

                    } else {
                        if (somad == 1 && ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "  ") {
                            //while(contador < somad*100){

                            transform.position = transform.position + new Vector3 (0, somad, 0);

                            //contador = contador + 1;

                            //}
                            //contador = 0;
                            ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString ();
                            ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";

                        }
                    }
                } else if (ui.ipartidacoluna == ui.ichegadacoluna + 1 || ui.ipartidacoluna == ui.ichegadacoluna - 1) {

                    if (somad == 1 && ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] != "  " && (ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p3" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p4" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p5" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p6" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p7" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "p8" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "t1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "t2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "c1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "c2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "b1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "b2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "q1")) {
                        if (somau == -1) {

                            //while(contador < 100){

                            transform.position = transform.position + new Vector3 (1f, 1f, 0);

                            //contador = contador + 1;

                            //}
                            //contador = 0;
                            sumirpecas.sumir = ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna]; //fala a peça que vai morrer
                            ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString (); //atualiza a casa que comeu a peça
                            sumirpecas.algumapecamorreupreta = true;
                            ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";
                        } else if (somau == 1) {

                            //while(contador < 100){

                            transform.position = transform.position + new Vector3 (-1f, 1f, 0);

                            //contador = contador + 1;

                            //}
                            //contador = 0;
                            sumirpecas.sumir = ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna]; //fala a peça que vai morrer
                            ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString (); //atualiza a casa que comeu a peça
                            sumirpecas.algumapecamorreupreta = true;
                            ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";
                        }
                    }

                }

            }
            if (sumirpecas.sumirpecab) {
                if (valormorte == sumirpecas.qualpecasumiu) {
                    transform.position = transform.position + new Vector3 (8f, 0, 0);
                    sumirpecas.sumirpecab = false;
                }
            }
            sumirpecas.vez = 1;
        }
        
    }
}