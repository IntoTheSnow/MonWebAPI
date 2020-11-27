$(
    function () {
    $("#BtnObtenirMusique").click(function () {

        $.ajax({
            //url: "http://localhost:8531/api/Music/2",
            url: "https://api.apiopen.top/musicRankings",
            type: "get",
            contentType: "application/json",
            dataType: "text",
            data:{},
            success: function (result,status) {
                if (status == "success") {
                    alert(result);
                }
            },
            error: function (error) {
                alert(error);
            }
        });

    });
    }
);

