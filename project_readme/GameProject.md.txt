# 문제1

![](C:\Users\newtk\AppData\Roaming\marktext\images\2025-01-01-20-54-26-image.png)

### UMLV1

![](C:\Users\newtk\AppData\Roaming\marktext\images\2025-01-01-20-54-52-image.png)

### 설계의 문제점

1. Manager의 어색한  위치 : Game내의 모든 오브젝트를 관리하는 Manger 클래스가 Character와 Monster에 속성으로 위치하는게 어색함(공격 가능한 대상인지 식별하는 과정에서 manager.findByid(int)가 필요했기때문.)
2. attack(int)의 중복 코드 발생 : 각각의 Character와 Monster가 attack을 가지고는 설계이기 때문에 로직은 다르지만 중복된 코드가 발생함
3. 공격 관련 유지 보수 및 확장의 불편함 : 공격이란 행위 자체가 Character와 Monster에 속해있기 때문에 이후 PVP, 보스 레이드와같은 전투 이벤트가 다양해질경우 개별 클래스 일일이 다 추가해개하기 때문에 유지보수와 확장성이 떨어짐
4. LivingEntity가 구체 클래스라서 실질적으로 동작을 하는 계층은 Character나 Monster인데 공통 긴능을 넣어버리면 하위 객체에서 조작이 어려움

### 개선책

1. Manager 클래스 내에서 Game에 필요한 여러 객체를 생성, 조회, 삭제, 업데이트를 관리
   1. 팩토리 메서드 패턴 활용
2. BattleSystem 클래스에서 전투에 관련된 동작을 담당하도록 위임

# 문제2

![image.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/e8dc9b1a-ebd7-4746-8b87-278cc7cc5d56/6831ce0b-bea7-48a4-9043-18d23abf5950/image.png)

# 배운것

### “매개변수로 Class 넘겨주지마요” :  Class vs Structure, 다시 만나는 깊은 복사와 얕은 복사

- 이유 : “안전성”
- Class 넘겨 줄 경우 : 매서드 내에서 class의 상태 변경시 원본이 그대로 변경이됨. 참조 값이 그대로 넘어가기 때문에 속성을 변경하면 원본이 바로 변경이 되는것이다. 멀티 스래드 환경에 취약하다.
- Structure 넘겨 줄 경우 : 매서드 내에서 structure의 값 변경되어도 원본이 변경되지 않음. 매개변수로 넘길때 값복사가 일어나 동등성은 충족하지만 동일하지 않은 Structure를 매서드 스코프에서 다룬다. 이후 안전하게 매서드가 종료되었다면 새로운 structure를 원본과 교체해주면 된다.
- 장점 : 안전하다.
- 단점 :
  1. 매개변수로 넘길 속성을 structure로 선언해야한다.
  2. structure 내부에 해당 객체의 타입을 유추 할 수 있는 데이터가 필요하다.
  3. 다형성을 사용 할 수 없다. ⇒ 객체 지향적인 코드는 아니다.

### 싱글톤 패턴 구현

- 이놈은 그냥 생성자 자체가 없다. 외부에선 그냥 속성으로 접근한다.
- 스태틱으로 접근 할 수 있는 Instance라는 속성 하나 만들고 해당 속성에 접근할때 없으면 만들고 있으면 있는 놈 제공한다.

### 팩토리 패턴

### 추상 클래스 vs 인터페이스

- 공통점 : “규격화”
- 차이점 : 추클의 경우 “속성”을 가질 수 있지만 인터페이스는 가지지 못한다.
- 사용처 : 상속해야하는 클래스 설계 ⇒ 추클, 기능 설계(BattleSystem과 같은 경우) ⇒ 인터페이스

### abstract method vs virtual method

- abstract  : 자식 클래스에서 무조건 오버라이딩 필수

- virtual : 부모 클래스에서 기본적인 메서드 제공, 자식 클래스에서 오버라이딩 선택

- 사용법 : 같은 메서드도 공통된 메서드는 virtual로 자식마다 다른 특징을 가져야하는 경우 abstract을 섞어서 활용 가능하다.
  
  - 예시
    
    ```csharp
    // 최상위 클래스 : Combatant
    // 메서드
    public abstract void Attack(Combatant combatant);   => 반드시 자식 클래스에서 오버라이딩
    public virtual void coreAttack(int damage)   => 공통된 기능 제공으로 코드 중복 예방
    {
        this.healthPoint -= damage;
    }
    
    // 1계층 아래 자식 클래스
    public override void Attack(Combatant combatant)
    {
        base.coreAttack(this.attackPoint);   // 여기서 공통된 매서드활용으로 코드 중복 예방
        Console.WriteLine("자식 클래스의 고유 기능");   // 자식 클래스의 고유기능 작성
    }
    ```

# 추가 개선 사항

- CombatantManager에서 생성 메서드의 중복 줄이기
- UML 작성하기
- 레포에 Readme 작성하기