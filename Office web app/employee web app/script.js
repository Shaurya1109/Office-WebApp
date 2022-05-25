function open(){

    document.getElementById("getrec").style.display="block";

}

function open1(){

    document.getElementById("insrec").style.display="block";

}

function open3(){

    document.getElementById("search").style.display="block";

}

function get() {

   

    var url="http://localhost:64999/Employee";

    fetch(url)

    .then((res) => res.text())

    .then(ans => showD(ans))  

    }

       

     

  function showD(data)

  {

      document.getElementById("abc").innerHTML=data;

  }


  function get2() {

   
    var id=document.getElementById("id123").value;
    var url="http://localhost:64999/Employee/"+id;

    fetch(url)

    .then((res) => res.text())

    .then(ans => showD(ans))  

    }

    function sendJSON(){

           

   

        let EmployeeName = document.getElementById("ename");
    
        let EmployeeGender = document.getElementById("egender");
    
        let EmployeeAge = document.getElementById("eage");

        let EmployeePhonenumber = document.getElementById("ephn");
    
       
    
        // Creating a XHR object
    
        let xhr = new XMLHttpRequest();
    
        let url = "http://localhost:64999/Employee";
    
    
    
        // open a connection
    
        xhr.open("POST", url, true);
    
    
    
        // Set the request header i.e. which type of content you are sending
    
        xhr.setRequestHeader("Content-Type", "application/json");
    
    
    
        // Create a state change callback
    
        xhr.onreadystatechange = function () {
    
            if (xhr.readyState === 4 && xhr.status === 200) {
    
    
    
                // Print received data from server
    
                result.innerHTML = this.responseText;
    
    
    
            }
    
        };
    
    
    
        // Converting JSON data to string
    
        var data = JSON.stringify({  "employeeName": EmployeeName.value , "employeeGender":EmployeeGender.value, "employeeAge":EmployeeAge.value,"employeePhonenumber":EmployeePhonenumber.value});
    
    
    
        // Sending data with the request
    
        xhr.send(data);
    
    }


    function call() {

   

        var id=document.getElementById("abcd").value;
    
        var url="http://localhost:64999/Employee/Employee/"+id;
    
        fetch(url)
    
        .then((res) => res.text())
    
        .then(ans => showData(ans))  
    
        }
    
           
    
         
    
      function showData(data)
    
      {
    
          document.getElementById('abc').innerHTML=data;
    
      }
       

     

  