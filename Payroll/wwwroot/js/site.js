$(".text-danger").text("");
CreateNewEmployee = form => {
    $(".text-danger").text("");
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#form-modal').modal('toggle');
                    $('#modalContent').text(res.message)
                }
                else {
                    // Problem happend during the validation, display
                    // message related to the field.
                    if (res.errors != null) {
                        for (const [key, value] of Object.entries(res.errors)) {
                            if (value != null) {
                                $("#err_" + key).text(value[0].errorMessage);
                            }
                        }
                    }                   
                }
            },
            error: function (err) {
                console.log(err)
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex)
    }
}
