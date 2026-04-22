using UnityEngine;

public class ExemploSubstring : MonoBehaviour
{
    string nome = "Maria Paula";
    
    void Start()
    {
        print(nome);
        print(nome.Substring(6, 5));
    }
    
}
