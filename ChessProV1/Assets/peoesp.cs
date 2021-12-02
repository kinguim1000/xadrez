using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoesp : MonoBehaviour {
    public string waI; //who am I
    public static int soma, somad, somau;
    private int contador;
    public int valormorte;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame

    void Update () {
        if (sumirpecas.vez == 1) {
            if (ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] == waI) {

                soma = ((ui.ipartidalinha * 10) + ui.ipartidacoluna) - ((ui.ichegadalinha * 10) + ui.ichegadacoluna);

                somad = -(ui.ipartidalinha - ui.ichegadalinha);
                somau = -(ui.ipartidacoluna - ui.ichegadacoluna);

                if (ui.ipartidacoluna == ui.ichegadacoluna) {

                    if (ui.ipartidalinha == 2 && (somad == 1 || somad == 2) && ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "  ") {

                        //while(contador < somad){

                        transform.position = transform.position + new Vector3 (0, -somad, 0);

                        //contador = contador + 1;

                        //}

                        //contador = 0;
                        ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString ();
                        ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";

                    } else {
                        if (somad == 1 && ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "  ") {
                            //(contador < somad*100){

                            transform.position = transform.position + new Vector3 (0, -1f, 0);

                            //contador = contador + 1;

                            //}
                            //contador = 0;
                            ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString ();
                            ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";

                        }
                    }
                } else if (ui.ipartidacoluna == ui.ichegadacoluna + 1 || ui.ipartidacoluna == ui.ichegadacoluna - 1) {

                    if (somad == 1 && ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] != "  " && (ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P3" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P4" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P5" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P6" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P7" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "P8" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "T1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "T2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "C1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "C2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "B1" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "B2" || ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] == "Q1")) {
                        if (somau == -1) {

                            //while(contador < 100){

                            transform.position = transform.position + new Vector3 (-1f, -1f, 0);

                            //contador = contador + 1;

                            //}
                            //contador = 0;
                            sumirpecas.sumir = ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna]; //fala a peça que vai morrer
                            ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString (); //atualiza a casa que comeu a peça
                            sumirpecas.algumapecamorreubranca = true;
                            ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";
                        } else if (somau == 1) {

                            //while(contador < 100){

                            transform.position = transform.position + new Vector3 (1f, -1f, 0);

                            //contador = contador + 1;

                            //}
                            //contador = 0;
                            sumirpecas.sumir = ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna]; //fala a peça que vai morrer
                            ui.xadrez[ui.ichegadalinha, ui.ichegadacoluna] = waI.ToString (); //atualiza a casa que comeu a peça
                            sumirpecas.algumapecamorreubranca = true;
                            ui.xadrez[ui.ipartidalinha, ui.ipartidacoluna] = "  ";
                        }
                    }

                }

            }

            if (sumirpecas.sumirpeca) {
                if (valormorte == sumirpecas.qualpecasumiu) {
                    transform.position = transform.position + new Vector3 (8f, 0, 0);
                    sumirpecas.sumirpeca = false;
                }
            }
            sumirpecas.vez = 0;
        }
        
    }

}
