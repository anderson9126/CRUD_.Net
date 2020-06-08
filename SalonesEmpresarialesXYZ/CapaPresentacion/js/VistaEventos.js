function eliminar(x) {
 
    $.ajax({
        method: "POST",
        url: 'VistaEventos.aspx/EliminaEvento',
        data: "{'id_evento': '" + x + "'}",  
        contentType: "application/json; charset=utf-8",            
        dataType: "json",                                              
        success: function (resultado) {
            location.reload();
            alert(resultado.d);
            
        }
    });
    
};



