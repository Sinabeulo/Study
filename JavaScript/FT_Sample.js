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