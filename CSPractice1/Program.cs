using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice1
{
    class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }

        public Sample()
        {
            Console.WriteLine("(인스턴스) 생성자 호출");
        }
    }
    class MyMath
    {
        public static int classVar = 1;
        public int instancevar = 2;

        // Abs (int)
        public static int Abs(int input)
        {
            Console.WriteLine(classVar);
            // 클래스 메서드에서 인스턴스 변수 접근 불가
            // Console.WriteLine(instancevar);
            return (input >= 0) ? input : -input;
        }

        // Abs (double)
        public static double Abs(double input) { return 0; }

        // Abs (int)
        // public static double Abs(int v) {  return 0; }
        // 메서드 시그네이처(이름, 매개변수가 겹쳐서 안 됨)
    }
    class FistClass
    {
        
    }

    internal class Program
    {
        class ThirdClass
        {

        }

        static void Main(string[] args)
        {
            // #1 12-1. 기본용어
            //int base = 0;
            var abc = 3;
            // var var = 3;

            // 한줄 주석
            /*
             * 여러줄 주석
             */
            /*** XML 주석 ***/

            // #1 12-2. 출력
            Console.WriteLine("Hello World");
            Console.Write("줄바꿈 싫어");

            // #1 12-3. 기본 자료형
            // 정수
            Console.WriteLine(52 + 4 - 1);
            // 사칙연산자 = 산술 연산 = Arithmetic operator
            // + - * / %

            // 실수 (Real Number)
            Console.WriteLine(52.0);

            // 문자 (Character)
            Console.WriteLine('A');
            Console.WriteLine('가');

            // 문자열 (string)
            Console.WriteLine("Hello World");

            //Escape Character - 탈출 문자
            Console.WriteLine("미\n\\림\t마\"고");

            // 문자열 연결 연산자 (Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");

            // 문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]); // "o" 출력
            //Console.WriteLine("Hello World"[100]); // 예외 발생
            //Console.WriteLine("Hello World"[-3]); // 예외 발생

            // 주의
            Console.WriteLine('가' + '힣');
            // 문자열 연결연산자 XXX, 덧셈 연산자임

            // 논리 (Boolean)
            // 출력하면 대문자로 나옴!!!!!!!!!!!!!!!!
            Console.WriteLine(true); 
            Console.WriteLine(false);

            // 비교 연산자 (Conparison Operator)
            // == != > < >= <=
            // 결과는 Boolean으로

            // 논리 연산자 (Logical Operator)
            // && || !
            Console.WriteLine(!true);
            Console.WriteLine(true && false);
            Console.WriteLine(true || false);

            // #1 12-4. 변수
            string s = "문자열 자료형 주의";

            // #1 12-5. 복합대입연산자
            string output = "Hello";
            output += "World";
            Console.WriteLine(output);

            // #1 12-6. 증감 연산자 *
            int number = 10;
            Console.WriteLine(number++); // 10
            Console.WriteLine(++number); // 12
            Console.WriteLine(number--); // 12
            Console.WriteLine(--number); // 10

            // #1 12-8. var 키워드
            var varnumber = 20;
            // var abc; ==> X 반드시 초기화 해줘야함

            // #1 12-9. 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            // #1 12-10 자료형 변환 *
            // 굉장히 중요

            // #2 13-1. if 조건문
            // 중괄호 어디에 쓰는지가 중요
            bool condition = true;

            if (condition)
            {
                // some
            } else if(condition)
            {
                // some2
            }
            else
            {
                // other
            }

            // #2 13-5. switch 조건문
            int v = 0;
            switch (v)
            {
                case 0:
                    //
                    break;
                default:
                    //
                    break;
                    // default도 break 필요하다!!!
            }

            // #2  13-6. 삼항 연산자
            Console.WriteLine(number % 2 != 1 ? true : false);

            // #3 14-1. 반목문과 배열
            int[] intArray = new int[100]; // 초기화 안 하면 모든 값은 0으로
            Console.WriteLine(intArray[99]);

            // #3 14-2. while 반복문
            int i = 0;
            int[] intArray2 = { 52, 273, 32 };
            while(i < intArray2.Length)
            {
                Console.WriteLine(intArray2[i]);
                i++; // 탈출을 위한 변수
            }

            // #3 14-6. foreach 반복문
            string[] foreachArray = { "사과", "배", "포도" };
            foreach (var item in foreachArray){
                Console.WriteLine(item);
            }

            // #4 21-2. 클래스 사용*

            // Random
            // minValue, maxValue : 이상, 미만
            Random random = new Random();
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));
            Console.WriteLine(random.Next(1, 7));

            // Math
            Console.WriteLine(Math.Abs(-9)); // 9
            Console.WriteLine(Math.Ceiling(42.3)); // 43
            Console.WriteLine(Math.Floor(42.9)); // 42
            Console.WriteLine(Math.Round(42.4)); // 43
            Console.WriteLine(Math.Min(42, 1)); // 1
            Console.WriteLine(Math.Max(42, 1)); // 42
            Console.WriteLine(Math.PI); // 3.142592~


            // #4 21-3. 클래스 생성
            // First, Second, Third Class 생성

            // #4 21-4. 인스턴스 변수
            User user1 = new User();
            user1.name = "이미림";
            user1.phoneNumber = "010-1234-5678";

            Product p1 = new Product();
            p1.name = "어른폰";
            p1.price = 9999999;

            Product p2 = new Product()
            {
                price = 300,
                name = "감자폰"
            };

            Product p3 = new Product()
            { 
                name = "공짜폰"
            };

            // #4 21-4. 클래스 변수
            Console.WriteLine(Product.TEX_RATIO);
            // Console.WriteLine(p1.TEX_RATIO); java는 가능하지만, c#은 불가능

            // #5 22-3. 클래스 메서드

            // #5 22-4. 메서드 오버로딩
            Console.WriteLine(MyMath.Abs(-10)); // Abs(int)
            Console.WriteLine(MyMath.Abs(10.0)); // Abs(double)
            Console.WriteLine(MyMath.Abs(-10L)); // Abs(double) => double로 자동형변환되어서 호출함
            Console.WriteLine(MyMath.Abs(3.0f)); // Abs(double) => double로 자동형변환되어서 호출함
            // 표현 가능한 수가 float보다 double이 더 크기 때문에 자동형변환된다.

            // #5 22-6. 생성자 (+ 정적 생성자)
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value); // Sample이 메모리에 불러와지고 정적 생성자 호출된다.
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");


        }
    }
}
