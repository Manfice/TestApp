var model = {
    persons: ko.observableArray([]),
    interests: ko.observableArray([]),
    gotError:ko.observable(false),
    error: ko.observable(""),
    currentView: ko.observable("list")
};


$(document).ready(function() {
    ko.applyBindings();
    getPersons();
    model.currentView("list");
    setDefaultCallbacks(function(data) {
        if (data) {
            console.log("----BEGIN----");
            console.log(JSON.stringify(data));
            console.log("----END----");
        } else {
            console.log("-----Success (empty)");
        }
        model.gotError(false);
    },
        function(statusCode, statusText) {
            console.log("Error:" + statusCode + "(" + statusText + ")");
            model.error(statusCode + "(" + statusText + ")");
            model.gotError(true);
        }
    );
});