﻿const GetStudentDetails = async () => {    var Response;    try {        debugger        await $.ajax({            type: 'GET',            url: "https://localhost:7211/api/Register",            contentType: "application/json",            data: {},            async: false,            success: function (data) {                if (data != null && data.statusCode == 200) {                    if (data.resultData.length > 0) {                        var tbodydata = '';                        $.each(data.resultData, function (key, value) {                            console.log(value.id);                            tbodydata += '<tr>';                            tbodydata += '<td> <a href="/AddOrUpdate?id=' + value.id + '">Edit</a> <a href onclick="DeleteStudentById(' + value.id + ')">Delete</a></td>';                            tbodydata += '<td>' + value.bookingId + '</td>';                            tbodydata += '<td>' + value.teamName + '</td>';                            tbodydata += '<td>' + value.roomNo + '</td>';                            tbodydata += '<td>' + value.meetingDate + '</td>';                            tbodydata += '<td>' + value.fromTime + '</td>';                            tbodydata += '<td>' + value.toTime + '</td>';                            tbodydata += '<td>' + value.purpose + '</td>';                            tbodydata += '</tr>';                        });                        $("#tblEmployee").empty();                        $("#tblEmployee").append(tbodydata);                    }                }            }        });    }    catch (err) {        await console.log(err);    }    return Response;}const GetStudentDetailsById = async (SId) => {    var Response;    //"Id" this Id assinged to the table cloumn id(Stu_Id)    try {        await $.ajax({            type: 'GET',            url: "https://localhost:44362/api/Employee/GetEmployeeByIdAsync",            contentType: "application/json",            //the id assinged to captital (Id)            data: {                id: SId            },            async: false,            success: function (data) {                if (data != null && data.statusCode == 200) {                    $('#hdnId').val(data.resultData.id);                    $('#firstName').val(data.resultData.fname);                    $('#lastName').val(data.resultData.lname);                    $('#jobtitle').val(data.resultData.jobTitle);                    $('#salery').val(data.resultData.salary);                }            }        });    }    catch (err) {        await console.log(err);    }    return Response;}const AddOrUpdatevalue = async () => {    try {        debugger        var body = {            BookingId: $('#btnid').val(),            TeamName: $('#TeamName').val(),            RoomNo:($('#RoomNo').val()),            MeetingDate:  $('#MeetingDate').val(),            FromTime: $('#FromTime').val(),            ToTime: $('#ToTime').val(),            Purpose: $('#Purpose').val()            //BookingId:1,            //TeamName:"test2",            //RoomNo: 1,            //MeetingDate: "12-12-2022",            //FromTime: "12:12",            //ToTime: "12:12",            //Purpose: "test3"        }        await $.ajax({            type: 'POST',            url: 'https://localhost:7211/api/Register/AddUserDetailsAsync',            contentType: "application/json",            data: JSON.stringify(body),            success: function (data) {                console.log(data);                if (data != null && data.statusCode == 200) {                    window.location.href = "/Studentdata";                }            }        });    }    catch (err) {        await console.log(err);    }}