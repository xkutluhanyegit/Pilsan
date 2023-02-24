$(function () {
  $("#example1").DataTable({
    "responsive": true, "lengthChange": false, "autoWidth": false,
    "buttons": ["copy", "csv", "excel", "pdf", "print", "colvis"]
  }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');

});

$(document).ready(function () {
  $("#toggleBtn").click(function () {
    if ($(window).width() <= 991) {

    }

  });
});

