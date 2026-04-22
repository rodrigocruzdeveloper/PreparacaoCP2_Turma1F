using UnityEngine;

public class ExercicioCP2_1 : MonoBehaviour
{

    int[] numeros = new int[10];

    void Start()
    {
        int pares = 0;

        while(pares < 10)
        {
            int n = Random.Range(1, 100);

            if(n % 2 == 0)
            {
                numeros[pares] = n;
                pares++;
            }
        }
    }

 
}
