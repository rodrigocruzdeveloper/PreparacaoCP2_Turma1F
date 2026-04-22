using UnityEngine;

public class SuperTrunfo : MonoBehaviour
{
    int[] j1 = new int[3];
    int[] j2 = new int[3];
    
    string[] atributos = new string[] { "F", "V", "I" };

    string[] historico = new string[5];

    bool jogando = true;

    int rodadas = 0;

    void Update()
    {
        if (Input.anyKeyDown && rodadas < 5)
        {   
            // DEFINE O ATRIBUTO DA RODADA
            string atributoAtual = atributos[Random.Range(0, atributos.Length)];

            // CRIA AS CARTAS DA RODADA (CADA SERÁ CRIADA NA SUA RODADA)
            for (int i = 0; i < 3; i++)
            {
                j1[i] = Random.Range(1, 10);
                j2[i] = Random.Range(1, 10);
            }

            // EXIBIR OS DADOS DA RODADA
            print("Atributo da rodada: " + atributoAtual);

            print("Carta jogador 1: " + " F " + j1[0] + " V " + j1[1] + " I " + j1[2]);
            print("Carta jogador 2: " + " F " + j2[0] + " V " + j2[1] + " I " + j2[2]);

            print("J1: " + j1[rodadas]);
            print("J2: " + j2[rodadas]);


            // VERIFICA O RESULTADO DA RODADA
            if (atributoAtual == "F")
            {
                if (j1[0] == j2[0])
                {
                    historico[rodadas] = "Empate.";
                    print("Empate.");
                }
                else
                {
                    if (j1[0] > j2[0])
                    {
                        historico[rodadas] = "Jogador 1, venceu a rodada";
                        print("Jogador 1, venceu a rodada.");
                    }
                    else
                    {
                        historico[rodadas] = "Jogador 2, venceu a rodada";
                        print("Jogador 2, venceu a rodada.");
                    }
                }
            }
            else if (atributoAtual == "V")
            {
                if (j1[1] == j2[1])
                {
                    historico[rodadas] = "Empate.";
                    print("Empate.");
                }
                else
                {
                    if (j1[1] > j2[1])
                    {
                        historico[rodadas] = "Jogador 1, venceu a rodada";
                        print("Jogador 1, venceu a rodada.");
                    }
                    else
                    {
                        historico[rodadas] = "Jogador 2, venceu a rodada";
                        print("Jogador 2, venceu a rodada.");
                    }
                }
            }
            else
            {
                if (j1[2] == j2[2])
                {
                    historico[rodadas] = "Empate.";
                    print("Empate.");
                }
                else
                {
                    if (j1[2] > j2[2])
                    {
                        historico[rodadas] = "Jogador 1, venceu a rodada";
                        print("Jogador 1, venceu a rodada.");
                    }
                    else
                    {
                        historico[rodadas] = "Jogador 2, venceu a rodada";
                        print("Jogador 2, venceu a rodada.");
                    }
                }
            }

            print("--------------------------");

            // REGISTRA UMA RODADA
            rodadas++;
        }
        else if(rodadas == 5 && jogando == true)
        {
            // EXIBE O HISTORICO DA PARTIDA
            print("Histórico da partida.");

            foreach (string h in historico)
            {
                print(h);
            }

            jogando = false;
        }
    }
}
