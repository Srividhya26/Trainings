
window.onload = function()
{
    var httpReq = new XMLHttpRequest();
    httpReq.open("GET","https://reqres.in/api/users?page=2");
    
    httpReq.onreadystatechange = function()
    {
        if(this.readyState == 4 && this.status == 200)
        {
            var convert = JSON.parse(httpReq.responseText);

            var out = document.querySelector('#table-body');
            var model = document.querySelector('#table');

            convert.data.map((user) => 
            {
                out.innerHTML +=
                `
                <div onclick = "DisplayDetails()">
                <tr>
                <td> ${user.id} </td>
                <td> ${user.email} </td>
                <td> ${user.first_name} </td>
                <td> ${user.last_name} </td>
                <td><img src = "${user.avatar}"></td>
                </tr>
                </div>
                `
            })
        }
    }

    httpReq.send();
}

function DisplayDetails(user)
{
    console.log(user);
}




