function validate(){
    fName_check();
    email_check();
    phone_check();
    msg_check();

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
    if(!isEmpty && isValid){
        alert("The name entered is acceptable")
    }else{
        alert("Something is wrong with this name!")
    }
}

function email_check(){
    var pattern =/^([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x22([^\x0d\x22\x5c\x80-\xff]|\x5c[\x00-\x7f])*\x22)(\x2e([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x22([^\x0d\x22\x5c\x80-\xff]|\x5c[\x00-\x7f])*\x22))*\x40([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x5b([^\x0d\x5b-\x5d\x80-\xff]|\x5c[\x00-\x7f])*\x5d)(\x2e([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x5b([^\x0d\x5b-\x5d\x80-\xff]|\x5c[\x00-\x7f])*\x5d))*$/;
    var isEmpty = true;
    var isValid = false;
    var email = $('#email').val();
    console.log(pattern.test(email));
    if(email == null || email == ""){
        isEmpty = true;
    }else{
        isEmpty = false;
    }
    if(pattern.test(email)){
        isValid = true
    }

    if(!isEmpty && isValid){
        alert(email + " looks good")
    }else{
        alert(email + " Is not a valid address")
    }
}

function phone_check(){
    var isEmpty = true;
    var isValid = false;
    var phone_number = $('#phone').val();
    console.log(phone_number.length);
    if(phone_number == null || phone_number == ""){
        isEmpty = true;
    }else{
        isEmpty = false;
    }
    if(phone_number.length == 10){
        isValid = true;
    }
    if(!isEmpty && isValid){
        alert("The phone number entered is acceptable")
    }else{
        alert("Something is wrong with this phone number!")
    }
}

function msg_check(){
    var isEmpty = true;
    var comment = $('#comments').val();
    console.log(comment);
    if(comment == null || comment == ""){
        isEmpty = true;
    }else{
        isEmpty = false;
    }
    if(!isEmpty){
        alert("Thankyou for your lovely message.")
    }else{
        alert("You have to leave a message for this to be a correct form.")
    }
}
