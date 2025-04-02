using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + " 데미지를 입혔다.");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(this.power + " 데미지를 입었다.");
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        void SayHello()
        {
            Debug.Log("Hello, Welcome to introduction Metavese.");
        }

        void CallName(string name)
        {
            Debug.Log("Hello, " + name + ".");
        }

        Debug.Log("Hello");
        
        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "surim";
        Debug.Log(name);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);

        answer = 8 / 3;
        Debug.Log(answer);

        answer = 10;
        while (answer < 99)
        {
            // answer += 5;
            answer++;
            Debug.Log(answer);
        }

        string str1 = "Happy ";
        string str2 = "birthday";
        string message;

        message = str1;
        message += str2;
        Debug.Log(message);

        string str3 = "Answer to the Ultimate Question of Life, the Universe 어쩌구 저쩌구.... ";
        int num3 = 42;

        string message1 = str3 + num3 + "."; // num3는 string으로 자동 형변환
        Debug.Log(message1);

        int herbNum = 1;
        if (herbNum == 1)
        {
            Debug.Log("체력을 50 회복");
        }

        int hp = 200;
        if (hp >= 100)
        {
            Debug.Log("공격");
        }
        else
        {
            Debug.Log("방어");
        }


        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        // Debug.Log(y); 얘는 오류남
        Debug.Log(x);

        for(x = 0; x < 5; x++)
        {
            Debug.Log(x);
        }

        int sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        int[] array = new int[5];
        array[0] = 2;
        array[1] = 20;
        array[2] = 200;
        array[3] = 2000;
        array[4] = 20000;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] points = { 83, 99, 52, 93, 15 };
        int sum1 = 0;
        for(int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
            sum1 += points[i];
        }

        float average = (float)sum / points.Length;
        Debug.Log(average);

        SayHello();
        CallName("surim");

        int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        int ans;
        ans = Add(3, 4);
        Debug.Log(ans);

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
