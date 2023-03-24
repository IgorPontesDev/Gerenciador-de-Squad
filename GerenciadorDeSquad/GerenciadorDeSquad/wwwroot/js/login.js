$('form').on('submit', function (event) {
    alert("TESTE");
    event.preventDefault();

    var formData = {
        email: $("#email").val(),
        password: $("#password").val()
    }

    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:7263/api/User",
        success: function (result) {
            if (result.response == 'OK')
                alert("Logado")
            else
                alert("Credenciais inválidas")
        },
        error: function (error) {
            console.log(error);
        }
    })
});