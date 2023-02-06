window.onload = function(){

}

function getdata(){
    sendRequest();
    loadDoc();
}

function sendRequest(){
    alert("this is a request");
}


function loadResponse(text){
    var jsonresult = JSON.parse(text);
    var htmlBody = document.getElementById("1");

    //alert(jsonresult);
    for (var i = 0; i < jsonresult.results.bindings.length; i++){
        //alert(jsonresult.results.bindings[i].x.value);
        var newDiv = document.createElement("div");
        var newParagraphX = document.createElement("p");
        var newParagraphY = document.createElement("p");
        var newParagraphZ = document.createElement("p");

        newParagraphX.textContent = jsonresult.results.bindings[i].x.value;
        newParagraphY.textContent = jsonresult.results.bindings[i].y.value;
        newParagraphZ.textContent = jsonresult.results.bindings[i].z.value;

        newDiv.classList.add("mainstyle");
        newDiv.appendChild(newParagraphX);
        newDiv.appendChild(newParagraphY);
        newDiv.appendChild(newParagraphZ);

        htmlBody.appendChild(newDiv);
    }
}