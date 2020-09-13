

$("#AddButton").click(function () {

    createRowForPurchase();

});


function createRowForPurchase() {

    var selectedItem = getSelectedItem();

    if (selectedItem.ItemName != "" && selectedItem.ItemQty != "" && selectedItem.ItemPrice != "") {
        var index = $("#PurchaseDetailsTable").children("tr").length;

        var sl = index;
        var indexCell = "<td style = 'display:none'> <input type = 'hidden' id ='Index" + index + "' name='PurchaseDetails.Index' value='" + index + "'></td>"

        var serialCell = "<td>" + (++sl) + "</td>";

        var itemNameCell = "<td> <input type = 'hidden' id ='ItemName" + index + "' name='PurchaseDetails[" + index + "].Name' value='" + selectedItem.ItemName + "'>" + selectedItem.ItemName + "</td>"
        var itemQtyCell = "<td> <input type = 'hidden' id ='ItemQty" + index + "' name='PurchaseDetails[" + index + "].Qty' value='" + selectedItem.ItemQty + "'>" + selectedItem.ItemQty + "</td>"
        var itemPriceCell = "<td> <input type = 'hidden' id ='ItemPrice" + index + "' name='PurchaseDetails[" + index + "].Price' value='" + selectedItem.ItemPrice + "'>" + selectedItem.ItemPrice + "</td>"
        var itemTotalAmountCell = "<td> <input type = 'hidden' id ='ItemTotalAmount" + index + "' name='PurchaseDetails[" + index + "].TotalAmount' value='" + selectedItem.ItemPrice * selectedItem.ItemQty + "'>" + selectedItem.ItemPrice * selectedItem.ItemQty + "</td>"

        var createNewRow = "<tr> " + indexCell + serialCell + itemNameCell + itemQtyCell + itemPriceCell + itemTotalAmountCell + " </tr>";

        $("#PurchaseDetailsTable").append(createNewRow);
        $("#ItemName").val("");
        $("#ItemQty").val("");
        $("#ItemPrice").val("");
        $("#ItemTotalAmount").val("");
    }
    



}







function getSelectedItem() {

    var itemName = $("#ItemName").val();
    var itemQty = $("#ItemQty").val();
    var itemPrice = $("#ItemPrice").val();
    var totalAmount = $("#ItemTotalAmount").val();



    var item = {

        "ItemName": itemName,
        "ItemQty": itemQty,
        "ItemPrice": itemPrice,
        "ItemTotalAmount": totalAmount

    }
    return item;
}