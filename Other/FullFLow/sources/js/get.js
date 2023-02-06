
function loadDoc() {
    const xhttp = new XMLHttpRequest();
    
    xhttp.onreadystatechange = function() { //this is the this
      if (this.readyState == 4 && this.status == 200) {
        //alert(this.responseText);
        assignData(this.responseText);
      }
    };
    xhttp.open("GET", "http://localhost/WebSemanticPractice/FullFLow/sources/php/test.php");
    xhttp.setRequestHeader("Access-Control-Allow-Origin","*");
    //xhttp.open("GET", "C:/xampp/htdocs/WebSemanticPractice/FullFLow/sources/php/test.php");
    xhttp.send();
  }

  function assignData(text){
    response= text;
    loadResponse(response);
  }