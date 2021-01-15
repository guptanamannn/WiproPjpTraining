
setInterval(function(){alert("3min Passed");},3*60*1000);
t();
function t(){
	var d = new Date();
	var ret1 = "Date: "+d.toLocaleDateString()+"<br>"+"Time: "+d.toLocaleTimeString();
	document.getElementById("time1").innerHTML = ret1;
	setInterval(t,1000);
}
function validf(){
		var fname = document.forms["myform"]["fname"].value;
		if(fname==""||fname==null){
			alert("First name must be entered");
			document.forms["myform"]["fname"].focus();
			return false;
		}
		if(!(/^[a-zA-Z]+/).test(fname)){
			alert("First name must be characters");
			document.forms["myform"]["fname"].focus();
			return false;
		}
		var lname = document.forms["myform"]["lname"].value;
		if(lname==""||lname==null){
			alert("Last name must be entered");
			document.forms["myform"]["lname"].focus();
			return false;
		}
		if(!(/^[a-zA-Z]+/).test(lname)){
			alert("Lirst name must be characters");
			document.forms["myform"]["lname"].focus();
			return false;
		}
		var pass = document.forms["myform"]["pass"].value;
		if(pass==""||pass==null){
			alert("Password must be entered");
			document.forms["myform"]["pass"].focus();
			return false;
		}
		if(pass.length<6||pass.length>20){
			alert("Password must be in range of 6 to 20");
			document.forms["myform"]["pass"].focus();
			return false;
		}

		var cpass = document.forms["myform"]["cpass"].value;
		if(cpass==""||cpass==null){
			alert("Confirm Password must be entered");
			document.forms["myform"]["cpass"].focus();
			return false;
		}
		if(cpass!=pass){
			alert("Passsword doesnt match");
			document.forms["myform"]["cpass"].focus();
			return false;
		}
		var gender = myform.querySelectorAll('input[name="gender"]:checked');
        if (!gender.length) {
            alert('You must select male or female');
            return false;
        }
        var phone = document.forms["myform"]["phone"].value;
		if(phone==""||phone==null){
			alert("Phone no. must be entered.");
			document.forms["myform"]["phone"].focus();
			return false;
		}
		if(!(/^[0-9]{3}[-. ][0-9]{3}[-. ][0-9]{4}$/).test(phone)){
			alert("Please Enter Correct Format for phone number.");
			document.forms["myform"]["phone"].focus();
			return false;
		}
		var dob = document.forms["myform"]["dob"].value;
		if(dob==""||dob==null){
			alert("Date of birth must be entered.");
			document.forms["myform"]["dob"].focus();
			return false;
		}
		if(!(/^(?:([0-2]{1}[0-9]{1})|([3]{1}[0-1]{1}))[-](?:([0]{1}[0-9]{1})|([1]{1}[0-2]{1}))[-][0-9]{4}$/).test(dob)){
			alert("Please Enter Correct Format for DOB.");
			document.forms["myform"]["phone"].focus();
			return false;
		}
		var email = document.forms["myform"]["email"].value;
		if(email==""||email==null){
			alert("Email must be entered.");
			document.forms["myform"]["email"].focus();
			return false;
		}
		if(!(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/).test(email)){
			alert("Please Enter Correct Format for Email.");
			document.forms["myform"]["email"].focus();
			return false;
		}
		
	}