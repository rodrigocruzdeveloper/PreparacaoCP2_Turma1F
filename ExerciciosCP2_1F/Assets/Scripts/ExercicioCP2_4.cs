using UnityEngine;

public class ExercicioCP2_4 : MonoBehaviour
{
    

    void Start()
    {
        int n = 1;
        int pares = 0;

        while(n <= 20)
        {
            if(n % 2 == 0)
            {
                pares++;
            }

            print(n);
            n++;
        }

        print("Quantidade de pares: " + pares);

    }
        
}
