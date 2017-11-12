$(function () {
    wireUpButton();
    wireUpStartButton()
    wireUpStopButton()

    function wireUpButton() {
        var button = $('#getHarmonies');
        button.click(function () {
            clearPage();
            getChords($('#chord').val());
        });
    }

    function wireUpStartButton() {
        var button = $('#startRecording');
        button.click(function () {
            alert('recording');
            console.log('recording');
            startRecording();
        });
    }

    function wireUpStopButton() {
        var button = $('#stopRecording');
        button.click(function () {
            console.log('stopping');
            stopRecording();
        });
    }

    function startRecording() {
        $.ajax({
            cache: false,
            type: 'GET',
            url: '../Home/StartRecording',
            error: function () {

            }
        });
    } 

    function stopRecording() {
        $.ajax({
            cache: false,
            type: 'GET',
            url: '../Home/StopRecording',
            error: function () {

            }
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


