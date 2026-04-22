using UnityEngine;

public class ExercicioCP2_2 : MonoBehaviour
{

    string[] nomes = new string[] { "Ana", "Adão", "Maria", "Tito", "Jose" }; 

    void Start()
    {
        foreach (string nome in nomes)
        {
            print(nome.ToUpper());
        }
    }   
}
