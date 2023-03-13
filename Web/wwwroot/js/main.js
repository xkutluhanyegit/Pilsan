$(document).ready(function () {
  $(function () {
    $("#example1").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false,
      "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');

  });

  $(function () {
    $("#example1-shift").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "450px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    }).buttons().container().appendTo('#example1-shift_wrapper .col-md-6:eq(0)');

    $("#example1-shift_info").remove();


  });

  $(function () {
    $("#example-shift").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "ordering": false,
      "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');

  });
  //Battery 

  $(function () {
    $("#example1-shift1-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "450px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    // $("#example1-shift1-result_filter").remove();
    $("#example1-shift1-result_info").remove();
  });

  $.ajax({
    url: "https://localhost:7124/bolumler/getJsonbattery_installation_shift?=",
    type: "get", //send it through get method
    data: {
      id: 1
    },
    success: function (response) {

      $("#example1-shift1-result .odd").remove();
      var count = 1;

      $.each(response, function (i) {
        console.log(response[i].sicilNo);
        $("#example1-shift1-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonbattery_installation_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
        count++;
      });
    },
    error: function (xhr) {
      //Do Something to handle error
    }
  });

  $('#radio-buttons input').on('change', function () {
    var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

    $('#shiftidd').attr('value', RadioBtnValue);

  });


  $('#radio-buttons-vardiya input').on('change', function () {

    // $("#example1-shift tr").each(function (index) {
    //   $(this).find("td #ShiftId").attr('value', RadioBtnValue);
    // });
    alert("Hello");
    $('#shiftidd').attr('value', RadioBtnValueShift);

    var dataTable = $("#example1-shift1-result").DataTable();
    dataTable.clear().draw();

    $.ajax({
      url: "https://localhost:7124/bolumler/getJsonbattery_installation_shift",
      type: "get", //send it through get method
      data: {
        id: RadioBtnValue
      },

      success: function (response) {

        $("#example1-shift1-result .odd").remove();

        var count = 1;

        $.each(response, function (i) {
          $("#example1-shift1-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonbattery_installation_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
          count++;

        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }



    });
  });

  //İnjection

  $(function () {
    $("#example1-shift2-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    $("#example1-shift2-result_filter").remove();
  });

  $.ajax({
    url: "https://localhost:7124/bolumler/getJsoninjection_shift?=",
    type: "get", //send it through get method
    data: {
      id: 1
    },
    success: function (response) {

      $("#example1-shift2-result .odd").remove();
      var count = 1;

      $.each(response, function (i) {
        console.log(response[i].sicilNo);
        $("#example1-shift2-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsoninjection_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
        count++;
      });
    },
    error: function (xhr) {
      //Do Something to handle error
    }
  });


  $('#radio-buttons input').on('change', function () {
    var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

    $("#example1-shift tr").each(function (index) {
      $(this).find("td #ShiftId").attr('value', RadioBtnValue);
    });

    var dataTable = $("#example1-shift2-result").DataTable();
    dataTable.clear().draw();

    $.ajax({
      url: "https://localhost:7124/bolumler/getJsoninjection_shift",
      type: "get", //send it through get method
      data: {
        id: RadioBtnValue
      },

      success: function (response) {

        $("#example1-shift2-result .odd").remove();

        var count = 1;

        $.each(response, function (i) {
          $("#example1-shift2-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsoninjection_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
          count++;

        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }



    });
  });

  //Molding Room
  $(function () {
    $("#example1-shift3-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    $("#example1-shift3-result_filter").remove();
  });

  $.ajax({
    url: "https://localhost:7124/bolumler/getJsonmolding_room_shift?=",
    type: "get", //send it through get method
    data: {
      id: 1
    },
    success: function (response) {

      $("#example1-shift3-result .odd").remove();
      var count = 1;

      $.each(response, function (i) {
        console.log(response[i].sicilNo);
        $("#example1-shift3-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonmolding_room_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
        count++;
      });
    },
    error: function (xhr) {
      //Do Something to handle error
    }
  });


  $('#radio-buttons input').on('change', function () {
    var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

    $("#example1-shift tr").each(function (index) {
      $(this).find("td #ShiftId").attr('value', RadioBtnValue);
    });

    var dataTable = $("#example1-shift3-result").DataTable();
    dataTable.clear().draw();

    $.ajax({
      url: "https://localhost:7124/bolumler/getJsonmolding_room_shift",
      type: "get", //send it through get method
      data: {
        id: RadioBtnValue
      },

      success: function (response) {

        $("#example1-shift3-result .odd").remove();

        var count = 1;

        $.each(response, function (i) {
          $("#example1-shift3-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonmolding_room_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
          count++;

        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }



    });
  });

  //Toy Assembly

  $(function () {
    $("#example1-shift4-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    $("#example1-shift4-result_filter").remove();
  });

  $.ajax({
    url: "https://localhost:7124/bolumler/getJsontoy_assembly_shift?=",
    type: "get", //send it through get method
    data: {
      id: 1
    },
    success: function (response) {

      $("#example1-shift4-result .odd").remove();
      var count = 1;

      $.each(response, function (i) {
        console.log(response[i].sicilNo);
        $("#example1-shift4-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsontoy_assembly_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
        count++;
      });
    },
    error: function (xhr) {
      //Do Something to handle error
    }
  });

  $('#radio-buttons input').on('change', function () {
    var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

    $("#example1-shift tr").each(function (index) {
      $(this).find("td #ShiftId").attr('value', RadioBtnValue);
    });

    var dataTable = $("#example1-shift4-result").DataTable();
    dataTable.clear().draw();

    $.ajax({
      url: "https://localhost:7124/bolumler/getJsontoy_assembly_shift",
      type: "get", //send it through get method
      data: {
        id: RadioBtnValue
      },

      success: function (response) {

        $("#example1-shift4-result .odd").remove();

        var count = 1;

        $.each(response, function (i) {
          $("#example1-shift4-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsontoy_assembly_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
          count++;

        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }



    });
  });

  //Puffing 

  $(function () {
    $("#example1-shift5-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    $("#example1-shift5-result_filter").remove();
  });

  $.ajax({
    url: "https://localhost:7124/bolumler/getJsonpuffing_shift?=",
    type: "get", //send it through get method
    data: {
      id: 1
    },
    success: function (response) {

      $("#example1-shift5-result .odd").remove();
      var count = 1;

      $.each(response, function (i) {
        console.log(response[i].sicilNo);
        $("#example1-shift5-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonpuffing_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
        count++;
      });
    },
    error: function (xhr) {
      //Do Something to handle error
    }
  });

  $('#radio-buttons input').on('change', function () {
    var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

    $("#example1-shift tr").each(function (index) {
      $(this).find("td #ShiftId").attr('value', RadioBtnValue);
    });

    var dataTable = $("#example1-shift5-result").DataTable();
    dataTable.clear().draw();

    $.ajax({
      url: "https://localhost:7124/bolumler/getJsonpuffing_shift",
      type: "get", //send it through get method
      data: {
        id: RadioBtnValue
      },

      success: function (response) {

        $("#example1-shift5-result .odd").remove();

        var count = 1;

        $.each(response, function (i) {
          $("#example1-shift5-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonpuffing_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
          count++;

        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }



    });
  });

  //Warehouse

  $(function () {
    $("#example1-shift6-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    $("#example1-shift6-result_filter").remove();
  });

  $.ajax({
    url: "https://localhost:7124/bolumler/getJsonwarehouse_shift?=",
    type: "get", //send it through get method
    data: {
      id: 1
    },
    success: function (response) {

      $("#example1-shift6-result .odd").remove();
      var count = 1;

      $.each(response, function (i) {
        console.log(response[i].sicilNo);
        $("#example1-shift6-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonwarehouse_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
        count++;
      });
    },
    error: function (xhr) {
      //Do Something to handle error
    }
  });

  $('#radio-buttons input').on('change', function () {
    var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

    $("#example1-shift tr").each(function (index) {
      $(this).find("td #ShiftId").attr('value', RadioBtnValue);
    });

    var dataTable = $("#example1-shift6-result").DataTable();
    dataTable.clear().draw();

    $.ajax({
      url: "https://localhost:7124/bolumler/getJsonwarehouse_shift",
      type: "get", //send it through get method
      data: {
        id: RadioBtnValue
      },

      success: function (response) {

        $("#example1-shift6-result .odd").remove();

        var count = 1;

        $.each(response, function (i) {
          $("#example1-shift6-result").append("<tr>  <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <a href='/bolumler/getJsonwarehouse_shift_remove?sicilNo=" + response[i].sicilNo + " ' class='btn btn-sm btn-outline-danger rounded-circle'><i class='fa-solid fa-trash'></i></a> </td> </tr>");
          count++;

        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }



    });
  });

  $('#example1-shift tr').click(function (event) {
    if (event.target.type !== 'checkbox') {
      $(':checkbox', this).trigger('click');
    }
  });


});


