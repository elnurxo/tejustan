$(document).ready(function () {
    let shoecounter = $(".basket-counter").val();
    $(".basket-pr-count").text(shoecounter);
    //MODAL OPEN FETCH
    $(document).on("click", ".open-shoe-modal", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");

        fetch(url)
            .then(response => response.text())
            .then(data => {
                $("#quick_view .modal-dialog-centered").html(data)
                $("#quick_view").modal(true);
            })
    })
    //GENDER FILTER
    $(document).on("change", ".genderfilter", function (e) {
        $("#filterForm").submit();
    })
    //CATEGORY FILTER
    $(document).on("change", ".categoryfilter", function (e) {
        $("#filterForm").submit();
    })
    //COLOR FILTER
    $(document).on("change", ".colorfilter", function (e) {
        $("#filterForm").submit();
    })
    //MIN PRICE FILTER
    $(document).on("change", "#minPriceInput", function (e) {
        $("#filterForm").submit();
    })
    //MAX PRICE FILTER
    $(document).on("change", "#maxPriceInput", function (e) {
        $("#filterForm").submit();
    })
    //LOG-OUT USER
    $(document).on("click", ".logout-user", function (e) {
        e.preventDefault();
        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Log Out!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Logged Out!',
                            'Logged Out Successfully',
                            'success'
                        ).then(function () {
                            window.location = Response.url;
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Failed to Log Out!',
                            'success'
                        )
                    }
                })
            }
        })
    })
    //ADD BASKET
    $(document).on("click", ".add-to-cart-shoe", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(function (response) {
                if (!response.ok) {
                    alert("Error!")
                }
                return response.text();
            }).then(data => {
                $(".minicart-content-box").html(data)
                let shoecounter = $(".basket-counter").val();
                $(".basket-pr-count").text(shoecounter);
            });
    })
    //REMOVE BASKET
    $(document).on("click", ".remove-from-basket", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url)
            .then(function (response) {
                if (!response.ok) {
                    alert("Error!")
                }
                return response.text();
            }).then(data => {            
                $(".minicart-content-box").html(data)
                let shoecounter = $(".basket-counter").val();
                $(".basket-pr-count").text(shoecounter);
            });
    })
})






