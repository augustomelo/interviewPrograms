$.ajax({
    url: '/Prato/PegaRestaurantes',
    type: 'POST',
    dataType: 'json',
    success: function (data) {
        var RestauranteID = $("#RestauranteID").val() || 0;

        $.each(data, function (i, item) {
            if (item.RestauranteID != RestauranteID) {
                $('<option value="' + item.RestauranteID + '">' + item.Nome + '</option>').appendTo('#restaurantes');
            }
        });
    },
    error: function () {
        alert("Erro ao carregas restaurantes!");
    }
});
