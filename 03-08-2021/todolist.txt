
let list = document.querySelector('ul');
list.addEventListener("dblclick",function(ev){
    if(ev.target.tagName === 'LI')
    {
        ev.target.classList.toggle('checked');
    }

},false);


let closeButton = document.getElementsByTagName("LI");
for(let i=0;i<closeButton.length;i++)
{
var span = document.createElement("SPAN");
var text = document.createTextNode("\u00D7");
span.className = "close";
span.appendChild(text);
closeButton[i].appendChild(span);
}

let close = document.getElementsByClassName("close");
for(let i = 0;i<close.length;i++)
{
close[i].onclick = function()
{
    let div = this.parentElement;
    div.style.display = "none";

}
}

// creating array

let theArr = [];

function Add()
{
    var list = document.createElement("li");
    var input = document.getElementById("myInput").value;
    var text = document.createTextNode(input);
    list.appendChild(text);
    if(input === '')
    {
        alert("You must write your list");
    }
    else
    {
        document.getElementById("myUl").appendChild(list);
    }

    // pushing list elements to array

    theArr.push(input);
    console.log(theArr);

    // Adding values to array
    theArr.push("Shuttle");
    theArr.push("watching series");
    console.log(theArr);

    //Remove values from array
    theArr.pop("shuttle");
    theArr.pop(input);
    console.log(theArr);

    document.getElementById("myInput").value = "";

    var span = document.createElement("SPAN");
    var txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    list.appendChild(span);

  for (i = 0; i < close.length; i++) 
  {
    close[i].onclick = function() 
    {
      var div = this.parentElement;
      div.style.display = "none";
    }
}

localStorage.setItem('myList',JSON.stringify(theArr));
var result = localStorage.getItem("myList");
result = JSON.parse(result);  

}







