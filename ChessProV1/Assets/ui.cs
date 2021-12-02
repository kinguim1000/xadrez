using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour {
    public Button btnpeca;
    public InputField inputpartida;
    public InputField inputchegada;
    public static string casasaida; //pega a casa que vai sair
    public static string casachega; //pega a casa que vai chegar
    public static bool moviment = false;
    public string partidacoluna;
    public string partidalinha;
    public string chegadacoluna;
    public string chegadalinha;
    public static int ipartidacoluna, ipartidalinha, ichegadacoluna, ichegadalinha;
    //private GameObject[,] matrix = new GameObject[10, 10];
    public static string[, ] xadrez = new string[10, 10] { { "0", " a", " b", " c", " d", " e", " f", " g", " h", "0" }, { "8", "t1", "c1", "b1", "q1", "k1", "b2", "c2", "t2", "8" }, //1
        { "7", "p1", "p2", "p3", "p4", "p5", "p6", "p7", "p8", "7" }, //2
        { "6", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "6" }, //3
        { "5", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "5" }, //4
        { "4", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "4" }, //5
        { "3", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "3" }, //6
        { "2", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "2" }, //7
        { "1", "T1", "C1", "B1", "Q1", "K1", "B2", "C2", "T2", "1" }, //8
        { "0", " a", " b", " c", " d", " e", " f", " g", " h", "0" }
    };
    // Start is called before the first frame update
    void Start () {
        btnpeca.onClick.AddListener (clique);

    }

    // Update is called once per frame
    public void clique () {

        casasaida = inputpartida.text;
        casachega = inputchegada.text;
        partidacoluna = inputpartida.text[0].ToString ();
        partidalinha = inputpartida.text[1].ToString ();
        chegadacoluna = inputchegada.text[0].ToString ();
        chegadalinha = inputchegada.text[1].ToString ();

        if (partidacoluna == "a") ipartidacoluna = 1;
        else if (partidacoluna == "b") ipartidacoluna = 2;
        else if (partidacoluna == "c") ipartidacoluna = 3;
        else if (partidacoluna == "d") ipartidacoluna = 4;

        else if (partidacoluna == "e") ipartidacoluna = 5;
        else if (partidacoluna == "f") ipartidacoluna = 6;
        else if (partidacoluna == "g") ipartidacoluna = 7;
        else if (partidacoluna == "h") ipartidacoluna = 8;

        if (partidalinha == "8") ipartidalinha = 1;
        else if (partidalinha == "7") ipartidalinha = 2;
        else if (partidalinha == "6") ipartidalinha = 3;
        else if (partidalinha == "5") ipartidalinha = 4;

        else if (partidalinha == "4") ipartidalinha = 5;
        else if (partidalinha == "3") ipartidalinha = 6;
        else if (partidalinha == "2") ipartidalinha = 7;
        else if (partidalinha == "1") ipartidalinha = 8;

        //divisão

        if (chegadacoluna == "a") ichegadacoluna = 1;
        else if (chegadacoluna == "b") ichegadacoluna = 2;
        else if (chegadacoluna == "c") ichegadacoluna = 3;
        else if (chegadacoluna == "d") ichegadacoluna = 4;

        else if (chegadacoluna == "e") ichegadacoluna = 5;
        else if (chegadacoluna == "f") ichegadacoluna = 6;
        else if (chegadacoluna == "g") ichegadacoluna = 7;
        else if (chegadacoluna == "h") ichegadacoluna = 8;

        if (chegadalinha == "8") ichegadalinha = 1;
        else if (chegadalinha == "7") ichegadalinha = 2;
        else if (chegadalinha == "6") ichegadalinha = 3;
        else if (chegadalinha == "5") ichegadalinha = 4;
        else if (chegadalinha == "4") ichegadalinha = 5;
        else if (chegadalinha == "3") ichegadalinha = 6;
        else if (chegadalinha == "2") ichegadalinha = 7;
        else if (chegadalinha == "1") ichegadalinha = 8;

    }
}