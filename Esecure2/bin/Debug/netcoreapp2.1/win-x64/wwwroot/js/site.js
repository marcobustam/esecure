
/*  Calendar */
function startCalendar() {
    //alert("Starting Calendar");
    //console.warn("Starting Calendar");
    $('#external-events div.external-event').each(function () {
        var eventObject = {
            title: $.trim($(this).text()) // use the element's text as the event title
        };
        $(this).data('eventObject', eventObject);
        $(this).draggable({
            zIndex: 999,
            revert: true,      // will cause the event to go back to its
            revertDuration: 0  //  original position after the drag
        });
    });

    
    $('#calendar').fullCalendar({
        locale: 'es',
        header: {
            left: 'prev,today,next',
            center: 'title',
            right: 'month,agendaWeek,agendaDay,listMonth'
        },
        weekNumbers: true,
        validRange: {
            start: '2018-01-01',
            end: '2018-12-31'
        },
        selectable: true,
        editable: true,
        firstDay: 1,
        eventLimit: true, // allow "more" link when too many events
        events: [
            {
                title: 'All Day Event',
                start: new Date(2018, 9, 25)
            },
            {
                id: 999,
                title: 'Repeating Event',
                start: new Date(2018, 9, 15 - 3, 16, 0),
                allDay: false,
                className: 'info'
            }
        ],
        selectHelper: true,
        select: function (start, end, allDay) {
            var title = prompt('Título:');
            if (title) {
                $('#calendar').fullCalendar('renderEvent',
                    {
                        title: title,
                        start: start,
                        end: end,
                        allDay: allDay
                    },
                    true // make the event "stick"
                );
            }
            $('#calendar').fullCalendar('unselect');
        },
        droppable: true, // this allows things to be dropped onto the calendar !!!
        drop: function (date, allDay) { // this function is called when something is dropped
            var originalEventObject = $(this).data('eventObject');
            var copiedEventObject = $.extend({}, originalEventObject);
            copiedEventObject.start = date;
            copiedEventObject.allDay = allDay;
            $('#calendar').fullCalendar('renderEvent', copiedEventObject, true);
            if ($('#drop-remove').is(':checked')) {
                $(this).remove();
            }
        },
        dayClick: function (date, allDay, jsEvent, view) {
            // console.log('date' + date.format('DD/MMM/YYYY') + "allDay" + allDay.title + "jsEvent" + jsEvent + "view" + view)
        },
        /*******************************************/
        eventMouseover: function (event, jsEvent, view) {
            element = $(jsEvent.target).closest('.fc-event');
            element.attr("data-toggle", "popover2");
            element.attr("title", event.title);
            element.attr("data-content",
                'ID: ' + event.id +
                '<br/> Descripción:' + event.description +
                '<br/> event.start: ' + event.start +
                '<br/> event.url: ' + event.url +
                '<br/> event.end: ' + event.end);
            //console.log(event);
        },
        /**********************************************/
        eventClick: function (event, jsEvent, view) {
            element = $(jsEvent.target).closest('.fc-event');
            /*
            $('#modalEventInfo').html(
                '<br/> event.title: ' + event.title +
                '<br/> ID: ' + event.id +
                '<br/> Descripción:' + event.description +
                '<br/> event.start: ' + event.start +
                '<br/> event.url: ' + event.url +
                '<br/> event.end: ' + event.end); */
            //console.log(event + jsEvent + "-" + view);
            
            element.popover({ container: 'body' });
            /* Add Bootstrap - Popover data-toggle="popover" title=event.title data-content="And here's some amazing content. It's very engaging. Right?" */
            /* $('#example').popover(options) */
            //$('#modalEvent').modal('toggle');
        },
        customButtons: {
            addEventButton: {
                text: 'Crear',
                click: function () {
                    var dateStr = prompt('Enter a date in YYYY-MM-DD format');
                    var date = moment(dateStr);
                    if (date.isValid()) {
                        var eventTitle = prompt('Ingresa un título para el evento');
                    }
                    if (date.isValid()) {
                        $('#calendar').fullCalendar('renderEvent', {
                            title: 'dynamic ' + eventTitle,
                            start: date,
                            allDay: true
                        });
                        alert('Great. Now, update your database...');
                    } else {
                        alert('Invalid date.');
                    }
                }
            }
        }
    });
}
function putPath(e, data) {
    var alrt = document.getElementById('alertPath');
    var alrt2 = document.getElementById('NewFileUpFolderUpID');
    alrt.innerText = '';
    //alert(e.getAttribute("id"));    
    var dirty = $('#jstree').jstree().get_path($('#jstree').jstree("get_selected", true)[0], '/');
    var cleanPath = $.map(dirty.split("/"), $.trim);
    alrt.innerText = '/' + cleanPath.join('/');
    // alrt2.innerText = alrt.innerText;
    alrt2.value = 1;
    return;
}
/*
function showFileSizes() {
    var input, file;
    if (!window.FileReader) {
        bodyAppend("p", "File API no soportada.");
        return;
    }

    input = document.getElementById('fileinput');
    if (!input) {
        bodyAppend("p", "No se encuentra el archivo.");
    }
    else if (!input.files) {
        bodyAppend("p", "El navegador no soporta la propiedad 'files'.");
    }
    else if (!input.files[0]) {
        bodyAppend("p", "Selecciona un archivo antes de presionar el botón 'Load'");
    }
    else {
        file = input.files[0];

        elementUpdate("FileUpFileSize", file.size);
        elementUpdate("FileUpFileName", file.name);
        bodyAppend("p", "File " + file.name + " is " + file.size + " bytes in size");
    }
}
*/
