$(function () {
    wireUpButton();

    function wireUpButton() {
        var button = $('#getHarmonies');
        button.click(function () {
            getChords($('#soprano').val());
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

    function fillChord(chord) {

        $('#alto').val() = chord.alto;
        $('#tenor').val() = chord.tenor;
        $('#bass').val() = chord.bass;
        };
});


