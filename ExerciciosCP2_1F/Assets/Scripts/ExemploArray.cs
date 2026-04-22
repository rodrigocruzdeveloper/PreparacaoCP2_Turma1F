using UnityEngine;

public class ExemploArray : MonoBehaviour
{

    [SerializeField] int[] numeros = new int[3];
    [SerializeField] string[] palavras = new string[3]; 

    void Start()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Random.Range(1, 100);
        }


        print(palavras[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
