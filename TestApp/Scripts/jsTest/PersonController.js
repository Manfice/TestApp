var defURL = "/api/person/GetPersons";
var sexUrl = "/api/person/PiopleSex";

var getPersons = function() {
    sendRequest(defURL, "GET", null, function(data) {
        model.persons.removeAll();
        model.persons.push.apply(model.persons, data);
    });
}

var getSex1 = function (sex) {
    sendRequest(sexUrl, "GET",sex, function(data) {
        model.persons.removeAll();
        model.persons.push.apply(model.persons, data);
    });
}
var getGirl = function(id) {
    $.ajax({
        url: sexUrl + '?id='+id,
        data: id,
        type: "get",
        success: function(data) {
            model.persons.removeAll();
            model.persons.push.apply(model.persons, data);
        }
    });
}