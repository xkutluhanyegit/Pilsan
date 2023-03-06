$(document).ready(function () {
  $(function () {
    $("#example1").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false,
      "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
    }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');

  });

  $(function () {
    $("#example1-shift").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    }).buttons().container().appendTo('#example1-shift_wrapper .col-md-6:eq(0)');

  });


  $(function () {
    $("#example1-shift1-result").DataTable({
      "responsive": true, "lengthChange": false, "autoWidth": false, "paging": false, "scrollY": "525px",
      "scrollCollapse": true,
      "paging": false,
      "buttons": []
    });

    $("#example1-shift1-result_filter").remove();
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
        $("#example1-shift1-result").append("<tr> <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <button class='btn btn-sm btn-outline-danger rounded-circle' id=''> <i class='fa-solid fa-trash'></i> </button> </td>  </tr>");
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
          console.log(response[i].sicilNo);
          $("#example1-shift1-result").append("<tr> <td> " + count + " </td> <td hidden> " + response[i].sicilNo + " </td> <td> " + response[i].name + " " + response[i].surname + " </td> <td class='text-center'> " + response[i].shiftName + " </td> <td class='text-center'> <button class='btn btn-sm btn-outline-danger rounded-circle' id=''> <i class='fa-solid fa-trash'></i> </button> </td>  </tr>");
          count++;
        });

      },
      error: function (xhr) {
        //Do Something to handle error
      }
    });


  });

});


  // $('#radio-buttons input').on('change', function () {
  //   var RadioBtnValue = $('input[name=options]:checked', '#radio-buttons').val();

  //   $.ajax({
  //     url: "https://localhost:7124/bolumler/get-by-shift-id-akulu-montaj-vardiya",
  //     type: "get", //send it through get method
  //     data: {
  //       id: RadioBtnValue
  //     },
  //     success: function (response) {

  //       $("#example1-shift1-result .odd").remove();
  //       var count = 1;

  //       $.each(response, function (i) {
  //         console.log(response[i].sicilNo);
  //         $("#example1-shift1-result").append("<tr> <td> " + count + " </td> <td> " + response[i].sicilNo + " </td> <td> " + response[i].ShiftID + " </td> </tr>");
  //         count++;
  //       });
  //     },
  //     error: function (xhr) {
  //       //Do Something to handle error
  //     }
  //   });
  // });

//   $("#example1-shift tbody tr").on("click", function () {
//     var currentRow = $(this).closest("tr");
//     var sicilNo = currentRow.find("td:eq(0)").text();
//     var DepartmanID = currentRow.find("td:eq(2)").text();
//     var ShiftID = $('input[name=options]:checked', '#radio-buttons').val();


//     $('#radio-buttons input').on('change', function () {
//       ShiftID = $('input[name=options]:checked', '#radio-buttons').val();
//     });

//     currentRow.remove();

//     $.ajax({
//       url: '/bolumler/akulu-montaj-vardiya',
//       type: 'POST',
//       dataType: 'json',
//       data: {
//         SicilNo: sicilNo,
//         ShiftID: ShiftID,
//         DepartmanId: DepartmanID,
//       },
//       success: function (data) {

//       },
//       error: function () {

//       },
//       complete: function () {

//       }
//     });
//   });

// });







