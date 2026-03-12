# 버튼 잡기 게임 (C#)

## 개요

- C# 프로그래밍 학습
- 핵심 기능 : 버튼 위에 마우스를 올리면 버튼이 랜덤 위치로 이동한다. 버튼이 더이상 이동하지 못하고 잡히면 승리한다.

## 실행 화면

### 1단계
https://github.com/user-attachments/assets/5f85e4e0-711d-4403-abd9-75e538fc1932
- 버튼위에 마우스를 올리면 버튼이 도망간다.
- 버튼이 화면 밖으로 나가지 않도록 수정했다.

### 2단계
<img width="725" height="447" alt="스크린샷 2026-03-12 165315" src="https://github.com/user-attachments/assets/467ea40c-f519-4ae9-aca5-578d57df22ab" />
- 버튼을 잡으면 축하 메시지를 띄운다.
(메시지 창이 녹화에 담기지 않아 스크린 샷 첨부.)

### 3단계
https://github.com/user-attachments/assets/a1bb50fb-afd0-4c18-9714-15637adaab6b
- 버튼 잡기 게임에 점수 시스템을 부여했다.
(기본 점수 100점을 부여. 버튼을 잡으면 +10점, 버튼을 놓치면 -10점.)

### 3단계 (추가)
- 버튼을 잡을 때 마다 버튼의 크기가 감소하도록 했다.

### 4단계
<img width="1450" height="897" alt="image" src="https://github.com/user-attachments/assets/9653add0-b9aa-44a5-b465-a319d506b2c7" />
- 점수가 0점이 되면 게임오버 메시지와 함께 재시도 여부를 묻는다.
- 재시도 버튼을 누르면 게임은 처음부터 다시 시작된다.
- 취소 버튼을 누르면 게임은 끝난다.

### 4단계 추가
https://github.com/user-attachments/assets/fec26a6f-ff2d-44c9-aa69-3268e6dfd3ad
- 버튼의 크기가 감소할 때 버튼 내 텍스트의 폰트도 감소한다..
- 버튼의 위치를 좌표로 표현한다.
