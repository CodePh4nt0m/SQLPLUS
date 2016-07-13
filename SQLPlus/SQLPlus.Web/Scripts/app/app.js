var AjaxPost = function (req, url, success, error) {
    $.ajax({
        url: url,
        type: 'POST',
        data: req,
        dataType: "json",
        async: true,
        success: function (result) {
            if (typeof success != "undefined" && success != null) {
                success(result);
            }
        },
        error: function (e) {
            if (typeof error != "undefined" && error != null) {
                error(e);
            }
        }
    });
}

//AjaxPost(req, url, function (result) {
//    if (result != null) {
//    }
//}, function (error) {
//});