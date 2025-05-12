using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    int MyMethodWithParam(int number)
    {
        Debug.Log("MyMethodWithParam!" + number);

        return number * number;

    }
    void MyMethod()
    {
        Debug.Log("myAction!");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            EventBus<TestEvent>.Raise(new TestEvent
            {


            });
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            EventBus<PlayerEvent>.Raise(new PlayerEvent
            {
                health = 100,
                mana = 20,
                myAction = MyMethod,
                myFunc = MyMethodWithParam
            });
        }
    }
}
