$(function () {
    wireUpButton();

    function wireUpButton() {
        var button = $('#getHarmonies');
        button.click(function () {
            clearPage();
            getChords($('#soprano').val());
        });
    }

    function getChords(soprano) {
        $.ajax({
            cache: false,
            type: 'GET',
            url: '../Home/GetChord?soprano='+soprano,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                //if data is null, do something
                fillChord(data);
            },
            error: function () {

            }
        });
    }

    function fillChord(chord) {
        $('#alto').val(chord.alto) ;
        $('#tenor').val(chord.tenor);
        $('#bass').val(chord.bass);
    };

    function clearPage()
    {
        $('#alto').val("");
        $('#tenor').val("");
        $('#bass').val("");
    }
});


