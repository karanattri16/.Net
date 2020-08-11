$(document).ready(function(){
    $.ajax({
        url: 'http://localhost:50352/transaction/sendData',
        method: 'POST',
        data: JSON.stringify({
                num: 1
        }),
        dataType: "Application/Json",
        success: function() {
            alert();
        }
    })
})