function Validation(thisform)
{
    with(thisform)
    {
        var name, sname, sadd, ph, email, pass, cpass;

        name = document.getElementById("TextBox1").value;
        sname = document.getElementById("TextBox2").value;
        sadd = document.getElementById("TextBox3").value;
        ph = document.getElementById("TextBox4").value;
        email = document.getElementById("TextBox5").value;
        pass = document.getElementById("TextBox6").value;
        cpass = document.getElementById("TextBox7").value;

        document.getElementById("Label1").innerHTML = "";
        document.getElementById("Label2").innerHTML = "";
        document.getElementById("Label3").innerHTML = "";
        document.getElementById("Label4").innerHTML = "";
        document.getElementById("Label5").innerHTML = "";
        document.getElementById("Label6").innerHTML = "";
        document.getElementById("Label7").innerHTML = "";

        emailExp = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/; // to validate email id

        if(name==""  && sname=="" && sadd=="" && ph=="" && email=="" && pass=="" && cpass=="")
        {
            alert("Enter all fields");
            return false;
        }
        if(name == "")
        {
            document.getElementById("Label1").innerHTML="*Please enter name";
        }
        if (sname == "") {
            document.getElementById("Label2").innerHTML = "*Please enter store name";
        }
        if (sadd == "") {
            document.getElementById("Label3").innerHTML = "*Please enter store address";
        }
        if (ph == "") {
            document.getElementById("Label4").innerHTML = "*Please enter Contact number";
        }
        if (email == "") {
            document.getElementById("Label5").innerHTML = "*Please enter email";
        }
        else {
            if (!(email.match(emailExp)))
            {
                document.getElementById("Label5").innerHTML = "*Wrong expression";
            }
        }
        if (pass == "") {
            document.getElementById("Label6").innerHTML = "*Please enter password";
        }
        if (cpass == "") {
            document.getElementById("Label7").innerHTML = "*Please confirm password";
        }
        if (cpass != pass) {
            document.getElementById("Label7").innerHTML = "*Password does not match";
        }
        if (name == "" || sname == "" || sadd == "" || ph == "" || email == "" || pass == "" || cpass == "" || !(email.match(emailExp)))
        {
            return false;
        }
        return true;
    }
}