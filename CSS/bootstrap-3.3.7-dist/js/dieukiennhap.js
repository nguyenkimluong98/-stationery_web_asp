function kiemtraTen(){
	var name = document.getElementById("name").value;
	if(name==""){
		document.getElementById("info_error").innerHTML = "Vui lòng nhập đầy đủ họ tên";
	}
	for(var i =0; i<name.length;i++){
	if(!isNaN(name[0])){
		document.getElementById("info_error").innerHTML ="Vui lòng nhập đúng tên";
	}
	 else if(!isNaN(name[i])){
		document.getElementById("info_error").innerHTML ="Vui lòng nhập đúng tên";
	}

	else{
		document.getElementById("info_error").innerHTML ="";
	}
}

}
function kiemtraSDT(){
	var sdt = document.getElementById("sdt").value;
	// if(sdt==""){
	// 	document.getElementById("info_error1").innerHTML = "Vui lòng nhập số điện thoại";
	// }
	if(sdt.length <10 || sdt.length >11){
		document.getElementById("info_error1").innerHTML = "Vui lòng nhập đầy đủ số điện thoại";
	}
	else{
		if(!isNaN(sdt)){
		document.getElementById("info_error1").innerHTML ="";}
	else{
		document.getElementById("info_error1").innerHTML ="Vui lòng nhập đúng ký tự số";}
	}
	
}

function kiemtraDiaChi(){
	var dchi = document.getElementById("dchi").value;
	if(dchi==""){
		document.getElementById("info_error2").innerHTML = "Vui lòng nhập địa chỉ";
	}
	else{
		document.getElementById("info_error2").innerHTML ="";
	}
}
function checkEmail() { 
    var email = document.getElementById("txtEmail"); 
    var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/; 
    if (!filter.test(email.value)) { 
           document.getElementById("spanEmail").innerHTML ="Vui lòng nhập đúng dạng: example@gmail.com";
             email.focus; 
             return false; 
    }
    else{ 
            document.getElementById("spanEmail").innerHTML ="";
    } 
   
} 
function checkEmail2(){
	 var email = document.getElementById("txtEmail2"); 
    var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/; 
    if (!filter.test(email.value)) { 
           document.getElementById("spanEmail2").innerHTML ="Vui lòng nhập đúng dạng: example@gmail.com";
             email.focus; 
             return false; 
    }
    else{ 
            document.getElementById("spanEmail2").innerHTML ="";
    } 
}

function ktraPass(){
	 var pass = document.getElementById("txtPass").value; 
	 if(pass ==""){
	 		document.getElementById("spanPass").innerHTML ="Vui lòng nhập mật khẩu";
	 }
	 if(pass.length <8){
	 		document.getElementById("spanPass").innerHTML ="Vui lòng nhập ít nhất 8 ký tự";
	 }
	
	 else
	 {
	 	document.getElementById("spanPass").innerHTML ="";
	 }
}
function ktraNoiDung(){
	 var testnd = document.getElementById("nd").value; 
	 if(testnd ==""){
	 		document.getElementById("spanND").innerHTML ="Bạn chưa nhập nội dung";
	 }
	 
	 else
	 {
	 	document.getElementById("spanND").innerHTML ="";
	 }
}

