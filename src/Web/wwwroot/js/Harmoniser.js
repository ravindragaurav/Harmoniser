$(function () {
    wireUpButton();

    function wireUpButton() {
        var button = $('#button');
        button.click(function () {
            getChords('C');
        });
    }

    function getChords(chord) {
        $.ajax({
            cache: false,
            type: 'GET',
            url: '../Home/GetChord? chord = ' + chord,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                //if data is null, do something
                alert(data);
                fillChord(data);
            },
            error: function () {

            }
        });
    }
    
});


