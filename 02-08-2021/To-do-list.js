
var list = document.querySelector('ul');
list.addEventListener("click",function(ev){
    if(ev.target.tagName === 'LI')
    {
        ev.target.classList.toggle('checked');
    }
},false);





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

    document.getElementById("myInput").value = "";
}






