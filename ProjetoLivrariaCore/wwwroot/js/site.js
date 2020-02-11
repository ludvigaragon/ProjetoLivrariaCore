try {
    jQuery.extend(jQuery.validator.methods, {
        number: function (value, element) {
            return this.optional(element) || /^-?(?:\d+|\d{1,3}(?:\.\d{3})+)(?:,\d+)?$/.test(value);
        }
    });
}
catch{ $('#bloquear').hide(); }

function process() {
    $('#bloquear').attr('style', 'display:block; z-index:99999');
}

function processClose() {
    $('#bloquear').hide();
}

function rbGroupFilterChange(e) {
    sessionStorage["FilterType"] = e.defaultValue;
    inputSearchLoad();
}

function consultaISBN() {
    $.ajax({
        type: 'POST',
        url: "ConsultaISBN",
        data: {
            isbn: $('#ISBN').val()
        },
        success: function (result) {
            if (result) {
                $('#spanISBNExists').html("O ISBN: " + $('#ISBN').val() + " Já cadastrado. <p>Para Editar use: <a href='../Livros/EditISBN/" + $('#ISBN').val() + "'>Editar Livro</a></p>");
                $('#ISBN').val('');
                $('#spanISBNExists').show();
            }
            else {
                $('#spanISBNExists').hide();
            }
        },
        error: function (response) {

        }
    });
};

function inputSearchLoad() {
    var radioGroup = $('[name="rbGroupFilterGrid"]')
    var filtro;
    for (var i = 0; i < radioGroup.length; i++) {
        if (sessionStorage["FilterType"] && radioGroup[i].value == sessionStorage["FilterType"]) {
            radioGroup[i].checked = true;
        }
    }
    for (var i = 0; i < radioGroup.length; i++) {
        if (radioGroup[i].checked) {
            filtro = radioGroup[i].value;
            break;
        }
    }

    if (filtro == 5) {
        var value = $('#inputSearch').val().toLowerCase();
        if (value != "") {
            $("#gridLivros tr").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        }
    }
    else {
        var $input = $('#inputSearch'),
            inputContent = $input.val().toLowerCase(),
            $panel = $('#consulta'),
            column = filtro,
            $table = $panel.find('.table'),
            $rows = $table.find('tbody tr');
        var $filteredRows = $rows.filter(function () {
            var value = $(this).find('td').eq(column).text().toLowerCase();
            return value.indexOf(inputContent) === -1;
        });
        $table.find('tbody .no-result').remove();
        $rows.show();
        $filteredRows.hide();
        if ($filteredRows.length === $rows.length) {
            $table.find('tbody').prepend($('<tr class="no-result text-center"><td colspan="6">Nenhum Resultado Encontrado</td></tr>'));
        }
    }
}


$(document).ready(function () {
    if ($('#editar').length > 0) {
        $('#Preco').val($('#Preco').val().replace("R$ ", ""));
    }
    if ($('#consulta').length > 0) {
        if (sessionStorage["FilterValue"]) {
            $("#inputSearch").val(sessionStorage["FilterValue"]);
            inputSearchLoad();
        }
        $("#inputSearch").on("keyup", function (e) {
            sessionStorage["FilterValue"] = $('#inputSearch').val();
            var radioGroup = $('[name="rbGroupFilterGrid"]')
            var filtro;

            for (var i = 0; i < radioGroup.length; i++) {
                if (radioGroup[i].checked) {
                    filtro = radioGroup[i].value;
                    sessionStorage["FilterType"] = filtro;
                    break;
                }
            }

            if (filtro == 5) {
                $("#inputSearch").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridLivros tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            }
            else {
                var code = e.keyCode || e.which;
                if (code == '9') return;
                var $input = $(this),
                    inputContent = $input.val().toLowerCase(),
                    $panel = $('#consulta'),
                    column = filtro,
                    $table = $panel.find('.table'),
                    $rows = $table.find('tbody tr');
                var $filteredRows = $rows.filter(function () {
                    var value = $(this).find('td').eq(column).text().toLowerCase();
                    return value.indexOf(inputContent) === -1;
                });
                $table.find('tbody .no-result').remove();
                $rows.show();
                $filteredRows.hide();
                if ($filteredRows.length === $rows.length) {
                    $table.find('tbody').prepend($('<tr class="no-result text-center"><td colspan="6">Nenhum Resultado Encontrado</td></tr>'));
                }
            }
        });

    }

    var isFileDialogOpened = false;
    var input = document.getElementById('upFile');
    if (input) {
        input.addEventListener('click', function (e) {
            process();
            isFileDialogOpened = true
        })
    }

    window.addEventListener('focus', function (e) {
        if (isFileDialogOpened) {
            processClose();
            isFileDialogOpened = false
        }
    })

    $('#bloquear').hide();
});
