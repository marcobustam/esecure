jQuery(function ($) {
    // Dropdown menu
    $(".sidebar-dropdown > a").click(function () {
        $(".sidebar-submenu").slideUp(400);
        if ($(this).parent().hasClass("active")) {
            $(".sidebar-dropdown").removeClass("active");
            $(this).parent().removeClass("active");
        } else {
            $(".sidebar-dropdown").removeClass("active");
            $(this).next(".sidebar-submenu").slideDown(200);
            $(this).parent().addClass("active");
        }
    });
    // close sidebar 
    $("#close-sidebar").click(function () {
        $(".page-wrapper").removeClass("toggled");
    });
    //show sidebar
    $("#show-sidebar").click(function () {
        $(".page-wrapper").addClass("toggled");
    });
    //switch between themes 
    var themes = "chiller-theme ice-theme cool-theme light-theme";
    $('[data-theme]').click(function () {
        $('[data-theme]').removeClass("selected");
        $(this).addClass("selected");
        $('.page-wrapper').removeClass(themes);
        $('.page-wrapper').addClass($(this).attr('data-theme'));
    });
    // switch between background images
    var bgs = "bg1 bg2 bg3 bg4";
    $('[data-bg]').click(function () {
        $('[data-bg]').removeClass("selected");
        $(this).addClass("selected");
        $('.page-wrapper').removeClass(bgs);
        $('.page-wrapper').addClass($(this).attr('data-bg'));
    });
    // toggle background image
    $("#toggle-bg").change(function (e) { 
        e.preventDefault();
        $('.page-wrapper').toggleClass("sidebar-bg");
    });
    //custom scroll bar is only used on desktop
    if (!/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
        $(".sidebar-content").mCustomScrollbar({
            axis: "y",
            autoHideScrollbar: true,
            scrollInertia: 300
        });
        $(".sidebar-content").addClass("desktop");
    }
    /* Cerrado desde el inicio */
    $("#close-sidebar").click();

    // setTimeout(function () { alert("Hello"); }, 3000);
    // inicializa las tablas //
    $('#datata').DataTable({
        dom: 'Bfrtip',
        "paging": true,
        "ordering": true,
        "info": true,
        "responsive": true,
        buttons: [
            'pdf'
        ],
        "language": {
            //"url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
            "url": "/lib/datatables/json/Spanish.json"
        }
    });
    //$('[id^=datata]').each(function () {
    //    $(this).DataTable({
    //        "paging": true,
    //        "ordering": true,
    //        "info": true,
    //        "language": {
    //            "url": "//cdn.datatables.net/plug-ins/9dcbecd42ad/i18n/Spanish.json"
    //        }
    //    });
    //});
    // swal("Hello world!");
    /****************Inicializa Tooltips ***********************/
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    })
    /****************Inicializa Tooltips ***********************/

    /*
    $('#closeIcon').on('click', function () {
        $(this).closest('.card').fadeOut();
        $(this).closest('.modal').fadeOut();
        $('#soporte').click();
    });
    */
    /*
    $('#btnCerrar').on('click', function () {
        $(this).closest('.card').fadeOut();
        $(this).closest('.modal').fadeOut();
    });
    */
    

});


function ajaxCreateTicket() {
    var empresaID = 1;

    $.ajax({
        type: "GET",
        url: "/Mantenedores/Empresas/DetailsAjax?handler=List&emid=" + empresaID + "&tipo=" + callingType,
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        contentType: "application/json",
        dataType: "html",
        complete: function () {

        },
        success: function (response) {
            //swal("success!");
            if (callingType == "p") {
                var dvItems = $("#Planes");
            }
            else if (callingType == "f") {
                var dvItems = $("#Faenas");
            }
            else if (callingType == "h") {
                var dvItems = $("#Personas");
            }
            else {
                ;;
            }
            dvItems.empty();
            dvItems.html(response);
        },
        failure: function (response) {

            swal(response);
        }
    });
}

function levantaMessageError() {
    var elem = document.getElementsByName("modelMessage");
    if (elem.InnerHtml() != '') {
        swal($('#modelMessage').val);
        $('#hdnbtn2').click();
    }
    else {
        swal(elem.InnerHtml());
        $('#hdnbtn2').click();
    }
}

function CambiaEstado(empresaId, planId, tareaId, nuevoEstado) {
    //var empresaID = 1;
    // alert("Vals: " + empresaId + " " + planId + " " + tareaId + " " + nuevoEstado);
    /*
     * $.ajax({
                    type: "GET",
                    url: "/Mantenedores/Empresas/DetailsAjax?handler=List&emid=" + empresaID + "&tipo=" + callingType,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader("XSRF-TOKEN",
                            $('input:hidden[name="__RequestVerificationToken"]').val());
                    },

     */
    var txturl = "/api/Tareas/GetCambiaEstado2?emid=" + empresaId + "&plid=" + planId + "&taid=" + tareaId + "&esid=" + nuevoEstado;
    $.ajax({
        type: 'GET',
        url: txturl,
        beforeSend: function (xhr) {
            swal("before");
            xhr.setRequestHeader('XSRF-TOKEN',
                $('input:hidden[name="__RequestVerificationToken"]').val());
            //alert(url);
        },
        contentType: "application/json",
        dataType: "html",
        complete: function (response) {
            //alert("Complete!" + response);
        },
        success: function (response) {
            swal("success!" + response);
            $('#Inicia').submit();
            location.reload();
        },
        failure: function (response) {
            swal("Error en la comunicación!!\n Detalle:" + response);
        }
    });
    location.reload();
}