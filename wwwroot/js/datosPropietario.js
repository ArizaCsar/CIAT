var dataTable;

$(document).ready(function () {
    cargarDatatable();
});


function cargarDatatable() {

    dataTable = $("#tablaDatosPropietario").DataTable({
        "ajax": {
            "url": "/Home/ObtenerBeneficiarios",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            /*Se pasa los nombre de los campos "ID"*/
            { "data": "id", "width": "3%" },
            /*Se pasa los nombre de los campos "nombre"*/
            { "data": "nroDocumento", "width": "15%" },
            /*Se pasa los nombre de los campos "orden"*/
            { "data": "nombre", "width": "35%" },
            { "data": "tMercadeoConvenioIdConvenio", "width": "12%" },
            {

                "data": "idBeneficiario",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href='/AdministrarQR/EditarBeneficiario/${data}'  style='cursor:pointer; width:30px;'>
                            <i class='fas fa-edit text-primary'></i>
                            </a>
                            &nbsp;
                            <a onclick=Delete("/AdministrarQR/EliminarBeneficiario/${data}") style='cursor:pointer; width:30px;'>
                            <i class='fas fa-trash-alt text-danger'></i>
                            </a>
                            `;
                }, "width": "10%"
            }
        ],
        "language": {
            url: "https://cdn.datatables.net/plug-ins/1.12.1/i18n/es-ES.json"
        },
        "width": "100%"
    });
}
