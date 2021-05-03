$(".text-danger").text("");
CreateNewEmployee = form => {
    $('.modal-body').empty();
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
                    $('#modalLabel').text('Create');
                    $('.modal-body').append('<p id="modalContent">' + res.message+'</p>')
                    //$('#modalContent').text(res.message);
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
function showDeletePopup(emplId) {
    $('.modal-body').empty();
    try {
        $.ajax({
            type: 'GET',
            url: 'Employee/ShowDeletePopup',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: { id: emplId },
            success: function (res) {
                $('#form-modal').modal('toggle');
                $('#modalLabel').text('Delete');                             
                $('.modal-body').html(res.view);
                $('#idEmployee').val(res.model.id);
                $('#fullName').val(res.model.fullName);
                $('#emploNo').val(res.model.employeeNo);
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
function deleteEmployee(emplId) {
    $('.modal-body').empty();
    $("#form-modal").modal('hide');
    try {
        $.ajax({
            type: "POST",
            url: "Employee/Delete",
            data: { id: emplId  },
            dataType: "text",
            success: function (res) {
                $('#form-modal').modal('toggle');
                $('#modalLabel').text('Delete');
                $('.modal-body').append('<p id="modalContent">' + res.message + '</p>')
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
