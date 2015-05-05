function validate(){
    fName_check();
    //email_check();
    //phone_check();
    //msg_check();

}

function fName_check(){
    var isEmpty = true;
    var isValid = false;
    var first_name = $('#fName').val();
    console.log(first_name);
    if(first_name == null || first_name == ""){
        console.log("There is nothing here.");
        var isEmpty = true;
    }else if(first_name.indexOf(' ') >= 1){
        console.log("This is correct!");
        isEmpty = false;
        isValid = true;
    }
    if(!isEmpty || isValid){
        alert("The name entered is acceptable")
    }else{
        alert("Something is wrong")
    }
}

function email_check(){
    var email = $('#email').val();
    console.log(email);
}

function phone_check(){
    var phone_number = $('#phone').val();
    console.log(phone_number);
}

function msg_check(){
    var comment = $('#comments').val();
    console.log(comment);
}
