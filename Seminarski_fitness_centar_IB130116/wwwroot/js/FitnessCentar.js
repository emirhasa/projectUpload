﻿$ = jQuery;
$(document).ready(function () {


    function DodajAjax() {
        $(".ajax-submit.ajax-form").submit(function(event) {
            event.preventDefault();
            var form = $(this);
            var formData = form.serialize();
            var url = form.attr("action");
            var r = form.attr("ajax-result");
            $.ajax({
                type: "POST",
                url: url,
                data: formData,
                success: function(rezultat) {
                    $("#" + r).html(rezultat);
                    DodajAjax();
                }
            })
        })
    }

})