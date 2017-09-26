$(function () {
    wireUpButton();


    function wireUpButton() {
        var button = $("#button");

        anyButton.click(function () {
            getChords('C');
        });
    }


    function getPrices(chord) {
        alert(chord);

        $.ajax({
            dataType: "json",
            type : "GET",
            url: '../Controllers/Harmoniser',
            data: data,
            success: success
        });

    }
});