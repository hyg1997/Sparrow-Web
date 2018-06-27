$(function() {

    "use strict";

    $('.preloder').on('click', function() {
        $(this).fadeOut();
    });

    /* ================================================
       Navigation Menu - Hover
       ================================================ */

    function bindNavbar() {
        if ($(window).width() > 768) {
            $('.navbar .dropdown').on('mouseover', function() {
                $('.dropdown-toggle', this).next('.dropdown-menu').show();
            }).on('mouseout', function() {
                $('.dropdown-toggle', this).next('.dropdown-menu').hide();
            });

            $('.dropdown-toggle').on('click', function() {
                if ($(this).next('.dropdown-menu').is(':visible')) {
                    window.location = $(this).attr('href');
                }
            });
        } else {
            $('.navbar-default .dropdown').off('mouseover').off('mouseout');
        }
    }

    $(window).resize(function() {
        bindNavbar();
    });

    bindNavbar();
  

    /* ================================================
       jQuery Validate
       ================================================ */

    if ($.validator) {
        $.validator.setDefaults({
            ignore: [],
            highlight: function(element) {
                $(element).closest('.form-group').addClass('has-error');
            },
            unhighlight: function(element) {
                $(element).closest('.form-group').removeClass('has-error');
            },
            errorElement: 'small',
            errorClass: 'help-block',
            errorPlacement: function(error, element) {
                if (element.parent('.input-group').length || element.parent('label').length) {
                    error.insertAfter(element.parent());
                } else {
                    error.insertAfter(element);
                }
            }
        });

    }

    /* ================================================
        Wow Animation
       ================================================ */

    var scrollAnim = $('body').data('scroll-animation');

    if (scrollAnim) {
        //Wowjs
        new WOW().init();
    }



    /* ================================================
       Accordion
       ================================================ */

    //Accordion
    $('#accordion-e1 .collapse').on('shown.bs.collapse', function() {
        $(this).parent().find(".fa-plus").removeClass("fa-plus").addClass("fa-minus");
        $(this).parent().find("h4").addClass("active");

    }).on('hidden.bs.collapse', function() {
        $(this).parent().find(".fa-minus").removeClass("fa-minus").addClass("fa-plus");
        $(this).parent().find("h4").removeClass("active");
    });

    /* ================================================
       Fixed Navbar
       ================================================ */

    $(window).scroll(function() {
        var value = $(this).scrollTop();
        if (value > 350)
            $(".navbar-fixed-top").css("background", "rgba(0, 0, 0, 0.9)");

        else
            $(".navbar-fixed-top").css("background", "rgba(0, 0, 0, 0.3)");

    });

}); /* End Strict Function */
