var concrete, brick, wood, decor, matCost;

///declaring some global variables

var concreteCost = 12;
var brickCost = 8;
var woodCost = 10;
var decorCost = 5;

function calcCost(){
    concrete = $('#concrete').val();
    brick = $('#brick').val();
    wood = $('#wood').val();
    decor = $('#decor').val();
    matCost = ((concrete * concreteCost) + (brick * brickCost) + (wood * woodCost) + (decor * decorCost));
    if(matCost >= 1){
        var num = parseFloat(matCost);
        $('#cost').val(num.toFixed(2));
    }else{
        $('#cost').val("No cost");
    }
}

function calcFootage(){
    var tc = $('#concrete').val();
    var tb = $('#brick').val();
    var tw = $('#wood').val();
    var td = $('#decor').val();
    var lcd = tc;
    if((tb/4) < lcd){
        lcd = (tb/4);
    }
    if((tw/5) < lcd){
        lcd = (tw/5);
    }
    if(td < lcd){
        lcd = td;
    }
    var num = parseFloat(lcd);
    $('#footage').val(num.toFixed(2))

}

function byMat(){
    calcCost();
    calcFootage();
}

function byCost(){
    sqftByCost();
    materialsByFootage();
}

function byFoot(){
    materialsByFootage();
    calcCost();
}

function materialsByFootage(){
    var footage = $('#footage').val();
    var wood = (5 * footage);
    var brick = (4 * footage);
    var num = parseFloat(footage);
    $('#concrete, #decor').val(num.toFixed(2));
    var num2 = parseFloat(wood);
    $('#wood').val(num2.toFixed(2));
    var num3 = parseFloat(brick);
    $('#brick').val(num3.toFixed(2));
}

function sqftByCost(){
    var num = parseFloat($('#cost').val()/99)
    $('#footage').val(num.toFixed(2));
}


