window.onload = function(){
    sendRequest();
    loadDoc();
}


function sendRequest(){
    alert("this is a request");
}

function loadDoc() {
    const xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() { //this is the this
      if (this.readyState == 4 && this.status == 200) {
        alert(this.responseText);
      }
    };
    xhttp.open("GET", "response.php");
    xhttp.send();
  }