using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello, World!");
        string s;
        s = "Hello, World! String";
        Debug.Log(s);
        int n = 10;
        float f = 3.14f;
        bool b = true;
        Debug.Log("Integer: " + n);
        Debug.Log("Float: " + f);
        Debug.Log("Boolean: " + b);
        int m = 5;
        Debug.Log("Sum: " + (n + m));
        Debug.Log("Product: " + (n * m));
        Debug.Log("Division: " + (n / m));
        Debug.Log("余り: " + (n % m));
        Debug.Log("Minus: " + (n - m));
        string name = "John";
        Debug.Log("Hello, " + name + "!");
        n = n + 1;
        Debug.Log("Incremented Integer n : " + n);
        m += 2;
        Debug.Log("Incremented Integer m : " + m);
        // 比較演算子はSkipする

        if (n > 10)
        {
            Debug.Log("n is greater than 10");
        }
        else if (n > 0)
        {
            Debug.Log("n is greater than 0 but less than or equal to 10");
        }
        else
        {
            Debug.Log("n is equal to 0");
        }

        switch (n)
        {
            case 0:
                Debug.Log("n is zero");
                break;
            case 1:
                Debug.Log("n is one");
                break;
            default:
                Debug.Log("n is neither zero nor one");
                break;
        }

        while (n > 0)
        {
            Debug.Log("n is: " + n);
            n--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
