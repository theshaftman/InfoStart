/// <reference path="jquery-2.1.1.js" />

$(function () {
    var baseUrl = 'http://217.145.162.50/JSCourse/api/';

    function getMessges(select) {
        var roomId = select.val();
        $.getJSON(baseUrl + 'Messages?roomId=' + roomId, function (data) {
            var messages = '';
            for (var i = 0; i < data.length; i++) {
                messages += '<span id="author">' +
                    data[i].Author +
                    '</span> &nbsp;&nbsp;&nbsp;' +
                    data[i].Message1 + ' <span id="date">' +
                    data[i].Date + '</span><br /><br />';
            }

            $('#messageDiv').html(messages);
        });
    }

    $('#chatSelect').on('change', function () {
        getMessges($(this));
    });

    $('#sendMessage').on('click', function () {
        var message = {
            RoomId: $('#chatSelect').val(),
            Message1: $('#message').val(),
            Author: $('#name').val(),
            Date: new Date().toJSON()
        };

        if (message.Author !== '') {
            $.post(baseUrl + 'Messages',
            message,
            function () {
                getMessges($('#chatSelect'));
            });
            document.getElementById('p').innerText = '';
        } else {
            document.getElementById('p').innerText = 'Error! Write your Name!';
        }
    })

    $.getJSON(baseUrl + 'ChatRooms', function (data) {
        var options = '';
        for (var i = 0; i < data.length; i++) {
            options += '<option value="' + data[i].Id + '">' +
                data[i].Name + '</option>';
        };

        $('#chatSelect').html(options);
    });


    $('#newRoom').on('click', function () {
        var roomName = document.getElementById('roomName').value.toString();
        var newRoom = { Name: roomName };

        if (roomName !== '') {
            $.post(baseUrl + 'ChatRooms',
                newRoom,
                function (obj) { });

            document.getElementById('p').innerText = '';
            document.getElementById('b').innerText = 'Refresh page!';
        } else {
            document.getElementById('p').innerText = 'Error! Write a name to add!';
        }
    });

    $('#removeRoom').on('click', function () {
        var roomName = document.getElementById('removeName').value.toString();

        if (roomName !== '') {

            document.getElementById('p').innerText = '';
        } else {
            document.getElementById('b').innerText = '';
            document.getElementById('p').innerText = 'Error! Write a name to remove!';
        }
    });
});
