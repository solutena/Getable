# Getable

고유하게 존재하는 타입을 가져오기 위한 디자인 패턴이다.

UI에서 유용하게 사용할 수 있다.

# 예제


```
public class PlayerUI : Getable
{
    //스크립트
}
```

Getable을 상속하면

```
PlayerUI playerUI = Getable.Get<PlayerUI>();
```

다음과 같이 다른 스크립트에서 Getable.Get<타입>() 함수로 가져올 수 있다.

`Awake`에서 추가하고, `OnDestroy`에서 제거되므로

`Get`해오기전에 UI가 한번은 켜져있어야 한다.
