$(document).ready(function () {
    //DELETE SLIDE
    $(document).on("click", ".delete-slide", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                        location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE-FEATURE
    $(document).on("click", ".delete-feature", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE-PARTNERSHIP
    $(document).on("click", ".delete-partnership", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE-BRAND
    $(document).on("click", ".delete-brand", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE-CATEGORY
    $(document).on("click", ".delete-category", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE-PRODUCT
    $(document).on("click", ".delete-shoe", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE-COLOR
    $(document).on("click", ".delete-color", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE REVIEW
    $(document).on("click", ".delete-review", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //DELETE MESSAGE
    $(document).on("click", ".delete-message", function (e) {
        e.preventDefault();

        let path = $(this).attr("href")

        Swal.fire({
            title: 'Are You Sure?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Delete!'
        }).then((result) => {
            if (result.isConfirmed) {
                fetch(path).then(Response => {
                    if (Response.ok) {
                        Swal.fire(
                            'Deleted!',
                            'Selected File Deleted Successfully',
                            'success'
                        ).then(function () {
                            location.reload();
                        })
                    }
                    else {
                        Swal.fire(
                            'Failed!',
                            'Selected File Deleted Successfully',
                            'success'
                        )
                        location.reload();
                    }
                })
            }
        })
    })
    //LOG-OUT ADMIN
    $(document).on("click", ".log-out-admin", function (e) {
       e.preventDefault();
        console.log("sdgkjsngsd");
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
    //DELETE IMAGE IN PRODUCT EDIT
    $(document).on("click", ".remove-img-box", function () {
        $(this).parent().remove()
    })
});

