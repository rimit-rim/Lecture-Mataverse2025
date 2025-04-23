### CatEscape 파일 구조
------
- background : (Scale) 4.5, 2, 1
- player : (Position) 0, -3.7, 0 (Scale) 1, 1, 1 | Order in Layer : 1
- arrow : (Position) 0, 3.2, 0 (Scale) 1, 1, 1 | Order in Layer : 1
<br></br>
- 5_1.cs(PlayerController.cs) : 플레이어 캐릭터를 키보드 방향키로 좌우로 움직이게 해주는 코드 | player에 적용
- 5_2.cs : "화살 오브젝트"가 아래로 낙하하고, 화면 아래로 벗어나면 사라지도록 만드는 코드 | arrow에 적용
- 5_3.cs : 단순 낙하에 충돌 판정 기능이 추가 | arrow에 적용
- ArrowGenerator.cs : 일정 시간마다 랜덤 위치에서 화살(Arrow)을 생성하는 역할 | ArrowGenerator에 적용
- ArrowContoller.cs : 단순 낙하에 충돌 판정 기능이 추가 | arrow에 적용
- GameDirector.cs : HP 게이지를 관리하는 컨트롤러로, 게임 중 플레이어가 데미지를 입었을 때 HP를 10% 감소시키는 역할 | GameDirector에 적용
- PlayerController.cs : 플레이어 캐릭터를 키보드 방향키로 상하좌우로 움직이게 해주는 코드 | player에 적용
<br></br>

https://github.com/user-attachments/assets/8ac5414d-d57e-491d-981f-d4951c55fe16

