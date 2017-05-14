function defaultErrorCallback(xhr, textStatus, errorThrown) {
    console.log(xhr);
    console.log(textStatus);
    console.log(errorThrown);
}

function postMethod(url, parameters, successCallback, errorCallback = null) {
    $.post({
        url: url,
        data: parameters == null ? new Object() : JSON.stringify(parameters),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: successCallback,
        error: errorCallback == null ? defaultErrorCallback : errorCallback
    });
}

function getMethod(url, parameters, successCallback, errorCallback = null) {
    $.get({
        url: url,
        data: parameters == null ? new Object() : JSON.stringify(parameters),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: successCallback,
        error: errorCallback == null ? defaultErrorCallback : errorCallback
    });
}

$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});



