$(document).ready(function () {
    ko.applyBindings(new LoginViewModel(), $('#login_content')[0]);
});


var LoginViewModel = function () {
    var self = this;

    self.Username = ko.observable('');
    self.Password = ko.observable('');
    self.RememberMe = ko.observable(false);

    self.VerificationToken = ko.observable('');

    self.Login = function () {
        $('#formLogin').addClass('sqp-loader');
        var req = {
            "__RequestVerificationToken": $("input[name=__RequestVerificationToken]").val(),
            model: {
                Email: self.Username(),
                Password: self.Password(),
                RememberMe: self.RememberMe()
            }
        }
        AjaxPost(
        req,
        '/Account/Login',
        function success(result) {
            $('#formLogin').removeClass('sqp-loader');
            if (result != null) {
                switch (result.status) {
                    case 1: // success
                        window.location.href = retunUrl == "" ? "/" : retunUrl;
                        break;
                }
            }
        },
        function error() {
            $('#formLogin').removeClass('sqp-loader');
            alert(JSON.stringify(result));
        });
    }
}