$(document).ready(function()
{
    
    $('#namecheck').hide();
    let nameError = true;
    $('#fname').keyup(function () 
    {
        validateName();
    });

    //validate name field
    function validateName()
    {
        let x = document.getElementById('fname').value;
        if(x.match('^[a-zA-Z ]{3,26}$'))
        {
            $('#nameCheck').hide();
        }

        else
        {
            $('#nameCheck').show();
            nameError = false;
        }
    }

    $('#mailCheck').show();
    let mailError = true;
    $('#emailId').keyup(function(){
        validateEmail();
    }); 

    //validate email
    function validateEmail()
    {  
        let email = document.getElementById('emailId').value;
        if(email.match('^[^@\\s]+@([^@\\s]+\\.)+[^@\\s]+$'))
        {
            $('#mailCheck').hide();
        }
        else
        {
            $('#mailCheck').show();
            mailError = true;
        }
    }

    $('#phnnoCheck').show();
    let phoneError = true;
    $('#phnNo').keyup(function()
    {
        validatePhnno();
    })
    
    //validate phone no

    function validatePhnno()
    {
        let phnNo = document.getElementById('phnNo').value;
        if(phnNo.match('[0-9]{10}'))
        {
            $('#phnnoCheck').hide();
        }
        else
        {
            $('#phnnoCheck').show();
            phoneError = false;
        }
    }

    $('#submitDetails').submit(function(e) 
    {
        e.preventDefault();
        if((nameError == true) && mailError == true && phoneError == true)
        {
            alert("Submitted Successfully");
        }
    });

});













