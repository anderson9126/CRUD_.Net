$(window).load(function () {
    $('.cedula').blur(function () {
       $.ajax({
    method: "POST",
           url: 'formInscripcion.aspx/BuscaCliente',
           data: "{'cedula':'" + $('.cedula').val() + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
           success: function (resultado) {
               if (typeof resultado.d == "object") {
                   $('.id_cliente').val(resultado.d[0].id_cliente);
                   $('.nombre').val(resultado.d[0].nombreApellido);
                   $('.telefono').val(resultado.d[0].telefono);
                   $('.email').val(resultado.d[0].correo);
                   $('.depa').val(resultado.d[0].departamento);
                   $('.ciudad').val(resultado.d[0].ciudad);
               }   
        }
    });
    });
});


function editar() {

   $.ajax({
       method: "POST",
       url: 'formInscripcion.aspx/Editar',
       data: "{'id_evento': '" + $('.id_cliente').val()+ "'}",
       contentType: "application/json; charset=utf-8",
       dataType: "json",
        success: function (resultado) {
           location.reload();
           alert(resultado.d);

       }
    });

};