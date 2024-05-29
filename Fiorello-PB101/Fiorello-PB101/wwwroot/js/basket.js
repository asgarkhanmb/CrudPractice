$(function () {

   
    $(document).on("click", "#products .add-basket", function () {
        let id = parseInt($(this).attr("data-id"));


        $.ajax({
            type: "POST",
            url: `home/addproducttobasket?id=${id}`,
            success: function (response) {
                $(".rounded-circle").text(response.count)
                $(".rounded-circle").next().text(`CART($${response.totalPrice})`)
            }

        });

    })

    $(document).on("click", "#cart-page .fa-trash-alt", function () {
        let id = parseInt($(this).attr("data-id"));


        $.ajax({
            type: "POST",
            url: `cart/DeleteProductFromBasket?id=${id}`,
            success: function (response) {
                $(".rounded-circle").text(response.totalCount)
                $(".rounded-circle").next().text(`CART($${response.totalPrice})`);
                $(".cart-grand-total").text(`$${response.totalPrice}`);
                $(".total-basket-count").text(`You have ${response.basketCount} items in your cart`);
                $(`[data-id=${id}]`).closest(".card").remove();

            }

        });

    })


})

$(function () {
    function updateCart(id, quantity) {

        $.ajax({
            type: "POST",
            url: `cart/UpdateProductQuantity?id=${id}&quantity=${quantity}`,
            success: function (response) {
                $(".rounded-circle").text(response.totalCount);
                $(".rounded-circle").next().text(`CART ($${response.totalPrice})`);
                $(".cart-grand-total").text(`$${response.totalPrice}`);
                $(".total-basket-count").text(`You have ${response.basketCount} items in your cart`);
                $(`[data-id=${id}]`).closest(".card").find(".item-price").text(response.itemPrice);
                $("#subtotal").text(response.subtotal);
                $("#total").text(response.total);
            }
        });
    }

    $(document).on("click", ".increase-quantity", function () {
        let id = parseInt($(this).attr("data-id"));
        let quantity = parseInt($(`.item-quantity[data-id=${id}]`).val()) + 1
        $(`.item-quantity[data-id=${id}]`).val(quantity);
        updateCart(id, quantity);
    });

    $(document).on("click", ".decrease-quantity", function () {
        let id = parseInt($(this).attr("data-id"));
        let quantity = parseInt($(`.item-quantity[data-id=${id}]`).val()) - 1
        if (quantity > 0) {
            $(`.item-quantity[data-id=${id}]`).val(quantity);
            updateCart(id, quantity);
        }
    });

   
});