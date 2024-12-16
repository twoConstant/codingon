# 정리 자료

## 목차

1. [C03_CSharp_기본문법](#c03_csharp_기본문법)  
   - [기본 자료형](#기본-자료형)  
     - [바인딩 방법](#바인딩-방법)  
   - [참조형 자료](#참조형-자료)  
   - [C# 변수 명 규칙](#c-변수-명-규칙)  
   - [변수의 선언, 사용, 초기화](#변수의-선언-사용-초기화)  
   - [형변환](#형변환)

# C03_CSharp_기본문법

### 기본 자료형

- 바인딩 방법
  
  - `<type> variant = value`

- 정수형
  
  ```csharp
  sbyte // 1byte
  short    // 2byte
  int    // 4byte
  long    // 8byte
  
  byte    // 1byte, 부호 없음
  ushort    // 2byte, 부호 없음
  uint    // 4byte, 부호 없음
  ulong    // 8byte, 부호 없음
  ```

- 실수형
  
  ```csharp
  float num_float = 1.2f    // 4byte, 부호 구분없이 7자리까지 표현 가능
  double num_double = 1.2    // 8byte, 부호 구분없이 14자리까지 표현 가능
  decimal num_decimal = 2.2m   // 16byte, 부호 구분없으 28자리까지 표현 가능
  ```

- 문자형
  
  ```csharp
  char    // 2byte
  ```

- 부울
  
  ```csharp
  bool    // 4byte
  ```

- 자동 자료형
  
  - var : “컴파일 시점” 에 자료형이 결정되며 반드시 “초기화” 해야하며 재 할당 가능
    
    ```csharp
    var number = 10;            // int로 추론
    var name = "Hello, World!"; // string으로 추론
    var pi = 3.14;              // double로 추론
    
    var num;    // 선언만은 불가능
    ```
  
  - const : “컴파일 시점”에 자료형이 결정되며 반드시 “초기화”해야하며 재 할당 불가능
    
    ```csharp
    const double Pi = 3.14159;
    const int MaxUsers = 100;
    
    //MaxUsers = 200;    // 재할당 불가능
    ```

### 참조형 자료

- 배열
  
  - 여러가지 선언 및 초기화 방법
    
    ```csharp
    int[] array1 = new int[5];
    int[] array2 = {1, 2, 3, 4, 5};
    int[][] array3 = new int[N][M];
    ```

### C# 변수 명 규칙

- Class = Pascal
- method = Pascal
- filed = _camel

### 변수의 선언, 사용, 초기화

- 변수의 선언
  
  - 값을 할당하지 않는 경우
  
  ```csharp
  int num;
  ```

- 변수의 사용
  
  ```csharp
  num = 2;
  ```

- 변수의 초기화
  
  - 변수의 선언과 동시에 값을 할당하는 경우
  
  ```csharp
  int num = 3
  ```

### 형변환

- int → string
  
  > `int.Parse(v);`
  
  ```csharp
  int num = 100;
  string name = "300"
  num = int.Parse(name);
  ```

- string → int
  
  > `stringVariance.ToString();`
  
  ```csharp
  int num = 100;
  string name = string.ToString(num);
  ```