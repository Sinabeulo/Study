// 2019.10.17 회사

// 테스트 안함.
// z index 설정
function Set_Z_Index(elemt1, value) {
    document.getElementById(elemt1).style.zIndex = value;
}

// 파일 읽기 예제 코드
function openTextFile() {
    var input = document.createElement("input");

    input.type = "file";
    input.accept = "text/plain";    //  확장자가 xxx, yyy 일 때, ".xxx, .yyy"

    input.onchange = function (event) {
        processFile(event.target.files[0]);
    };

    input.click();
}

// 파일 읽기 함수
function processFile(file) {
    var reader = new FileReader();

    reader.onload = function () {
        output.innerText = reader.result;
    };

    reader.readAsText(file,/* optional */ "euc-kr");
}

// 파일 쓰기 Chrome
function saveToFile_Chrome(fileName, content) {
    var blob = new Blob([content], { type: 'text/plain' });

    objURL = window.URL.createObjectURL(blob);

    // 이전에 생성된 메모리 해제
    if (window.__Xr_objURL_forCreatingFile__) {
        window.URL.revokeObjectURL(window.__Xr_objURL_forCreatingFile__);
    }
    window.__Xr_objURL_forCreatingFile__ = objURL;
    window.do

    var a = document.createElement('a');

    a.download = fileName;
    a.href = objURL;
    a.click();
}

// 파일 쓰기 IE
function saveToFile_IE(fileName, content) {
    var blob = new Blob([content], { type: "text/plain", endings: "native" });

    window.navigator.msSaveBlob(blob, fileName);
    //window.navigator.msSaveOrOpenBlob(blob, fileName);
}

// 작동 안함
// 윈도우, 도큐먼트 객체 시험
function closePage() {
    //window.close();
    document.close();
}

// 윈도우, 도큐먼트 객체 시험
function openNewPage() {
    window.open('http://www.naver.com');
}

//=================================================================================
//2019-10-18
//ES6 새로운 데이터 타입
//let == var 
//const = 상수

function backtickSample(){
    var world = 'world';
    console.log(`Hello ${world}`);

    let testMutliStr = `line1
    line2
    line3`;
    console.log(testMutliStr);
}

function getGreeting(){
    return "Hello World";
}

function f_call_reference(){
    console.log(getGreeting());
    console.log(getGreeting);

    const o = {};
    o.f=getGreeting();
    o.f();      // "Hello, World!"
}

function f_parameter(){
    function f(o){
        o.message = "f에서 수정함";
        o = {
            message: "새로운 객체"
        };
        console.log(`f 내부 : o.message="${o.message}" (하당후)`);
    }

    let o = {
        message : '초기값'
    };

    console.log(`f를 호출하기 전: o.message="${o.message}"`);
    f(o);
    console.log(`f를 호출한 다음: o.message="${o.message}"`);
}
//=================================================================================
//2019-10-22
// 크라운 앤 앵커 게임 예제
function f_crown_n_anchor(bets ){
    // m 이상 n 이하의 무작위 정수를 반환합니다.
    function rand(m,n){
        return m + Math.floor((n - m + 1)*Math.random());
    }

    // 크라운 앤 앵커 게임의 여섯 그림 중 하나에 해당하는 문자열을 무작위로 반환합니다.
    function randFace(){
        return ["crown","anchor","heart","spade","club","diamond"][rand(0,5)];
    }

    let funds = 50;
    let round = 0;

    while (funds > 1 && funds < 100) {
        round++;
        console.log(`round ${round}`);
        console.log(`\tstarting funds: ${funds}p`);
        // 돈을 겁니다.
        let bets = { crown: 0, anchor: 0, heart: 0, spade: 0, club: 0, diamond: 0 };
        let totalBet = rand(1, funds);
        if (totalBet === 7) {
            totalBet = funds;
            bets.heart = totalBet;
        } else {
            // 나눕니다.
            let remaining = totalBet;
            do {
                let bet = rand(1, remaining);
                let face = randFace();
                bets[face] = bets[face] + bet;
                remaining = remaining - bet;
            } while (remaining > 0)
        }

        funds = funds - totalBet;
        console.log('\tbets: ' +
            Object.keys(bets).map(face => `${face}: ${bets[face]} pence`).join(',') +
            `(total:${totalBet} pence)`);

        // 주사위
        const hand = [];
        for (let roll = 0; roll < 3; roll++) {
            hand.push(randFace());
        }

        console.log(`\thand: ${hand.join(',')}`);

        let winnings = 0;
        for (let die = 0; die < hand.length; die++) {
            let face = hand[die];
            if (bets[face] > 0) winnings = winnings + bets[face];
        }
        funds = funds + winnings;
        console.log(`\twinnings: ${winnings}`);
    }
    console.log(`\tendgin funds: ${funds}`);
}

// 피보나치 예제
function fibonachi(){
    for(let tmep, i=0, j=1; j<30; temp = i, i = j, j = i + temp)
        console.log(j);
}

// cancel side effect (부수효과 취소)
// 부수 효과 = 외부의 상태를 변경하는 것 또는 함수로 들어온 인자의 상태를 직접 변경하는 것
function cancelSidEffect(){
    const skipIt = true;
    let x = 0;
    const result = skipIt || x++;   // true면 x => 0 (부수효과 미발생)
    // skipIt이 true일 때 x++을 처리하지 않는 행위를 단축평가라고 한다.
    console.log(result + ' : ' + x);

    const doIt = false;
    let y = 0;
    const result1 = doIt && y++;
    console.log(result1 + ' : ' + y);
}