var loanman = loanman || {};
var baseUrl = "http://localhost:50210/api/Client";

loanman.main = (function () {
    function SaveUser() {
        var client = {
            "Surname": $("#txtSurname").val(),
            "Firstname": $("#txtFirstname").val(),
            "GenderId": $("#ddlGender").val(),
            "IDNumber": $("#txtIDNumber").val(),
            "Email": $("#txtEmail").val(),
            "MobileNumber": $("#txtMobileNumber").val(),
            "TelephoneNumber": $("#txtTelephoneNumber").val(),
            "DOB": $("#txtDateOfBirth").val(),
            "tbl_Client_Address": {
                "StreetAddress1": $("#txtStreetAddress1").val(),
                "StreetAddress2": $("#txtStreetAddress2").val(),
                "City": $("#txtCity").val(),
                "CompanyName": $("#txtCompany").val(),
                "CompanyAddress": $("#txtCompanyAddress").val()
            }
        }
        debugger;
        client = JSON.stringify(client);
        $.ajax({
            url: baseUrl,
            data: client,
            type: 'post',
            dataType: 'json',
            contentType: 'application/json',
            success: function (data) {
                debugger;
                $('#target').html(data.msg);
            },
            
        });
    }

    function privateMethod() {
        // Do private stuff, or build internal.
        return "Message";
    }

    return {
        //someProperty: 'prop value',
        initialiseMain: function () {
            
            $("#Content").load("/html/client.aspx", function () {
                $("#txtDateOfBirth").datepicker();

                $("#btnSave").bind("click", function () {
                    SaveUser();
                })
            })
        }
    };
})();