namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 반복문
            // 코드를 반복적으로 실행하는 문법
            // 반복적으로 실행한다면은 언제까지? => 프로그래머가 정의
            // 반복문을 크게 다음 3개로 나뉘어진다. = while, do-while, for

            // 1. while(조건) => 조건 : 언제까지 반복을 할건지 => 조건이 false가 될 때까지 계속 반복한다. == 조건이 true면 계속 반복한다.
            //      {
            //          반복적으로 실행할 코드
            //      }

            // int count = 1;
            // while(count < 10) // while(조건) => 조건이 true 니까 계속 반복한다.
            // {
            // count < 10가 trun일 때 아래의 코드가 실행된다.
            //   count++;
            //   Console.WriteLine($"{count}");
            // }
            // Console.WriteLine($"while 반복문이 끝났습니다. Conut는 : {count}입니다.");

            // int count = 1;
            // while 반복문이 끝나지 않고 계속해서 실행되는 현상 => 무한루프
            // while(true) // while(조건) => 조건에 그냥 true라는 값을 넣었다. => 무한루프
            // {
            // while(true)
            // {
            //     Console.WriteLine($"Hello Csharp {count++}"); // 무한루프 반복 사용 시 뒤에 조건이 실행되지 않는다. 이러한 반복 무한루프는 지양해야 한다.
            // }
            // Console.WriteLine($"Hello world {count++}");
            // }

            // 반복문을 강제적으로 종료하는 키워드 => break;
            // 반복문이 실행되는 동안 break; 키워드를 만나면 해당 반복문은 종료된다.
            // int count = 1;
            // while (true)
            // {
            //    if(count > 10)
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"{count}");
            //    count++;
            //
            // }

            // 반복문이 실행될 때 특정 순간에 그냥 스킵하고 싶을 때 사용하는 키워드 => continue;
            // 반복문이 실행되는 동안 continue; 키워드를 만나면 나머지 코드는 실행하지 않고
            // 반복문의 조건을 비교하는 부분으로 스킵된다.
            // int count = 1;
            // while (count < 10)
            // {
            //    if (count % 2 == 0) // => 짝수 일 때, 홀수는 2 == 1
            //    {
            //       count++;
            //        continue; // count가 짝수 일 때 아래의 코드는 실행하지 않고 다시 while(조건)에 조건을 비교한다. 즉, 아래의 코드는 스킵한다.
            //    }
            //    Console.WriteLine($"{count}");
            //    count++;
            // }

            // while(조건)은 조건이 false일 때는 코드가 실행되지 않는다.


            // 2. do-while문
            // 2. do
            //      {
            //          반복적으로 실행할 코드지만 무조건 1번은 실행한다.
            //      } while(조건) => 조건 : 언제까지 반복을 할건지 => 조건이 false가 될 때까지 계속 반복한다 == 조건이 true 계속 반복한다.
            // 기본적으로 while문과 동일하지만 코드를 무조건 한번은 실행시킨다는 점에서 다르다.

            // do
            // {
            //    Console.WriteLine("hello world");
            // } while (false);

            // while(조건)은 조건이 false일 때는 코드가 실행되지 않는다.
            // while (false)
            // {
            // while(false) 선언했기 때문에 hello world가 출력되지 않는다.
            //    Console.WriteLine("hello world");
            // }

            // 3. for문
            // for(조건 = (몇번 실행을 할건지에 대한 조건))
            // for(정수형 변수, 정수형 변수에 대한 조건(비교 연산자); 반복 후에 정수형 변수에 대한 처리(사칙연산 혹은 증감연산자))
            // {
            //      반복적으로 실행할 코드
            //      이 반복문 내부에서는 위에 선언한 변수를 사용할 수 있다.
            // }
            // for (int i = 0; i < 10; i++)
            // {
                // 위에 for문에서 int i라는 변수를 선언했기 때문에
                // 아래에서 i 변수를 사용할 수 있다.
                // for문 외부에서는 int i라는 변수를 접근할 수 없다.
            //    Console.WriteLine(i);
            // }    
            // int i2 = 0;
            // for (i2 = 0; i2 <= 20; i2 += 2)
            // {
                // 위에 for문에서 int i라는 변수를 선언했기 때문에
                // 아래에서 i 변수를 사용할 수 있다.
                // for문 외부에서는 int i라는 변수를 접근할 수 없다.
            //    Console.WriteLine(i2);
            // }

            // for문도 break를 만나면 종료된다.
            for(int i = 0; i < 10; i++)
            {
                if (i > 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            // for문도 continue를 만나면 아래의 코드는 스킵한다.
            for (int i = 0; i < 10; i++)
            {
                if (i > 5)
                {
                    Console.WriteLine($"skip : {i}");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
