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
                    var musiqueListe = $.parseJSON(result).result;
                    var chansonsParType = musiqueListe[0].content;  //以后可以设置变量
                    $.each(chansonsParType, function (n, item) {  //.parseJSON（）方法把JSON字符串转换为javascript对象，不转换的话将会抛出错误。
                        $("#musiqueListe").append("<p>演唱者: " + item.author + "</br>歌 名: " + item.title + "</p>");//控制输出的数据格式
                    })
                }
            },
            error: function (error) {
                alert(error);
            }
        });

    });
    }
);

