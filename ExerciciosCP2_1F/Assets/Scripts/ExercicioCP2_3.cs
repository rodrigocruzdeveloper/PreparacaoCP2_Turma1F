using UnityEngine;

public class ExercicioCP2_3 : MonoBehaviour
{
    float[] notas = new float[] {4.5f, 8.5f, 7.0f, 10.0f, 3.0f, 1.5f, 6.0f};
    
    void Start()
    {
        foreach (float nota in notas)
        {
            if(nota >= 6.0f)
            {
                print(nota + " aprovado.");
            }
            else
            {
                print(nota + " reprovado.");
            }
        }
    }    
}
